using Dynatrace.API.Client;
using System;
using System.Collections.Generic;
using Dynatrace.AppSec.Utils.Service;
using Dynatrace.AppSec.Utils.Client;
using CommandLine;
using System.Linq;
using CommandLine.Text;
using Dynatrace.AppSec.Utils.CLI.Printer;

namespace Dynatrace.AppSec.Utils.CLI {
    class Program {
        static void Main(string[] args) {

            Parser.Default.ParseArguments<CliOptions>(args)
              .WithParsed(o => {
                  string tenant = o.ApiEndpoint;
                  string token = o.ApiToken;
                  Configuration config = GetConfiguration(tenant, token);
                  if (o.Interactive) {
                      RunInteractiveMode(config);
                  } else {
                      QueryApi(o, config);
                  }
              });
        }

        private static void QueryApi(CliOptions o, Configuration config) {
            try {
                CallApi(o, config);
            } catch (Dynatrace.API.Client.ApiException e) {
                Console.WriteLine($"Failed to call API:{Environment.NewLine} Code: {e.ErrorCode}{Environment.NewLine} Message: {e.Message}");

            }
        }

        private static void RunInteractiveMode(Configuration config) {
            bool run = true;
            // interactive mode
            Console.WriteLine("Interactive mode, enter command. --help for help, press q to quit");
            while (run) {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (input.Trim() == "q") {
                    run = false;
                } else { 
                    var inputArgs = input.Split(" ")
                        .Select(a => a.Trim());
                    Parser.Default.ParseArguments<QueryOptions>(inputArgs)
                        .WithParsed(qo => CallApi(qo, config));
                }
            }
        }

        private static void CallApi(QueryOptions o, Configuration config) {
            // Bootstrap
            var securityProblemsClient = new SecurityProblemsClient(config);
            SecurityProblemsService securityProblemsService = new(securityProblemsClient);

            var monitoredEntitiesClient = new MonitoredEntitiesClient(config);
            MonitoredEntitiesService monitoredEntitiesService = new(monitoredEntitiesClient);
            EntitiesWithSecurityProblemsService entitiesWithSecurityProblemsService = new(monitoredEntitiesService, securityProblemsService);

            IPrinter printer = o.Output == Output.CSV ? new CsvPrinter() : new ConsolePrinter();

            Console.WriteLine($"[querying {o.Query} from {config.BasePath} (grouping: {o.Grouping}, filter: {o.Search}]");
            if(o.Query == Query.SecurityProblem) {
                switch (o.Grouping) {
                    case Grouping.None:
                        var securityProblems = securityProblemsService.GetSecurityProblems();
                        printer.PrintSecurityProblems(securityProblems.ToList());
                        break;
                    case Grouping.Library:
                        var securityProblemsBySoftwareComponents = entitiesWithSecurityProblemsService.GetSecurityProblemsBySoftwareComponent();
                        printer.PrintSecurityProblemsBySoftwareComponent(securityProblemsBySoftwareComponents);
                        break;
                    case Grouping.Application:
                        var securityProblemsByApplication = entitiesWithSecurityProblemsService.GetSecurityProblemsByApplication();
                        printer.PrintSecurityProblemsByEntity(securityProblemsByApplication);
                        break;
                    case Grouping.Service:
                        var securityProblemsByService = entitiesWithSecurityProblemsService.GetSecurityProblemsByService();
                        printer.PrintSecurityProblemsByEntity(securityProblemsByService);
                        break;
                    case Grouping.Host:
                        var securityProblemsByHost = entitiesWithSecurityProblemsService.GetSecurityProblemsByHost();
                        printer.PrintSecurityProblemsByEntity(securityProblemsByHost);
                        break;
                }
            } else if(o.Query == Query.Library) {
                // TODO
                //switch (o.Grouping) {
                //    case Grouping.None:
                //        var securityProblems = securityProblemsService.GetSecurityProblems();
                //        ConsolePrinter.PrintSecurityProblems(securityProblems.ToList());
                //        break;
                //    case Grouping.Library:
                //        var securityProblemsBySoftwareComponents = entitiesWithSecurityProblemsService.GetSecurityProblemsBySoftwareComponent();
                //        ConsolePrinter.PrintSecurityProblemsBySoftwareComponent(securityProblemsBySoftwareComponents);
                //        break;
                //    case Grouping.Application:
                //        var securityProblemsByApplication = entitiesWithSecurityProblemsService.GetSecurityProblemsByApplication();
                //        ConsolePrinter.PrintSecurityProblemsByEntity(securityProblemsByApplication);
                //        break;
                //    case Grouping.Service:
                //        var securityProblemsByService = entitiesWithSecurityProblemsService.GetSecurityProblemsByService();
                //        ConsolePrinter.PrintSecurityProblemsByEntity(securityProblemsByService);
                //        break;
                //    case Grouping.Host:
                //        var securityProblemsByHost = entitiesWithSecurityProblemsService.GetSecurityProblemsByHost();
                //        ConsolePrinter.PrintSecurityProblemsByEntity(securityProblemsByHost);
                //        break;
                //}
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
