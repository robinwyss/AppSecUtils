using Dynatrace.API.Api;
using Dynatrace.API.Client;
using Dynatrace.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Client {
    public class SecurityProblemsClient {
        private readonly SecurityProblemsApi securityProblemsApi;

        public SecurityProblemsClient(Configuration config) {
            securityProblemsApi = new SecurityProblemsApi(config);
        }

        public List<SecurityProblem> GetVulerabilites() {

            var result = securityProblemsApi.GetSecurityProblems();
            var securityProblems = result.SecurityProblems;
            while (result.NextPageKey != null) {
                securityProblemsApi.GetSecurityProblems(result.NextPageKey);
                securityProblems.AddRange(result.SecurityProblems);
            }
            return securityProblems;
        }

        public SecurityProblemDetails GetVulerabilityDetails(string id) {
            return securityProblemsApi.GetSecurityProblem(id);
        }

        public IEnumerable<SecurityProblemDetails> GetAllVulnerabiltiesWithDetails() {
            List<SecurityProblem> securityProblems = GetVulerabilites();
            return securityProblems.AsParallel().Select(sp => GetVulerabilityDetails(sp.SecurityProblemId));
        }
    }
}
