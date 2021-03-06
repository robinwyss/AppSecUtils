using Dynatrace.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Model {
    public class Host : EntityWrapper {

        public string Name => entity.Properties.ContainsKey("customizedName") ? entity.Properties["customizedName"] as string : entity.Properties["detectedName"] as string;

        public Host(Entity entity) : base(entity, "HOST") { }
    }
}
