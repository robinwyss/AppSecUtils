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
    /// The availability evidence of the problem. Indicates an entity that has been unavailable during the problem lifespan and that might be related to the root cause.
    /// </summary>
    [DataContract]
        public partial class AvailabilityEvidence : Evidence,  IEquatable<AvailabilityEvidence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityEvidence" /> class.
        /// </summary>
        /// <param name="endTime">The end time of the evidence, in UTC milliseconds. (required).</param>
        public AvailabilityEvidence(long? endTime = default(long?), EvidenceTypeEnum evidenceType = default(EvidenceTypeEnum), string displayName = default(string), EntityStub entity = default(EntityStub), EntityStub groupingEntity = default(EntityStub), bool? rootCauseRelevant = default(bool?), long? startTime = default(long?)) : base(evidenceType, displayName, entity, groupingEntity, rootCauseRelevant, startTime)
        {
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new InvalidDataException("endTime is a required property for AvailabilityEvidence and cannot be null");
            }
            else
            {
                this.EndTime = endTime;
            }
        }
        
        /// <summary>
        /// The end time of the evidence, in UTC milliseconds.
        /// </summary>
        /// <value>The end time of the evidence, in UTC milliseconds.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityEvidence {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AvailabilityEvidence);
        }

        /// <summary>
        /// Returns true if AvailabilityEvidence instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailabilityEvidence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityEvidence input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                int hashCode = base.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
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
