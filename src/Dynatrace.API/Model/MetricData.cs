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
    /// A list of metrics and their data points.
    /// </summary>
    [DataContract]
        public partial class MetricData :  IEquatable<MetricData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricData" /> class.
        /// </summary>
        /// <param name="nextPageKey">The cursor for the next page of results. Has the value of &#x60;null&#x60; on the last page.   Use it in the **nextPageKey** query parameter to obtain subsequent pages of the result. (required).</param>
        /// <param name="totalCount">The total number of primary entities in the result.   Has the &#x60;0&#x60; value if none of the requested metrics is suitable for pagination. (required).</param>
        /// <param name="warnings">A list of warnings.</param>
        /// <param name="result">A list of metrics and their data points..</param>
        public MetricData(string nextPageKey = default(string), long? totalCount = default(long?), List<string> warnings = default(List<string>), List<MetricSeriesCollection> result = default(List<MetricSeriesCollection>))
        {
            // to ensure "nextPageKey" is required (not null)
            if (nextPageKey == null)
            {
                throw new InvalidDataException("nextPageKey is a required property for MetricData and cannot be null");
            }
            else
            {
                this.NextPageKey = nextPageKey;
            }
            // to ensure "totalCount" is required (not null)
            if (totalCount == null)
            {
                throw new InvalidDataException("totalCount is a required property for MetricData and cannot be null");
            }
            else
            {
                this.TotalCount = totalCount;
            }
            this.Warnings = warnings;
            this.Result = result;
        }
        
        /// <summary>
        /// The cursor for the next page of results. Has the value of &#x60;null&#x60; on the last page.   Use it in the **nextPageKey** query parameter to obtain subsequent pages of the result.
        /// </summary>
        /// <value>The cursor for the next page of results. Has the value of &#x60;null&#x60; on the last page.   Use it in the **nextPageKey** query parameter to obtain subsequent pages of the result.</value>
        [DataMember(Name="nextPageKey", EmitDefaultValue=false)]
        public string NextPageKey { get; set; }

        /// <summary>
        /// The total number of primary entities in the result.   Has the &#x60;0&#x60; value if none of the requested metrics is suitable for pagination.
        /// </summary>
        /// <value>The total number of primary entities in the result.   Has the &#x60;0&#x60; value if none of the requested metrics is suitable for pagination.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// A list of warnings
        /// </summary>
        /// <value>A list of warnings</value>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// A list of metrics and their data points.
        /// </summary>
        /// <value>A list of metrics and their data points.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public List<MetricSeriesCollection> Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricData {\n");
            sb.Append("  NextPageKey: ").Append(NextPageKey).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as MetricData);
        }

        /// <summary>
        /// Returns true if MetricData instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextPageKey == input.NextPageKey ||
                    (this.NextPageKey != null &&
                    this.NextPageKey.Equals(input.NextPageKey))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    input.Result != null &&
                    this.Result.SequenceEqual(input.Result)
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
                if (this.NextPageKey != null)
                    hashCode = hashCode * 59 + this.NextPageKey.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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
