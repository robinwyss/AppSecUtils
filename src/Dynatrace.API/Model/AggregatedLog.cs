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
    /// Aggregated log records.
    /// </summary>
    [DataContract]
        public partial class AggregatedLog :  IEquatable<AggregatedLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedLog" /> class.
        /// </summary>
        /// <param name="aggregationResult">Aggregated log records..</param>
        public AggregatedLog(Dictionary<string, Dictionary<string, Dictionary<string, long?>>> aggregationResult = default(Dictionary<string, Dictionary<string, Dictionary<string, long?>>>))
        {
            this.AggregationResult = aggregationResult;
        }
        
        /// <summary>
        /// Aggregated log records.
        /// </summary>
        /// <value>Aggregated log records.</value>
        [DataMember(Name="aggregationResult", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, Dictionary<string, long?>>> AggregationResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatedLog {\n");
            sb.Append("  AggregationResult: ").Append(AggregationResult).Append("\n");
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
            return this.Equals(input as AggregatedLog);
        }

        /// <summary>
        /// Returns true if AggregatedLog instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregatedLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatedLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregationResult == input.AggregationResult ||
                    this.AggregationResult != null &&
                    input.AggregationResult != null &&
                    this.AggregationResult.SequenceEqual(input.AggregationResult)
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
                if (this.AggregationResult != null)
                    hashCode = hashCode * 59 + this.AggregationResult.GetHashCode();
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
