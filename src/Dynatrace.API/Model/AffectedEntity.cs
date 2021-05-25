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
    /// An entity affected by a security problem.
    /// </summary>
    [DataContract]
        public partial class AffectedEntity :  IEquatable<AffectedEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffectedEntity" /> class.
        /// </summary>
        public AffectedEntity()
        {
        }
        
        /// <summary>
        /// The Dynatrace entity ID of the entity.
        /// </summary>
        /// <value>The Dynatrace entity ID of the entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The number of vulnerable processes related to the entity.
        /// </summary>
        /// <value>The number of vulnerable processes related to the entity.</value>
        [DataMember(Name="numberOfVulnerableProcesses", EmitDefaultValue=false)]
        public long? NumberOfVulnerableProcesses { get; private set; }

        /// <summary>
        /// A list of vulnerable processes related to the entity.
        /// </summary>
        /// <value>A list of vulnerable processes related to the entity.</value>
        [DataMember(Name="vulnerableProcesses", EmitDefaultValue=false)]
        public List<string> VulnerableProcesses { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffectedEntity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NumberOfVulnerableProcesses: ").Append(NumberOfVulnerableProcesses).Append("\n");
            sb.Append("  VulnerableProcesses: ").Append(VulnerableProcesses).Append("\n");
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
            return this.Equals(input as AffectedEntity);
        }

        /// <summary>
        /// Returns true if AffectedEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of AffectedEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffectedEntity input)
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
                    this.NumberOfVulnerableProcesses == input.NumberOfVulnerableProcesses ||
                    (this.NumberOfVulnerableProcesses != null &&
                    this.NumberOfVulnerableProcesses.Equals(input.NumberOfVulnerableProcesses))
                ) && 
                (
                    this.VulnerableProcesses == input.VulnerableProcesses ||
                    this.VulnerableProcesses != null &&
                    input.VulnerableProcesses != null &&
                    this.VulnerableProcesses.SequenceEqual(input.VulnerableProcesses)
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
                if (this.NumberOfVulnerableProcesses != null)
                    hashCode = hashCode * 59 + this.NumberOfVulnerableProcesses.GetHashCode();
                if (this.VulnerableProcesses != null)
                    hashCode = hashCode * 59 + this.VulnerableProcesses.GetHashCode();
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
