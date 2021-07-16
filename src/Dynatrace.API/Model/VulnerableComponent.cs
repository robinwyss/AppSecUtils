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
    /// Vulnerable component of a security problem.
    /// </summary>
    [DataContract]
        public partial class VulnerableComponent :  IEquatable<VulnerableComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VulnerableComponent" /> class.
        /// </summary>
        public VulnerableComponent()
        {
        }
        
        /// <summary>
        /// The Dynatrace entity ID of the vulnerable component.
        /// </summary>
        /// <value>The Dynatrace entity ID of the vulnerable component.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The display name of the vulnerable component.
        /// </summary>
        /// <value>The display name of the vulnerable component.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// The file name of the vulnerable component.
        /// </summary>
        /// <value>The file name of the vulnerable component.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; private set; }

        /// <summary>
        /// The number of affected entities.
        /// </summary>
        /// <value>The number of affected entities.</value>
        [DataMember(Name="numberOfAffectedEntities", EmitDefaultValue=false)]
        public int? NumberOfAffectedEntities { get; private set; }

        /// <summary>
        /// The list of affected entities.
        /// </summary>
        /// <value>The list of affected entities.</value>
        [DataMember(Name="affectedEntities", EmitDefaultValue=false)]
        public List<string> AffectedEntities { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VulnerableComponent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  NumberOfAffectedEntities: ").Append(NumberOfAffectedEntities).Append("\n");
            sb.Append("  AffectedEntities: ").Append(AffectedEntities).Append("\n");
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
            return this.Equals(input as VulnerableComponent);
        }

        /// <summary>
        /// Returns true if VulnerableComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of VulnerableComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VulnerableComponent input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.NumberOfAffectedEntities == input.NumberOfAffectedEntities ||
                    (this.NumberOfAffectedEntities != null &&
                    this.NumberOfAffectedEntities.Equals(input.NumberOfAffectedEntities))
                ) && 
                (
                    this.AffectedEntities == input.AffectedEntities ||
                    this.AffectedEntities != null &&
                    input.AffectedEntities != null &&
                    this.AffectedEntities.SequenceEqual(input.AffectedEntities)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.NumberOfAffectedEntities != null)
                    hashCode = hashCode * 59 + this.NumberOfAffectedEntities.GetHashCode();
                if (this.AffectedEntities != null)
                    hashCode = hashCode * 59 + this.AffectedEntities.GetHashCode();
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
