using Dynatrace.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Model {
    public class Service : EntityWrapper {
        public Service(Entity entity) : base(entity, "SERVICE") { }
    }
}
