using Dynatrace.API.Model;
using System;

namespace Dynatrace.AppSec.Utils.Model {
    public abstract class EntityWrapper : IEquatable<EntityWrapper> {
        protected readonly Entity entity;
        public string EntityType { get; }

        public string Id => entity.EntityId;

        public string Name => entity.Properties.ContainsKey("customizedName") ? entity.Properties["customizedName"] as string : entity.Properties["detectedName"] as string;

        public EntityWrapper(Entity entity, string entityType) {
            if (!entity.EntityId.StartsWith($"{entityType}-")) {
                throw new ArgumentException($"Entity must be of type {entityType}");
            }

            this.entity = entity;
            this.EntityType = entityType;
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