using Dynatrace.API.Model;
using Dynatrace.AppSec.Utils.CLI.Printer;
using Dynatrace.AppSec.Utils.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynatrace.AppSec.Utils.CLI.Printer {
    class ConsolePrinter : IPrinter {
        public void PrintSecurityProblems(List<SecurityProblemDetails> securityProblems) {
            if (securityProblems.Count == 0) {
                Console.WriteLine("  -- no security problems found --");
            } else {
                Console.WriteLine($"  -- {securityProblems.Count} security problems --");
                foreach (var securityProblem in securityProblems.OrderBy(sp => sp.RiskAssessment.RiskScore)) {
                    Console.WriteLine($"  {securityProblem.DisplayId}: {securityProblem.Title}, {securityProblem.RiskAssessment.RiskLevel}({securityProblem.RiskAssessment.RiskScore})");
                }
            }
        }

        public void PrintSecurityProblemsByEntity<T>(Dictionary<T, List<SecurityProblemDetails>> securityProblemsByEntity) where T : EntityWrapper {
            securityProblemsByEntity.Keys.ToList().ForEach(entity => {
                Console.WriteLine($"{entity.Name} ({entity.Id})");
                PrintSecurityProblems(securityProblemsByEntity[entity]);
                Console.WriteLine("");
            });
        }

        public void PrintSecurityProblemsBySoftwareComponent(Dictionary<SoftwareComponent, List<SecurityProblemDetails>> securityProblemsBySoftwareComponents) {
            securityProblemsBySoftwareComponents.Keys.ToList().ForEach(softwareComponent => {
                Console.WriteLine($"{softwareComponent.DisplayName} ({softwareComponent.FileName})");
                PrintSecurityProblems(securityProblemsBySoftwareComponents[softwareComponent]);
                Console.WriteLine("");
            });
        }
    }
}
