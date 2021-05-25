using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynatraceApiExample {
    class CliOptions {
        [Option('t',"tenant", Required =true, HelpText = "Endpoint of the Dynatrace API ")]
        public string ApiEndpoint { get; set; }

        [Option('k', "token", Required = true, HelpText = "Dynatrace API token")]
        public string ApiToken { get; set; }
       
        [Option('g', "", HelpText = "Grouping")]
        public string Grouping { get; set; }

    }
}
