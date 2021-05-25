/* 
 * Dynatrace Environment API
 *
 *  Documentation of the Dynatrace Environment API v2. Resources here generally supersede those in v1. Migration of resources from v1 is in progress.   If you miss a resource, consider using the Dynatrace Environment API v1. To read about use cases and examples, refer to the [help page](https://dt-url.net/2u23k1k) .  Notes about compatibility: * Operations marked as early adopter or preview may be changed in non-compatible ways, although we try to avoid this. * We may add new enum constants without incrementing the API version; thus, clients need to handle unknown enum constants gracefully.
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
    /// The TO position of a relationship.
    /// </summary>
    [DataContract]
        public partial class ToPosition :  IEquatable<ToPosition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToPosition" /> class.
        /// </summary>
        /// <param name="toTypes">A list of monitored entity types that can occupy the TO position..</param>
        /// <param name="id">The ID of the relationship..</param>
        public ToPosition(List<string> toTypes = default(List<string>), string id = default(string))
        {
            this.ToTypes = toTypes;
            this.Id = id;
        }
        
        /// <summary>
        /// A list of monitored entity types that can occupy the TO position.
        /// </summary>
        /// <value>A list of monitored entity types that can occupy the TO position.</value>
        [DataMember(Name="toTypes", EmitDefaultValue=false)]
        public List<string> ToTypes { get; set; }

        /// <summary>
        /// The ID of the relationship.
        /// </summary>
        /// <value>The ID of the relationship.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToPosition {\n");
            sb.Append("  ToTypes: ").Append(ToTypes).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ToPosition);
        }

        /// <summary>
        /// Returns true if ToPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of ToPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ToTypes == input.ToTypes ||
                    this.ToTypes != null &&
                    input.ToTypes != null &&
                    this.ToTypes.SequenceEqual(input.ToTypes)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ToTypes != null)
                    hashCode = hashCode * 59 + this.ToTypes.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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