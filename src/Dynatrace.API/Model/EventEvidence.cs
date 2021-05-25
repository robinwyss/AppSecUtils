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
    /// The event evidence of the problem.   An event that occurred during the problem lifespan that might be related to the root cause.
    /// </summary>
    [DataContract]
        public partial class EventEvidence : Evidence,  IEquatable<EventEvidence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventEvidence" /> class.
        /// </summary>
        /// <param name="eventType">The type of the event. (required).</param>
        /// <param name="eventId">The ID of the event. (required).</param>
        public EventEvidence(string eventType = default(string), string eventId = default(string), EvidenceTypeEnum evidenceType = default(EvidenceTypeEnum), string displayName = default(string), EntityStub entity = default(EntityStub), EntityStub groupingEntity = default(EntityStub), bool? rootCauseRelevant = default(bool?), long? startTime = default(long?)) : base(evidenceType, displayName, entity, groupingEntity, rootCauseRelevant, startTime)
        {
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new InvalidDataException("eventType is a required property for EventEvidence and cannot be null");
            }
            else
            {
                this.EventType = eventType;
            }
            // to ensure "eventId" is required (not null)
            if (eventId == null)
            {
                throw new InvalidDataException("eventId is a required property for EventEvidence and cannot be null");
            }
            else
            {
                this.EventId = eventId;
            }
        }
        
        /// <summary>
        /// The type of the event.
        /// </summary>
        /// <value>The type of the event.</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The ID of the event.
        /// </summary>
        /// <value>The ID of the event.</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventEvidence {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
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
            return this.Equals(input as EventEvidence);
        }

        /// <summary>
        /// Returns true if EventEvidence instances are equal
        /// </summary>
        /// <param name="input">Instance of EventEvidence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventEvidence input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && base.Equals(input) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
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
