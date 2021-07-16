using Dynatrace.API.Model;
using Dynatrace.AppSec.Utils.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Service {
    public class SecurityProblemsService {

        private readonly Lazy<List<SecurityProblemDetails>> securityProblemDetails;
        public List<SecurityProblemDetails> SecurityProblemDetails {
            get {
                return securityProblemDetails.Value;
            }
        }

        private readonly SecurityProblemsClient _securityProblemsClient;

        public SecurityProblemsService(SecurityProblemsClient securityProblemsClient) {
            _securityProblemsClient = securityProblemsClient;
            securityProblemDetails = new(() => _securityProblemsClient.GetAllVulnerabiltiesWithDetails().ToList());
        }

        /// <summary>
        /// Groups the Security Problems by Applications
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<SecurityProblemDetails>> GetApplicationsWithSecurityProblems() {
            return GetSecurityProblemsByEntity(securityProblem => securityProblem.RelatedEntities?.Applications ?? new List<RelatedEntity>());
        }

        public Dictionary<string, List<SecurityProblemDetails>> GetDatabasesWithSecurityProblems() {
            return GetSecurityProblemsByEntity(securityProblem => securityProblem.RelatedEntities?.Databases ?? new List<string>());
        }

        public Dictionary<string, List<SecurityProblemDetails>> GetKubernetesClustersWithSecurityProblems() {
            return GetSecurityProblemsByEntity(securityProblem => securityProblem.RelatedEntities?.KubernetesClusters ?? new List<RelatedEntity>());
        }

        public Dictionary<string, List<SecurityProblemDetails>> GetKubernetesWorkloadsWithSecurityProblems() {
            return GetSecurityProblemsByEntity(securityProblem => securityProblem.RelatedEntities?.KubernetesWorkloads ?? new List<RelatedEntity>());
        }

        public Dictionary<string, List<SecurityProblemDetails>> GetServicesWithSecurityProblems() {
            return GetSecurityProblemsByEntity(securityProblem => securityProblem.RelatedEntities?.Services ?? new List<RelatedService>());
        }

        public Dictionary<string, List<SecurityProblemDetails>> GetHostsWithSecurityProblems() {
            return GetSecurityProblemsByEntity(securityProblem => securityProblem.RelatedEntities?.Hosts ?? new List<RelatedEntity>());
        }

        public List<SecurityProblemDetails> GetSecurityProblemsForSoftwareComponent(string name) {
            if (!GetSoftwareComponentsWithSecurityProblems().TryGetValue(name, out var resultList)) {
                resultList = new List<SecurityProblemDetails>();
            }
            return resultList;
        }

        public Dictionary<string, List<SecurityProblemDetails>> GetSoftwareComponentsWithSecurityProblems(string searchTerm = null) {
            Dictionary<string, List<SecurityProblemDetails>> dictionary = new();
            var securityProblems = GetRelevantSecurityProblems(searchTerm);
            foreach (var securityProblem in securityProblems) {
                securityProblem.VulnerableComponents.ForEach(vuc => {
                    if (dictionary.ContainsKey(vuc.Id)) {
                        dictionary[vuc.Id].Add(securityProblem);
                    } else {
                        dictionary[vuc.Id] = new List<SecurityProblemDetails> { securityProblem };
                    }
                });
            }
            return dictionary;
        }

        private IEnumerable<SecurityProblemDetails> GetRelevantSecurityProblems(string searchTerm = null) {
            return searchTerm != null ? SecurityProblemDetails.Where(spd => spd.VulnerableComponents.Any(vuc => vuc.DisplayName.ToLower().Contains(searchTerm.ToLower()))) : SecurityProblemDetails;
        }

        private Dictionary<string, List<SecurityProblemDetails>> GetSecurityProblemsByEntity(Func<SecurityProblemDetails, List<RelatedEntity>> entitySelector) {
            Func<SecurityProblemDetails, List<string>> selector = securityProblem => entitySelector(securityProblem).Select(relatedEntity => relatedEntity.Id).ToList();
            return GetSecurityProblemsByEntity(selector);
        }

        private Dictionary<string, List<SecurityProblemDetails>> GetSecurityProblemsByEntity(Func<SecurityProblemDetails, List<RelatedService>> entitySelector) {
            Func<SecurityProblemDetails, List<string>> selector = securityProblem => entitySelector(securityProblem).Select(relatedService => relatedService.Id).ToList();
            return GetSecurityProblemsByEntity(selector);
        }

        private Dictionary<string, List<SecurityProblemDetails>> GetSecurityProblemsByEntity(Func<SecurityProblemDetails, List<string>> entitySelector) {
            Dictionary<string, List<SecurityProblemDetails>> dictionary = new();
            var securityProblems = GetRelevantSecurityProblems();
            foreach (var securityProblem in securityProblems) {
                entitySelector(securityProblem).ForEach(entityId => {
                    if (dictionary.ContainsKey(entityId)) {
                        dictionary[entityId].Add(securityProblem);
                    } else {
                        dictionary[entityId] = new List<SecurityProblemDetails> { securityProblem };
                    }
                });
            }
            return dictionary;
        }

    }
}
