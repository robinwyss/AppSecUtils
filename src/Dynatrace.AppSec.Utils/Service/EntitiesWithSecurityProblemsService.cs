using Dynatrace.API.Model;
using Dynatrace.AppSec.Utils.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Service {
    public class EntitiesWithSecurityProblemsService {

        private readonly MonitoredEntitiesService monitoredEntitiesService;
        private readonly SecurityProblemsService securityProblemsService;

        public EntitiesWithSecurityProblemsService(MonitoredEntitiesService monitoredEntitiesService, SecurityProblemsService securityProblemsService) {
            this.monitoredEntitiesService = monitoredEntitiesService;
            this.securityProblemsService = securityProblemsService;
        }

        public Dictionary<Model.Application, List<SecurityProblemDetails>> GetSecurityProblemsByApplication() {
            IEnumerable<Application> applications = monitoredEntitiesService.GetApplications();
            var problemsByApplication = securityProblemsService.GetApplicationsWithSecurityProblems();
            return SecurityProblemByEntity(applications, problemsByApplication);
        }

        public Dictionary<SoftwareComponent, List<SecurityProblemDetails>> GetSecurityProblemsBySoftwareComponent() {
            IEnumerable<SoftwareComponent> softwareComponents = monitoredEntitiesService.GetSoftwareComponents();
            Dictionary<string, List<SecurityProblemDetails>> problemsByComponent = securityProblemsService.GetSoftwareComponentsWithSecurityProblems();
            return SecurityProblemByEntity(softwareComponents, problemsByComponent);
        }

        public Dictionary<Host, List<SecurityProblemDetails>> GetSecurityProblemsByHost() {
            IEnumerable<Host> hosts = monitoredEntitiesService.GetHosts();
            Dictionary<string, List<SecurityProblemDetails>> problemsByHost = securityProblemsService.GetHostsWithSecurityProblems();
            return SecurityProblemByEntity(hosts, problemsByHost);
        }
        public Dictionary<Model.Service, List<SecurityProblemDetails>> GetSecurityProblemsByService() {
            IEnumerable<Model.Service> hosts = monitoredEntitiesService.GetServices();
            Dictionary<string, List<SecurityProblemDetails>> problemsByService = securityProblemsService.GetServicesWithSecurityProblems();
            return SecurityProblemByEntity(hosts, problemsByService);
        }

        private Dictionary<T, List<SecurityProblemDetails>> SecurityProblemByEntity<T>(IEnumerable<T> entities, Dictionary<string,List<SecurityProblemDetails>> entitiesWithProblems) where T : EntityWrapper {
            return entities.ToDictionary(entity => entity, entity => {
                if (entitiesWithProblems.TryGetValue(entity.Id, out var securityProblems)) {
                    return securityProblems;
                } else {
                    return new List<SecurityProblemDetails>();
                }
            });
        }

    }
}
