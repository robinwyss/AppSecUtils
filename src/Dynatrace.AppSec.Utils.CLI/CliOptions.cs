using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynatraceApiExample {
    class CliOptions {
        [Option('e',"env", Required =true, HelpText = "Endpoint of the Dynatrace API ")]
        public string ApiEndpoint { get; set; }

        [Option('t', "token", Required = true, HelpText = "Dynatrace API token")]
        public string ApiToken { get; set; }
       
        [Option('g', "grouping", HelpText = "Group vulberarbilites by entity (possible values Library, Application, Service, Host)", Default = Grouping.Library)]
        public Grouping Grouping { get; set; }

    }

    enum Grouping {
        Library,
        Application,
        Service,
        Host
    }
}
