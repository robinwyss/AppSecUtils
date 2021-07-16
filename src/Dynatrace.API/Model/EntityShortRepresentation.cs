/* 
 * Dynatrace Environment API
 *
 * Documentation of the Dynatrace Environment API v2. Resources here generally supersede those in v1. Migration of resources from v1 is in progress. If you miss a resource, consider using the Dynatrace Environment API v1. To read about use cases and examples, see [Dynatrace Documentation](https://dt-url.net/2u23k1k) .Notes about compatibility:* Operations marked as early adopter or preview may be changed in non-compatible ways, although we try to avoid this.* We may add new enum constants without incrementing the API version; thus, clients need to handle unknown enum constants gracefully.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Dynatrace.API.Client.SwaggerDateConverter;

namespace Dynatrace.API.Model
{
    /// <summary>
    /// The short representation of a Dynatrace entity.
    /// </summary>
    [DataContract]
        public partial class EntityShortRepresentation :  IEquatable<EntityShortRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityShortRepresentation" /> class.
        /// </summary>
        /// <param name="id">The ID of the Dynatrace entity. (required).</param>
        public EntityShortRepresentation(string id = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for EntityShortRepresentation and cannot be null");
            }
            else
            {
                this.Id = id;
            }
        }
        
        /// <summary>
        /// The ID of the Dynatrace entity.
        /// </summary>
        /// <value>The ID of the Dynatrace entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the Dynatrace entity.
        /// </summary>
        /// <value>The name of the Dynatrace entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// A short description of the Dynatrace entity.
        /// </summary>
        /// <value>A short description of the Dynatrace entity.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityShortRepresentation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EntityShortRepresentation);
        }

        /// <summary>
        /// Returns true if EntityShortRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityShortRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityShortRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
