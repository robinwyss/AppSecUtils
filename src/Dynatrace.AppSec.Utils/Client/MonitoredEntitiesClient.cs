using Dynatrace.API.Api;
using Dynatrace.API.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynatrace.AppSec.Utils.Client {
    public class MonitoredEntitiesClient {
        private readonly MonitoredEntitiesApi monitoredEntitiesApi;

        public MonitoredEntitiesClient(Configuration config) {
            monitoredEntitiesApi = new MonitoredEntitiesApi(config);
        }

        public List<Dynatrace.API.Model.Entity> GetSoftwareComponents() {
            var result = monitoredEntitiesApi.GetEntities(entitySelector: "type(\"SOFTWARE_COMPONENT\")", fields: "properties", pageSize: 500);
            var entities = result.Entities;
            while (result.NextPageKey != null) {
                result = monitoredEntitiesApi.GetEntities(result.NextPageKey);
                entities.AddRange(result.Entities);
            }
            return entities;
        }

        public List<Dynatrace.API.Model.Entity> GetApplications() {
            var result = monitoredEntitiesApi.GetEntities(entitySelector: "type(\"APPLICATION\")", fields: "properties", pageSize: 500);
            var entities = result.Entities;
            while (result.NextPageKey != null) {
                result = monitoredEntitiesApi.GetEntities(result.NextPageKey);
                entities.AddRange(result.Entities);
            }
            return entities;
        }

        public List<Dynatrace.API.Model.Entity> GetHosts() {
            var result = monitoredEntitiesApi.GetEntities(entitySelector: "type(\"HOST\")", fields: "properties", pageSize: 500);
            var entities = result.Entities;
            while (result.NextPageKey != null) {
                result = monitoredEntitiesApi.GetEntities(result.NextPageKey);
                entities.AddRange(result.Entities);
            }
            return entities;
        }

        public List<Dynatrace.API.Model.Entity> GetServices() {
            var result = monitoredEntitiesApi.GetEntities(entitySelector: "type(\"SERVICE\")", fields: "properties", pageSize: 500);
            var entities = result.Entities;
            while (result.NextPageKey != null) {
                result = monitoredEntitiesApi.GetEntities(result.NextPageKey);
                entities.AddRange(result.Entities);
            }
            return entities;
        }
    }
}
