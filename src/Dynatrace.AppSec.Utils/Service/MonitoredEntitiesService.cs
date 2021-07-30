using Dynatrace.API.Model;
using Dynatrace.AppSec.Utils.Client;
using Dynatrace.AppSec.Utils.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Service {


    public class MonitoredEntitiesService {
        private readonly MonitoredEntitiesClient monitoredEntityClient;

        public MonitoredEntitiesService(MonitoredEntitiesClient monitoredEntityClient) {
            this.monitoredEntityClient = monitoredEntityClient;
        }

        public IEnumerable<SoftwareComponent> GetSoftwareComponents() {
            return monitoredEntityClient.GetSoftwareComponents().Select(entity => new SoftwareComponent(entity));
        }

        public IEnumerable<Application> GetApplications() {
            return monitoredEntityClient.GetApplications().Select(entity => new Application(entity));
        }

        public IEnumerable<Host> GetHosts() {
            return monitoredEntityClient.GetHosts().Select(entity => new Host(entity));
        }

        public IEnumerable<Model.Service> GetServices() {
            return monitoredEntityClient.GetServices().Select(entity => new Model.Service(entity));
        }

    }
}
