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
    /// A list of update jobs of the ActiveGate.
    /// </summary>
    [DataContract]
        public partial class UpdateJobList :  IEquatable<UpdateJobList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJobList" /> class.
        /// </summary>
        public UpdateJobList()
        {
        }
        
        /// <summary>
        /// The ID of the ActiveGate.
        /// </summary>
        /// <value>The ID of the ActiveGate.</value>
        [DataMember(Name="agId", EmitDefaultValue=false)]
        public string AgId { get; private set; }

        /// <summary>
        /// A list of update jobs of the ActiveGate.
        /// </summary>
        /// <value>A list of update jobs of the ActiveGate.</value>
        [DataMember(Name="updateJobs", EmitDefaultValue=false)]
        public List<UpdateJob> UpdateJobs { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateJobList {\n");
            sb.Append("  AgId: ").Append(AgId).Append("\n");
            sb.Append("  UpdateJobs: ").Append(UpdateJobs).Append("\n");
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
            return this.Equals(input as UpdateJobList);
        }

        /// <summary>
        /// Returns true if UpdateJobList instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateJobList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateJobList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgId == input.AgId ||
                    (this.AgId != null &&
                    this.AgId.Equals(input.AgId))
                ) && 
                (
                    this.UpdateJobs == input.UpdateJobs ||
                    this.UpdateJobs != null &&
                    input.UpdateJobs != null &&
                    this.UpdateJobs.SequenceEqual(input.UpdateJobs)
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
                if (this.AgId != null)
                    hashCode = hashCode * 59 + this.AgId.GetHashCode();
                if (this.UpdateJobs != null)
                    hashCode = hashCode * 59 + this.UpdateJobs.GetHashCode();
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
