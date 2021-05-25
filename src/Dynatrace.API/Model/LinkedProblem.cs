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
    /// The properties of the linked problem.
    /// </summary>
    [DataContract]
        public partial class LinkedProblem :  IEquatable<LinkedProblem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedProblem" /> class.
        /// </summary>
        /// <param name="displayId">The display ID of the problem. (required).</param>
        /// <param name="problemId">The ID of the problem. (required).</param>
        public LinkedProblem(string displayId = default(string), string problemId = default(string))
        {
            // to ensure "displayId" is required (not null)
            if (displayId == null)
            {
                throw new InvalidDataException("displayId is a required property for LinkedProblem and cannot be null");
            }
            else
            {
                this.DisplayId = displayId;
            }
            // to ensure "problemId" is required (not null)
            if (problemId == null)
            {
                throw new InvalidDataException("problemId is a required property for LinkedProblem and cannot be null");
            }
            else
            {
                this.ProblemId = problemId;
            }
        }
        
        /// <summary>
        /// The display ID of the problem.
        /// </summary>
        /// <value>The display ID of the problem.</value>
        [DataMember(Name="displayId", EmitDefaultValue=false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// The ID of the problem.
        /// </summary>
        /// <value>The ID of the problem.</value>
        [DataMember(Name="problemId", EmitDefaultValue=false)]
        public string ProblemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkedProblem {\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  ProblemId: ").Append(ProblemId).Append("\n");
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
            return this.Equals(input as LinkedProblem);
        }

        /// <summary>
        /// Returns true if LinkedProblem instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedProblem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedProblem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.ProblemId == input.ProblemId ||
                    (this.ProblemId != null &&
                    this.ProblemId.Equals(input.ProblemId))
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
                if (this.DisplayId != null)
                    hashCode = hashCode * 59 + this.DisplayId.GetHashCode();
                if (this.ProblemId != null)
                    hashCode = hashCode * 59 + this.ProblemId.GetHashCode();
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
