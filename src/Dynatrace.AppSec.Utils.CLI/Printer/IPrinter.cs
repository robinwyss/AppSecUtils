using Dynatrace.API.Model;
using Dynatrace.AppSec.Utils.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.CLI.Printer {
    interface IPrinter {

        void PrintSecurityProblemsBySoftwareComponent(Dictionary<SoftwareComponent, List<SecurityProblemDetails>> securityProblemsBySoftwareComponents);

        void PrintSecurityProblemsByEntity<T>(Dictionary<T, List<SecurityProblemDetails>> securityProblemsByApplication) where T : EntityWrapper;


        void PrintSecurityProblems(List<SecurityProblemDetails> securityProblems);
    }
}
