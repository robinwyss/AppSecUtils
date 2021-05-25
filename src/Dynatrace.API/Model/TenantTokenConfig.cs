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
    /// Configuration of a [tenant token](https://dt-url.net/b403ss9).
    /// </summary>
    [DataContract]
        public partial class TenantTokenConfig :  IEquatable<TenantTokenConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantTokenConfig" /> class.
        /// </summary>
        /// <param name="old">old.</param>
        /// <param name="active">active.</param>
        public TenantTokenConfig(TenantToken old = default(TenantToken), TenantToken active = default(TenantToken))
        {
            this.Old = old;
            this.Active = active;
        }
        
        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name="old", EmitDefaultValue=false)]
        public TenantToken Old { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public TenantToken Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantTokenConfig {\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as TenantTokenConfig);
        }

        /// <summary>
        /// Returns true if TenantTokenConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantTokenConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantTokenConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Old == input.Old ||
                    (this.Old != null &&
                    this.Old.Equals(input.Old))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
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
                if (this.Old != null)
                    hashCode = hashCode * 59 + this.Old.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
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