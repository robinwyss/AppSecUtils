using Dynatrace.API.Model;
using Dynatrace.AppSec.Utils.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.CLI.Printer {
    class CsvPrinter : IPrinter {
        private const string SecurityProblemHeader = "DisplayId;Title;RiskScore;RiskLevel;PublicExploit;DataAssets;Exposure;ExposedEntities;ReachableDataAsset;Technology;Status;Muted;VulnerableComponents;AffectedEntities;Hosts;Applications;CveIds;AffectedEntities;CVSS RiskScore;CVSS BaseRiskLevel;FirstSeenTimestamp;LastUpdatedTimestamp;SecurityProblemId;ExternalVulnerabilityId;Url";

        public void PrintSecurityProblems(List<SecurityProblemDetails> securityProblems) {
            using (StreamWriter writer = new StreamWriter(@"SecurityProblems.csv")) {
                writer.WriteLine(SecurityProblemHeader);
                foreach (var sp in securityProblems) {
                    var securityProblemOutput = GenerateSecurityProblemColumns(sp);
                    writer.WriteLine(securityProblemOutput);
                }
            }
        }

        private static string GenerateSecurityProblemColumns(SecurityProblemDetails sp) {
            var affectedEntities = string.Join(',', sp.AffectedEntities);
            var hosts = string.Join(',', sp.RelatedEntities.Hosts.Select(re => re.Id));
            var applications = string.Join(',', sp.RelatedEntities.Applications.Select(re => re.Id));
            var vulnerableComponents = string.Join(',', sp.VulnerableComponents.Select(vuc => vuc.Id));
            var cveIds = string.Join(',', sp.CveIds);

            return
                $"{sp.DisplayId};" +
                $"{sp.Title};" +
                $"{sp.RiskAssessment.RiskScore};" +
                $"{sp.RiskAssessment.RiskLevel};" +
                $"{sp.RiskAssessment.PublicExploit};" +
                $"{sp.RiskAssessment.DataAssets};" +
                $"{sp.RiskAssessment.Exposure};" +
                $"{sp.ExposedEntities.Count > 0};" +
                $"{sp.ReachableDataAssets.Count > 0};" +
                $"{sp.Technology};" +
                $"{sp.Status};" +
                $"{sp.Muted};" +
                $"{vulnerableComponents};" +
                $"{affectedEntities};" +
                $"{hosts};" +
                $"{applications};" +
                $"{cveIds};" +
                $"{affectedEntities};" +
                $"{sp.RiskAssessment.BaseRiskScore};" +
                $"{sp.RiskAssessment.BaseRiskLevel};" +
                $"{sp.FirstSeenTimestamp};" +
                $"{sp.LastUpdatedTimestamp};" +
                $"{sp.SecurityProblemId};" +
                $"{sp.ExternalVulnerabilityId};" +
                $"{sp.Url}";
        }

        public void PrintSecurityProblemsByEntity<T>(Dictionary<T, List<SecurityProblemDetails>> securityProblemsByApplication) where T : EntityWrapper {
            var entityType = securityProblemsByApplication.Keys.First().EntityType;
            using (StreamWriter writer = new StreamWriter($"SecurityProblemsBy{entityType}.csv")) {
                writer.WriteLine($"{entityType} ID;{entityType} Name;{SecurityProblemHeader}");
                foreach (var entity in securityProblemsByApplication.Keys) {
                    foreach (var sp in securityProblemsByApplication[entity]) {
                        var securityProblemColumns = GenerateSecurityProblemColumns(sp);
                        writer.WriteLine($"{entity.Name};{entity.Id};{securityProblemColumns}");
                    }
                }
            }
        }

        public void PrintSecurityProblemsBySoftwareComponent(Dictionary<SoftwareComponent, List<SecurityProblemDetails>> securityProblemsBySoftwareComponents) {
            using (StreamWriter writer = new StreamWriter($"SecurityProblemsByLibrary.csv")) {
                writer.WriteLine($"Library;{SecurityProblemHeader}");
                foreach (var library in securityProblemsBySoftwareComponents.Keys) {
                    foreach (var sp in securityProblemsBySoftwareComponents[library]) {
                        var securityProblemColumns = GenerateSecurityProblemColumns(sp);
                        writer.WriteLine($"{library.Name};{securityProblemColumns}");
                    }
                }
            }
        }

        public void PrintLibraries(IEnumerable<SoftwareComponent> libraries) {
            using (StreamWriter writer = new StreamWriter($"Libraries.csv")) {
                writer.WriteLine($"DetectedName;FileName;PackageName;Type;DisplayName;Name;ID");
                foreach (var library in libraries) {
                    writer.WriteLine($"{library.DetectedName};{library.FileName};{library.PackageName};{library.Type};{library.DisplayName};{library.Name};{library.Id}");
                }
            }
        }
    }
}
