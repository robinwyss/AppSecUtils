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
    /// An item of a collection property.
    /// </summary>
    [DataContract]
        public partial class Item :  IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="referencedType">The type referenced by the item&#x27;s value..</param>
        /// <param name="documentation">An extended description and/or links to documentation..</param>
        /// <param name="subType">The subtype of the item&#x27;s value..</param>
        /// <param name="type">The type of the item&#x27;s value..</param>
        /// <param name="displayName">The display name of the item..</param>
        /// <param name="description">A short description of the item..</param>
        /// <param name="constraints">A list of constraints limiting the values to be accepted..</param>
        public Item(string referencedType = default(string), string documentation = default(string), string subType = default(string), Object type = default(Object), string displayName = default(string), string description = default(string), List<Constraint> constraints = default(List<Constraint>))
        {
            this.ReferencedType = referencedType;
            this.Documentation = documentation;
            this.SubType = subType;
            this.Type = type;
            this.DisplayName = displayName;
            this.Description = description;
            this.Constraints = constraints;
        }
        
        /// <summary>
        /// The type referenced by the item&#x27;s value.
        /// </summary>
        /// <value>The type referenced by the item&#x27;s value.</value>
        [DataMember(Name="referencedType", EmitDefaultValue=false)]
        public string ReferencedType { get; set; }

        /// <summary>
        /// An extended description and/or links to documentation.
        /// </summary>
        /// <value>An extended description and/or links to documentation.</value>
        [DataMember(Name="documentation", EmitDefaultValue=false)]
        public string Documentation { get; set; }

        /// <summary>
        /// The subtype of the item&#x27;s value.
        /// </summary>
        /// <value>The subtype of the item&#x27;s value.</value>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public string SubType { get; set; }

        /// <summary>
        /// The type of the item&#x27;s value.
        /// </summary>
        /// <value>The type of the item&#x27;s value.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public Object Type { get; set; }

        /// <summary>
        /// The display name of the item.
        /// </summary>
        /// <value>The display name of the item.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A short description of the item.
        /// </summary>
        /// <value>A short description of the item.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of constraints limiting the values to be accepted.
        /// </summary>
        /// <value>A list of constraints limiting the values to be accepted.</value>
        [DataMember(Name="constraints", EmitDefaultValue=false)]
        public List<Constraint> Constraints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  ReferencedType: ").Append(ReferencedType).Append("\n");
            sb.Append("  Documentation: ").Append(Documentation).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReferencedType == input.ReferencedType ||
                    (this.ReferencedType != null &&
                    this.ReferencedType.Equals(input.ReferencedType))
                ) && 
                (
                    this.Documentation == input.Documentation ||
                    (this.Documentation != null &&
                    this.Documentation.Equals(input.Documentation))
                ) && 
                (
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                ) && 
                (
                    this.Constraints == input.Constraints ||
                    this.Constraints != null &&
                    input.Constraints != null &&
                    this.Constraints.SequenceEqual(input.Constraints)
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
                if (this.ReferencedType != null)
                    hashCode = hashCode * 59 + this.ReferencedType.GetHashCode();
                if (this.Documentation != null)
                    hashCode = hashCode * 59 + this.Documentation.GetHashCode();
                if (this.SubType != null)
                    hashCode = hashCode * 59 + this.SubType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Constraints != null)
                    hashCode = hashCode * 59 + this.Constraints.GetHashCode();
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
