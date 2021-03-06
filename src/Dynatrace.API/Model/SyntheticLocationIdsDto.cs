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
    /// A DTO for synthetic Location IDs.
    /// </summary>
    [DataContract]
        public partial class SyntheticLocationIdsDto :  IEquatable<SyntheticLocationIdsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyntheticLocationIdsDto" /> class.
        /// </summary>
        /// <param name="entityId">Entity ID to be transferred (required).</param>
        /// <param name="geoLocationId">GeoLocation ID to be transferred (required).</param>
        public SyntheticLocationIdsDto(string entityId = default(string), string geoLocationId = default(string))
        {
            // to ensure "entityId" is required (not null)
            if (entityId == null)
            {
                throw new InvalidDataException("entityId is a required property for SyntheticLocationIdsDto and cannot be null");
            }
            else
            {
                this.EntityId = entityId;
            }
            // to ensure "geoLocationId" is required (not null)
            if (geoLocationId == null)
            {
                throw new InvalidDataException("geoLocationId is a required property for SyntheticLocationIdsDto and cannot be null");
            }
            else
            {
                this.GeoLocationId = geoLocationId;
            }
        }
        
        /// <summary>
        /// Entity ID to be transferred
        /// </summary>
        /// <value>Entity ID to be transferred</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// GeoLocation ID to be transferred
        /// </summary>
        /// <value>GeoLocation ID to be transferred</value>
        [DataMember(Name="geoLocationId", EmitDefaultValue=false)]
        public string GeoLocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyntheticLocationIdsDto {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  GeoLocationId: ").Append(GeoLocationId).Append("\n");
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
            return this.Equals(input as SyntheticLocationIdsDto);
        }

        /// <summary>
        /// Returns true if SyntheticLocationIdsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SyntheticLocationIdsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyntheticLocationIdsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.GeoLocationId == input.GeoLocationId ||
                    (this.GeoLocationId != null &&
                    this.GeoLocationId.Equals(input.GeoLocationId))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.GeoLocationId != null)
                    hashCode = hashCode * 59 + this.GeoLocationId.GetHashCode();
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
