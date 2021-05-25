using Dynatrace.API.Model;
using System;

namespace Dynatrace.AppSec.Utils.Model {
    public abstract class EntityWrapper {
        protected readonly Entity entity;

        public string ID => entity.EntityId;

        public EntityWrapper(Entity entity, string type) {
            if (!entity.EntityId.StartsWith($"{type}-")) {
                throw new ArgumentException("Entity must be of type SOFTWARE_COMPONENT");
            }

            this.entity = entity;
        }

    }
}