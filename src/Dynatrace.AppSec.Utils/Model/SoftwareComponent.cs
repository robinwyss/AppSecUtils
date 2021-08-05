using Dynatrace.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Model {

    public class SoftwareComponent : EntityWrapper {


        public string DisplayName => entity.DisplayName;

        public string FileName {
            get {
                return Type == "JAVA" ? entity.Properties["softwareComponentFileName"] as string : DisplayName;
            }
        }
        public string DetectedName => entity.Properties["detectedName"] as string;
        public string Type => entity.Properties["softwareComponentType"] as string;
        public string PackageName => entity.Properties.ContainsKey("packageName") ? entity.Properties["packageName"] as string : string.Empty;

        public SoftwareComponent(Entity entity) : base(entity, "SOFTWARE_COMPONENT") { }


    }
}
