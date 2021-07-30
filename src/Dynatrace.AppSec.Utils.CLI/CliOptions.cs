using CommandLine;
using Dynatrace.AppSec.Utils.CLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.CLI {

    internal class CliOptions : QueryOptions {

        [Option('e', "env", Required = true, HelpText = "Endpoint of the Dynatrace API ")]
        public string ApiEndpoint { get; set; }

        [Option('t', "token", Required = true, HelpText = "Dynatrace API token")]
        public string ApiToken { get; set; }

        [Option('i', "interactive", Required = false, HelpText = "Run in interactive mode (avoids having to specify Environment and Token every time)")]
        public bool Interactive { get; set; }

    }
}
