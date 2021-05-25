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

        private readonly Lazy<IEnumerable<SoftwareComponent>> softwareComponents;
        public IEnumerable<SoftwareComponent> SoftwareComponents => softwareComponents.Value;

        private readonly Lazy<IEnumerable<Application>> applications;
        public IEnumerable<Application> Applications => applications.Value;

        private readonly Lazy<IEnumerable<Host>> hosts;
        public IEnumerable<Host> Hosts => hosts.Value;

        private readonly Lazy<IEnumerable<Model.Service>> services;
        public IEnumerable<Model.Service> Services => services.Value;

        public MonitoredEntitiesService(MonitoredEntitiesClient monitoredEntityClient) {
            softwareComponents = new(() => monitoredEntityClient.GetSoftwareComponents().Select(entity => new SoftwareComponent(entity)));

            applications = new(() => monitoredEntityClient.GetApplications().Select(entity => new Application(entity)));

            hosts = new(() => monitoredEntityClient.GetHosts().Select(entity => new Host(entity)));

            services = new(() => monitoredEntityClient.GetServices().Select(entity => new Model.Service(entity)));
        }

    }
}
