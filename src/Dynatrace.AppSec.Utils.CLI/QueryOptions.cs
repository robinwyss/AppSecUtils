using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.CLI {
    internal class QueryOptions {

        [Option('q', "query", HelpText = "The type of entity to query (possible values Library, SecurityProblem)", Default = Query.SecurityProblem)]
        public Query Query { get; set; }

        [Option('g', "grouping", HelpText = "Group vulberarbilites by entity (possible values Library, Application, Service, Host)", Default = Grouping.None)]
        public Grouping Grouping { get; set; }

        [Option('s', "search", HelpText = "Search entities (by name)")]
        public string Search { get; set; }
        
        [Option('o', "output", HelpText = "Output (possible values are Console, CSV")]
        public Output Output { get; set; }

    }

    enum Output {
        Console,
        CSV
    }

    enum Query {
        Library,
        SecurityProblem
    }

    enum Grouping {
        None,
        Library,
        Application,
        Service,
        Host
    }
}
