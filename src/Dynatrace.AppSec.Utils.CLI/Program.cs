using Dynatrace.API.Api;
using Dynatrace.API.Client;
using Dynatrace.API.Model;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Dynatrace.AppSec.Utils.Service;
using Dynatrace.AppSec.Utils.Client;

namespace DynatraceApiExample {
    class Program {
        static void Main(string[] args) {
            if (args.Length < 2) {
                Console.WriteLine("Tenant and API Token need to be passed as parameters");
                return;
            }
            string tenant = args[0];
            string token = args[1];

            // Bootstrap
            Configuration config = GetConfiguration(tenant, token);
            var securityProblemsClient = new SecurityProblemsClient(config);
            SecurityProblemsService securityProblmesService = new(securityProblemsClient);

            var monitoredEntitiesClient = new MonitoredEntitiesClient(config);
            MonitoredEntitiesService monitoredEntitiesService = new(monitoredEntitiesClient);

            EntitiesWithSecurityProblemsService entitiesWithSecurityProblemsService = new(monitoredEntitiesService, securityProblmesService);

            // Get Vulnerabilities
            securityProblmesService.GetApplicationsWithSecurityProblems().ToList().ForEach(entry => Console.WriteLine($"Application {entry.Key} - Vulnerabilities: {entry.Value.Count}"));
            securityProblmesService.GetDatabasesWithSecurityProblems().ToList().ForEach(entry => Console.WriteLine($"Database {entry.Key} - Vulnerabilities: {entry.Value.Count}"));
            securityProblmesService.GetServicesWithSecurityProblems().ToList().ForEach(entry => Console.WriteLine($"Service {entry.Key} - Vulnerabilities: {entry.Value.Count}"));
            securityProblmesService.GetSoftwareComponentsWithSecurityProblems().ToList().ForEach(entry => Console.WriteLine($"Component {entry.Key} - Vulnerabilities: {entry.Value.Count}"));

            // Get Software Components
            var securityProblemsBySoftwareComponents = entitiesWithSecurityProblemsService.GetSecurityProblemsBySoftwareComponet();
            ConsolePrinter.PrintSecurityProblemsBySoftwareComponent(securityProblemsBySoftwareComponents);

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
