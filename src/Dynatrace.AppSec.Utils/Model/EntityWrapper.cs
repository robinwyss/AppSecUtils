using Dynatrace.API.Model;
using System;

namespace Dynatrace.AppSec.Utils.Model {
    public abstract class EntityWrapper : IEquatable<EntityWrapper> {
        protected readonly Entity entity;

        public string Id => entity.EntityId;

        public string Name => entity.Properties.ContainsKey("customizedName") ? entity.Properties["customizedName"] as string : entity.Properties["detectedName"] as string;

        public EntityWrapper(Entity entity, string type) {
            if (!entity.EntityId.StartsWith($"{type}-")) {
                throw new ArgumentException($"Entity must be of type {type}");
            }

            this.entity = entity;
        }

        public override bool Equals(object obj) {
            return Equals(obj as EntityWrapper);
        }

        public bool Equals(EntityWrapper other) {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Id);
        }
    }
}