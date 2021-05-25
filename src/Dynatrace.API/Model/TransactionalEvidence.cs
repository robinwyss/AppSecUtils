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
    /// The transactional evidence of the problem.   A behavior of a metric in an transaction that indicates the problem and/or is its root cause.
    /// </summary>
    [DataContract]
        public partial class TransactionalEvidence : Evidence,  IEquatable<TransactionalEvidence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionalEvidence" /> class.
        /// </summary>
        /// <param name="valueAfterChangePoint">The metric&#x27;s value after the problem start. (required).</param>
        /// <param name="valueBeforeChangePoint">The metric&#x27;s value before the problem start. (required).</param>
        /// <param name="endTime">The end time of the evidence, in UTC milliseconds (required).</param>
        /// <param name="unit">The unit of the metric. (required).</param>
        public TransactionalEvidence(float? valueAfterChangePoint = default(float?), float? valueBeforeChangePoint = default(float?), long? endTime = default(long?), string unit = default(string), EvidenceTypeEnum evidenceType = default(EvidenceTypeEnum), string displayName = default(string), EntityStub entity = default(EntityStub), EntityStub groupingEntity = default(EntityStub), bool? rootCauseRelevant = default(bool?), long? startTime = default(long?)) : base(evidenceType, displayName, entity, groupingEntity, rootCauseRelevant, startTime)
        {
            // to ensure "valueAfterChangePoint" is required (not null)
            if (valueAfterChangePoint == null)
            {
                throw new InvalidDataException("valueAfterChangePoint is a required property for TransactionalEvidence and cannot be null");
            }
            else
            {
                this.ValueAfterChangePoint = valueAfterChangePoint;
            }
            // to ensure "valueBeforeChangePoint" is required (not null)
            if (valueBeforeChangePoint == null)
            {
                throw new InvalidDataException("valueBeforeChangePoint is a required property for TransactionalEvidence and cannot be null");
            }
            else
            {
                this.ValueBeforeChangePoint = valueBeforeChangePoint;
            }
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new InvalidDataException("endTime is a required property for TransactionalEvidence and cannot be null");
            }
            else
            {
                this.EndTime = endTime;
            }
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new InvalidDataException("unit is a required property for TransactionalEvidence and cannot be null");
            }
            else
            {
                this.Unit = unit;
            }
        }
        
        /// <summary>
        /// The metric&#x27;s value after the problem start.
        /// </summary>
        /// <value>The metric&#x27;s value after the problem start.</value>
        [DataMember(Name="valueAfterChangePoint", EmitDefaultValue=false)]
        public float? ValueAfterChangePoint { get; set; }

        /// <summary>
        /// The metric&#x27;s value before the problem start.
        /// </summary>
        /// <value>The metric&#x27;s value before the problem start.</value>
        [DataMember(Name="valueBeforeChangePoint", EmitDefaultValue=false)]
        public float? ValueBeforeChangePoint { get; set; }

        /// <summary>
        /// The end time of the evidence, in UTC milliseconds
        /// </summary>
        /// <value>The end time of the evidence, in UTC milliseconds</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The unit of the metric.
        /// </summary>
        /// <value>The unit of the metric.</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionalEvidence {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ValueAfterChangePoint: ").Append(ValueAfterChangePoint).Append("\n");
            sb.Append("  ValueBeforeChangePoint: ").Append(ValueBeforeChangePoint).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as TransactionalEvidence);
        }

        /// <summary>
        /// Returns true if TransactionalEvidence instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionalEvidence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionalEvidence input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ValueAfterChangePoint == input.ValueAfterChangePoint ||
                    (this.ValueAfterChangePoint != null &&
                    this.ValueAfterChangePoint.Equals(input.ValueAfterChangePoint))
                ) && base.Equals(input) && 
                (
                    this.ValueBeforeChangePoint == input.ValueBeforeChangePoint ||
                    (this.ValueBeforeChangePoint != null &&
                    this.ValueBeforeChangePoint.Equals(input.ValueBeforeChangePoint))
                ) && base.Equals(input) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && base.Equals(input) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.ValueAfterChangePoint != null)
                    hashCode = hashCode * 59 + this.ValueAfterChangePoint.GetHashCode();
                if (this.ValueBeforeChangePoint != null)
                    hashCode = hashCode * 59 + this.ValueBeforeChangePoint.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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