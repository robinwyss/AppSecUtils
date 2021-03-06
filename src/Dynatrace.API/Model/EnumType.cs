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
    /// Definition of an enum property.
    /// </summary>
    [DataContract]
        public partial class EnumType :  IEquatable<EnumType>, IValidatableObject
    {
        /// <summary>
        /// The type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Enum for value: enum
            /// </summary>
            [EnumMember(Value = "enum")]
            Enum = 1        }
        /// <summary>
        /// The type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumType" /> class.
        /// </summary>
        /// <param name="enumClass">An existing Java enum class that holds the allowed values of the enum..</param>
        /// <param name="items">A list of allowed values of the enum..</param>
        /// <param name="type">The type of the property..</param>
        /// <param name="documentation">An extended description and/or links to documentation..</param>
        /// <param name="displayName">The display name of the property..</param>
        /// <param name="description">A short description of the property..</param>
        public EnumType(string enumClass = default(string), List<EnumValue> items = default(List<EnumValue>), TypeEnum? type = default(TypeEnum?), string documentation = default(string), string displayName = default(string), string description = default(string))
        {
            this.EnumClass = enumClass;
            this.Items = items;
            this.Type = type;
            this.Documentation = documentation;
            this.DisplayName = displayName;
            this.Description = description;
        }
        
        /// <summary>
        /// An existing Java enum class that holds the allowed values of the enum.
        /// </summary>
        /// <value>An existing Java enum class that holds the allowed values of the enum.</value>
        [DataMember(Name="enumClass", EmitDefaultValue=false)]
        public string EnumClass { get; set; }

        /// <summary>
        /// A list of allowed values of the enum.
        /// </summary>
        /// <value>A list of allowed values of the enum.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<EnumValue> Items { get; set; }


        /// <summary>
        /// An extended description and/or links to documentation.
        /// </summary>
        /// <value>An extended description and/or links to documentation.</value>
        [DataMember(Name="documentation", EmitDefaultValue=false)]
        public string Documentation { get; set; }

        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A short description of the property.
        /// </summary>
        /// <value>A short description of the property.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumType {\n");
            sb.Append("  EnumClass: ").Append(EnumClass).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Documentation: ").Append(Documentation).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as EnumType);
        }

        /// <summary>
        /// Returns true if EnumType instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnumClass == input.EnumClass ||
                    (this.EnumClass != null &&
                    this.EnumClass.Equals(input.EnumClass))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Documentation == input.Documentation ||
                    (this.Documentation != null &&
                    this.Documentation.Equals(input.Documentation))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.EnumClass != null)
                    hashCode = hashCode * 59 + this.EnumClass.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Documentation != null)
                    hashCode = hashCode * 59 + this.Documentation.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
