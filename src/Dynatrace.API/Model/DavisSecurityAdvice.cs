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
    /// Security advice from the Davis security advisor.
    /// </summary>
    [DataContract]
        public partial class DavisSecurityAdvice :  IEquatable<DavisSecurityAdvice>, IValidatableObject
    {
        /// <summary>
        /// The technology of the vulnerable component.
        /// </summary>
        /// <value>The technology of the vulnerable component.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TechnologyEnum
        {
            /// <summary>
            /// Enum DOTNET for value: DOTNET
            /// </summary>
            [EnumMember(Value = "DOTNET")]
            DOTNET = 1,
            /// <summary>
            /// Enum JAVA for value: JAVA
            /// </summary>
            [EnumMember(Value = "JAVA")]
            JAVA = 2,
            /// <summary>
            /// Enum KUBERNETES for value: KUBERNETES
            /// </summary>
            [EnumMember(Value = "KUBERNETES")]
            KUBERNETES = 3,
            /// <summary>
            /// Enum NODEJS for value: NODE_JS
            /// </summary>
            [EnumMember(Value = "NODE_JS")]
            NODEJS = 4,
            /// <summary>
            /// Enum PHP for value: PHP
            /// </summary>
            [EnumMember(Value = "PHP")]
            PHP = 5        }
        /// <summary>
        /// The technology of the vulnerable component.
        /// </summary>
        /// <value>The technology of the vulnerable component.</value>
        [DataMember(Name="technology", EmitDefaultValue=false)]
        public TechnologyEnum? Technology { get; set; }
        /// <summary>
        /// The type of the advice.
        /// </summary>
        /// <value>The type of the advice.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AdviceTypeEnum
        {
            /// <summary>
            /// Enum UPGRADE for value: UPGRADE
            /// </summary>
            [EnumMember(Value = "UPGRADE")]
            UPGRADE = 1        }
        /// <summary>
        /// The type of the advice.
        /// </summary>
        /// <value>The type of the advice.</value>
        [DataMember(Name="adviceType", EmitDefaultValue=false)]
        public AdviceTypeEnum? AdviceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DavisSecurityAdvice" /> class.
        /// </summary>
        public DavisSecurityAdvice()
        {
        }
        
        /// <summary>
        /// The name of the advice.
        /// </summary>
        /// <value>The name of the advice.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The vulnerable component to which advice applies.
        /// </summary>
        /// <value>The vulnerable component to which advice applies.</value>
        [DataMember(Name="vulnerableComponent", EmitDefaultValue=false)]
        public string VulnerableComponent { get; private set; }



        /// <summary>
        /// IDs of &#x60;critical&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.
        /// </summary>
        /// <value>IDs of &#x60;critical&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.</value>
        [DataMember(Name="critical", EmitDefaultValue=false)]
        public List<string> Critical { get; private set; }

        /// <summary>
        /// IDs of &#x60;high&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.
        /// </summary>
        /// <value>IDs of &#x60;high&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public List<string> High { get; private set; }

        /// <summary>
        /// IDs of &#x60;medium&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.
        /// </summary>
        /// <value>IDs of &#x60;medium&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.</value>
        [DataMember(Name="medium", EmitDefaultValue=false)]
        public List<string> Medium { get; private set; }

        /// <summary>
        /// IDs of &#x60;low&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.
        /// </summary>
        /// <value>IDs of &#x60;low&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public List<string> Low { get; private set; }

        /// <summary>
        /// IDs of &#x60;none&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.
        /// </summary>
        /// <value>IDs of &#x60;none&#x60; level [security problems](https://dt-url.net/p103u1h) caused by vulnerable component.</value>
        [DataMember(Name="none", EmitDefaultValue=false)]
        public List<string> None { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DavisSecurityAdvice {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VulnerableComponent: ").Append(VulnerableComponent).Append("\n");
            sb.Append("  Technology: ").Append(Technology).Append("\n");
            sb.Append("  AdviceType: ").Append(AdviceType).Append("\n");
            sb.Append("  Critical: ").Append(Critical).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  None: ").Append(None).Append("\n");
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
            return this.Equals(input as DavisSecurityAdvice);
        }

        /// <summary>
        /// Returns true if DavisSecurityAdvice instances are equal
        /// </summary>
        /// <param name="input">Instance of DavisSecurityAdvice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DavisSecurityAdvice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.VulnerableComponent == input.VulnerableComponent ||
                    (this.VulnerableComponent != null &&
                    this.VulnerableComponent.Equals(input.VulnerableComponent))
                ) && 
                (
                    this.Technology == input.Technology ||
                    (this.Technology != null &&
                    this.Technology.Equals(input.Technology))
                ) && 
                (
                    this.AdviceType == input.AdviceType ||
                    (this.AdviceType != null &&
                    this.AdviceType.Equals(input.AdviceType))
                ) && 
                (
                    this.Critical == input.Critical ||
                    this.Critical != null &&
                    input.Critical != null &&
                    this.Critical.SequenceEqual(input.Critical)
                ) && 
                (
                    this.High == input.High ||
                    this.High != null &&
                    input.High != null &&
                    this.High.SequenceEqual(input.High)
                ) && 
                (
                    this.Medium == input.Medium ||
                    this.Medium != null &&
                    input.Medium != null &&
                    this.Medium.SequenceEqual(input.Medium)
                ) && 
                (
                    this.Low == input.Low ||
                    this.Low != null &&
                    input.Low != null &&
                    this.Low.SequenceEqual(input.Low)
                ) && 
                (
                    this.None == input.None ||
                    this.None != null &&
                    input.None != null &&
                    this.None.SequenceEqual(input.None)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.VulnerableComponent != null)
                    hashCode = hashCode * 59 + this.VulnerableComponent.GetHashCode();
                if (this.Technology != null)
                    hashCode = hashCode * 59 + this.Technology.GetHashCode();
                if (this.AdviceType != null)
                    hashCode = hashCode * 59 + this.AdviceType.GetHashCode();
                if (this.Critical != null)
                    hashCode = hashCode * 59 + this.Critical.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Medium != null)
                    hashCode = hashCode * 59 + this.Medium.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.None != null)
                    hashCode = hashCode * 59 + this.None.GetHashCode();
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
