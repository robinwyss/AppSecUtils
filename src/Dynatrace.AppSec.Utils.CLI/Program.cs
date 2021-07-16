using Dynatrace.API.Client;
using System;
using System.Collections.Generic;
using Dynatrace.AppSec.Utils.Service;
using Dynatrace.AppSec.Utils.Client;
using CommandLine;

namespace DynatraceApiExample {
    class Program {
        static void Main(string[] args) {
            Parser.Default.ParseArguments<CliOptions>(args)
                  .WithParsed(o => {
                      string tenant = o.ApiEndpoint;
                      string token = o.ApiToken;
                      try {
                          CallApi(o, tenant, token);
                      } catch (Dynatrace.API.Client.ApiException e) {
                          Console.WriteLine($"Failed to call API:{Environment.NewLine} Code: {e.ErrorCode}{Environment.NewLine} Message: {e.Message}");
                      }
                      
                  });

        }

        private static void CallApi(CliOptions o, string tenant, string token) {
            // Bootstrap
            Configuration config = GetConfiguration(tenant, token);
            var securityProblemsClient = new SecurityProblemsClient(config);
            SecurityProblemsService securityProblmesService = new(securityProblemsClient);

            var monitoredEntitiesClient = new MonitoredEntitiesClient(config);
            MonitoredEntitiesService monitoredEntitiesService = new(monitoredEntitiesClient);
            EntitiesWithSecurityProblemsService entitiesWithSecurityProblemsService = new(monitoredEntitiesService, securityProblmesService);


            switch (o.Grouping) {
                case Grouping.Library:
                    var securityProblemsBySoftwareComponents = entitiesWithSecurityProblemsService.GetSecurityProblemsBySoftwareComponent();
                    ConsolePrinter.PrintSecurityProblemsBySoftwareComponent(securityProblemsBySoftwareComponents);
                    break;
                case Grouping.Application:
                    var securityProblemsByApplication = entitiesWithSecurityProblemsService.GetSecurityProblemsByApplication();
                    ConsolePrinter.PrintSecurityProblemsByEntity(securityProblemsByApplication);
                    break;
                case Grouping.Service:
                    var securityProblemsByService = entitiesWithSecurityProblemsService.GetSecurityProblemsByService();
                    ConsolePrinter.PrintSecurityProblemsByEntity(securityProblemsByService);
                    break;
                case Grouping.Host:
                    var securityProblemsByHost = entitiesWithSecurityProblemsService.GetSecurityProblemsByHost();
                    ConsolePrinter.PrintSecurityProblemsByEntity(securityProblemsByHost);
                    break;
            }
        }

        private static Configuration GetConfiguration(string tenant, string token) {
            var config = new Configuration() {
                BasePath = $"{tenant}/api/v2",
                ApiKey = new Dictionary<string, string>() { { "Authorization", token } },
                ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Api-Token" } }
            };
            // need to create the API Client before setting timeout, BUG?
            var client = config.ApiClient;
            config.Timeout = 10000;
            return config;
        }
    }
}
