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
    /// An allowed value for an enum property.
    /// </summary>
    [DataContract]
        public partial class EnumValue :  IEquatable<EnumValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumValue" /> class.
        /// </summary>
        /// <param name="enumInstance">The name of the value in an existing Java enum class..</param>
        /// <param name="description">A short description of the value..</param>
        /// <param name="icon">The icon of the value..</param>
        /// <param name="value">The allowed value of the enum..</param>
        /// <param name="displayName">The display name of the value..</param>
        public EnumValue(string enumInstance = default(string), string description = default(string), string icon = default(string), Object value = default(Object), string displayName = default(string))
        {
            this.EnumInstance = enumInstance;
            this.Description = description;
            this.Icon = icon;
            this.Value = value;
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// The name of the value in an existing Java enum class.
        /// </summary>
        /// <value>The name of the value in an existing Java enum class.</value>
        [DataMember(Name="enumInstance", EmitDefaultValue=false)]
        public string EnumInstance { get; set; }

        /// <summary>
        /// A short description of the value.
        /// </summary>
        /// <value>A short description of the value.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The icon of the value.
        /// </summary>
        /// <value>The icon of the value.</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// The allowed value of the enum.
        /// </summary>
        /// <value>The allowed value of the enum.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// The display name of the value.
        /// </summary>
        /// <value>The display name of the value.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumValue {\n");
            sb.Append("  EnumInstance: ").Append(EnumInstance).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as EnumValue);
        }

        /// <summary>
        /// Returns true if EnumValue instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnumInstance == input.EnumInstance ||
                    (this.EnumInstance != null &&
                    this.EnumInstance.Equals(input.EnumInstance))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.EnumInstance != null)
                    hashCode = hashCode * 59 + this.EnumInstance.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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