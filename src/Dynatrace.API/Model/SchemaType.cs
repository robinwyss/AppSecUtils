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
    /// A list of definitions of types.    A type is a complex property that contains its own set of subproperties.
    /// </summary>
    [DataContract]
        public partial class SchemaType :  IEquatable<SchemaType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaType" /> class.
        /// </summary>
        /// <param name="summaryPattern">The pattern for the summary (for example, \&quot;Alert after *X* minutes.\&quot;) of the configuration in the UI..</param>
        /// <param name="version">The version of the type..</param>
        /// <param name="constraints">A list of constraints limiting the values to be accepted..</param>
        /// <param name="versionInfo">A short description of the version..</param>
        /// <param name="documentation">An extended description and/or links to documentation..</param>
        /// <param name="description">A short description of the property..</param>
        /// <param name="displayName">The display name of the property..</param>
        /// <param name="properties">Definition of properties that can be persisted..</param>
        public SchemaType(string summaryPattern = default(string), string version = default(string), List<ComplexConstraint> constraints = default(List<ComplexConstraint>), string versionInfo = default(string), string documentation = default(string), string description = default(string), string displayName = default(string), Dictionary<string, PropertyDefinition> properties = default(Dictionary<string, PropertyDefinition>))
        {
            this.SummaryPattern = summaryPattern;
            this.Version = version;
            this.Constraints = constraints;
            this.VersionInfo = versionInfo;
            this.Documentation = documentation;
            this.Description = description;
            this.DisplayName = displayName;
            this.Properties = properties;
        }
        
        /// <summary>
        /// The pattern for the summary (for example, \&quot;Alert after *X* minutes.\&quot;) of the configuration in the UI.
        /// </summary>
        /// <value>The pattern for the summary (for example, \&quot;Alert after *X* minutes.\&quot;) of the configuration in the UI.</value>
        [DataMember(Name="summaryPattern", EmitDefaultValue=false)]
        public string SummaryPattern { get; set; }

        /// <summary>
        /// The version of the type.
        /// </summary>
        /// <value>The version of the type.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// A list of constraints limiting the values to be accepted.
        /// </summary>
        /// <value>A list of constraints limiting the values to be accepted.</value>
        [DataMember(Name="constraints", EmitDefaultValue=false)]
        public List<ComplexConstraint> Constraints { get; set; }

        /// <summary>
        /// A short description of the version.
        /// </summary>
        /// <value>A short description of the version.</value>
        [DataMember(Name="versionInfo", EmitDefaultValue=false)]
        public string VersionInfo { get; set; }

        /// <summary>
        /// An extended description and/or links to documentation.
        /// </summary>
        /// <value>An extended description and/or links to documentation.</value>
        [DataMember(Name="documentation", EmitDefaultValue=false)]
        public string Documentation { get; set; }

        /// <summary>
        /// A short description of the property.
        /// </summary>
        /// <value>A short description of the property.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Definition of properties that can be persisted.
        /// </summary>
        /// <value>Definition of properties that can be persisted.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, PropertyDefinition> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaType {\n");
            sb.Append("  SummaryPattern: ").Append(SummaryPattern).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  VersionInfo: ").Append(VersionInfo).Append("\n");
            sb.Append("  Documentation: ").Append(Documentation).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as SchemaType);
        }

        /// <summary>
        /// Returns true if SchemaType instances are equal
        /// </summary>
        /// <param name="input">Instance of SchemaType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SummaryPattern == input.SummaryPattern ||
                    (this.SummaryPattern != null &&
                    this.SummaryPattern.Equals(input.SummaryPattern))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Constraints == input.Constraints ||
                    this.Constraints != null &&
                    input.Constraints != null &&
                    this.Constraints.SequenceEqual(input.Constraints)
                ) && 
                (
                    this.VersionInfo == input.VersionInfo ||
                    (this.VersionInfo != null &&
                    this.VersionInfo.Equals(input.VersionInfo))
                ) && 
                (
                    this.Documentation == input.Documentation ||
                    (this.Documentation != null &&
                    this.Documentation.Equals(input.Documentation))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.SummaryPattern != null)
                    hashCode = hashCode * 59 + this.SummaryPattern.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Constraints != null)
                    hashCode = hashCode * 59 + this.Constraints.GetHashCode();
                if (this.VersionInfo != null)
                    hashCode = hashCode * 59 + this.VersionInfo.GetHashCode();
                if (this.Documentation != null)
                    hashCode = hashCode * 59 + this.Documentation.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
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
