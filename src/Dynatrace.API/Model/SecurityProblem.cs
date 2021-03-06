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
    /// Parameters of a security problem
    /// </summary>
    [DataContract]
        public partial class SecurityProblem :  IEquatable<SecurityProblem>, IValidatableObject
    {
        /// <summary>
        /// The status of the security problem.
        /// </summary>
        /// <value>The status of the security problem.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum OPEN for value: OPEN
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN = 1,
            /// <summary>
            /// Enum RESOLVED for value: RESOLVED
            /// </summary>
            [EnumMember(Value = "RESOLVED")]
            RESOLVED = 2        }
        /// <summary>
        /// The status of the security problem.
        /// </summary>
        /// <value>The status of the security problem.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The type of the vulnerability.
        /// </summary>
        /// <value>The type of the vulnerability.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum VulnerabilityTypeEnum
        {
            /// <summary>
            /// Enum RUNTIME for value: RUNTIME
            /// </summary>
            [EnumMember(Value = "RUNTIME")]
            RUNTIME = 1,
            /// <summary>
            /// Enum THIRDPARTY for value: THIRD_PARTY
            /// </summary>
            [EnumMember(Value = "THIRD_PARTY")]
            THIRDPARTY = 2        }
        /// <summary>
        /// The type of the vulnerability.
        /// </summary>
        /// <value>The type of the vulnerability.</value>
        [DataMember(Name="vulnerabilityType", EmitDefaultValue=false)]
        public VulnerabilityTypeEnum? VulnerabilityType { get; set; }
        /// <summary>
        /// The technology of the security problem.
        /// </summary>
        /// <value>The technology of the security problem.</value>
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
        /// The technology of the security problem.
        /// </summary>
        /// <value>The technology of the security problem.</value>
        [DataMember(Name="technology", EmitDefaultValue=false)]
        public TechnologyEnum? Technology { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityProblem" /> class.
        /// </summary>
        /// <param name="riskAssessment">riskAssessment.</param>
        public SecurityProblem(RiskAssessment riskAssessment = default(RiskAssessment))
        {
            this.RiskAssessment = riskAssessment;
        }
        
        /// <summary>
        /// The ID of the security problem.
        /// </summary>
        /// <value>The ID of the security problem.</value>
        [DataMember(Name="securityProblemId", EmitDefaultValue=false)]
        public string SecurityProblemId { get; private set; }

        /// <summary>
        /// The displayId of the security problem.
        /// </summary>
        /// <value>The displayId of the security problem.</value>
        [DataMember(Name="displayId", EmitDefaultValue=false)]
        public string DisplayId { get; private set; }


        /// <summary>
        /// Indicates if a security problem is muted.
        /// </summary>
        /// <value>Indicates if a security problem is muted.</value>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool? Muted { get; private set; }

        /// <summary>
        /// The external vulnerability ID of the security problem.
        /// </summary>
        /// <value>The external vulnerability ID of the security problem.</value>
        [DataMember(Name="externalVulnerabilityId", EmitDefaultValue=false)]
        public string ExternalVulnerabilityId { get; private set; }


        /// <summary>
        /// The title of the security problem.
        /// </summary>
        /// <value>The title of the security problem.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }

        /// <summary>
        /// The package name of the security problem.
        /// </summary>
        /// <value>The package name of the security problem.</value>
        [DataMember(Name="packageName", EmitDefaultValue=false)]
        public string PackageName { get; private set; }

        /// <summary>
        /// The URL to the security problem details page.
        /// </summary>
        /// <value>The URL to the security problem details page.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }


        /// <summary>
        /// The timestamp of the first occurrence of the security problem.
        /// </summary>
        /// <value>The timestamp of the first occurrence of the security problem.</value>
        [DataMember(Name="firstSeenTimestamp", EmitDefaultValue=false)]
        public long? FirstSeenTimestamp { get; private set; }

        /// <summary>
        /// The timestamp of the most recent security problem change.
        /// </summary>
        /// <value>The timestamp of the most recent security problem change.</value>
        [DataMember(Name="lastUpdatedTimestamp", EmitDefaultValue=false)]
        public long? LastUpdatedTimestamp { get; private set; }

        /// <summary>
        /// Gets or Sets RiskAssessment
        /// </summary>
        [DataMember(Name="riskAssessment", EmitDefaultValue=false)]
        public RiskAssessment RiskAssessment { get; set; }

        /// <summary>
        /// Management zones to which the affected entities belong.
        /// </summary>
        /// <value>Management zones to which the affected entities belong.</value>
        [DataMember(Name="managementZones", EmitDefaultValue=false)]
        public List<ManagementZone> ManagementZones { get; private set; }

        /// <summary>
        /// CVE IDs of the security problem.
        /// </summary>
        /// <value>CVE IDs of the security problem.</value>
        [DataMember(Name="cveIds", EmitDefaultValue=false)]
        public List<string> CveIds { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityProblem {\n");
            sb.Append("  SecurityProblemId: ").Append(SecurityProblemId).Append("\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  ExternalVulnerabilityId: ").Append(ExternalVulnerabilityId).Append("\n");
            sb.Append("  VulnerabilityType: ").Append(VulnerabilityType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PackageName: ").Append(PackageName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Technology: ").Append(Technology).Append("\n");
            sb.Append("  FirstSeenTimestamp: ").Append(FirstSeenTimestamp).Append("\n");
            sb.Append("  LastUpdatedTimestamp: ").Append(LastUpdatedTimestamp).Append("\n");
            sb.Append("  RiskAssessment: ").Append(RiskAssessment).Append("\n");
            sb.Append("  ManagementZones: ").Append(ManagementZones).Append("\n");
            sb.Append("  CveIds: ").Append(CveIds).Append("\n");
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
            return this.Equals(input as SecurityProblem);
        }

        /// <summary>
        /// Returns true if SecurityProblem instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityProblem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityProblem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityProblemId == input.SecurityProblemId ||
                    (this.SecurityProblemId != null &&
                    this.SecurityProblemId.Equals(input.SecurityProblemId))
                ) && 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Muted == input.Muted ||
                    (this.Muted != null &&
                    this.Muted.Equals(input.Muted))
                ) && 
                (
                    this.ExternalVulnerabilityId == input.ExternalVulnerabilityId ||
                    (this.ExternalVulnerabilityId != null &&
                    this.ExternalVulnerabilityId.Equals(input.ExternalVulnerabilityId))
                ) && 
                (
                    this.VulnerabilityType == input.VulnerabilityType ||
                    (this.VulnerabilityType != null &&
                    this.VulnerabilityType.Equals(input.VulnerabilityType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.PackageName == input.PackageName ||
                    (this.PackageName != null &&
                    this.PackageName.Equals(input.PackageName))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Technology == input.Technology ||
                    (this.Technology != null &&
                    this.Technology.Equals(input.Technology))
                ) && 
                (
                    this.FirstSeenTimestamp == input.FirstSeenTimestamp ||
                    (this.FirstSeenTimestamp != null &&
                    this.FirstSeenTimestamp.Equals(input.FirstSeenTimestamp))
                ) && 
                (
                    this.LastUpdatedTimestamp == input.LastUpdatedTimestamp ||
                    (this.LastUpdatedTimestamp != null &&
                    this.LastUpdatedTimestamp.Equals(input.LastUpdatedTimestamp))
                ) && 
                (
                    this.RiskAssessment == input.RiskAssessment ||
                    (this.RiskAssessment != null &&
                    this.RiskAssessment.Equals(input.RiskAssessment))
                ) && 
                (
                    this.ManagementZones == input.ManagementZones ||
                    this.ManagementZones != null &&
                    input.ManagementZones != null &&
                    this.ManagementZones.SequenceEqual(input.ManagementZones)
                ) && 
                (
                    this.CveIds == input.CveIds ||
                    this.CveIds != null &&
                    input.CveIds != null &&
                    this.CveIds.SequenceEqual(input.CveIds)
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
                if (this.SecurityProblemId != null)
                    hashCode = hashCode * 59 + this.SecurityProblemId.GetHashCode();
                if (this.DisplayId != null)
                    hashCode = hashCode * 59 + this.DisplayId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Muted != null)
                    hashCode = hashCode * 59 + this.Muted.GetHashCode();
                if (this.ExternalVulnerabilityId != null)
                    hashCode = hashCode * 59 + this.ExternalVulnerabilityId.GetHashCode();
                if (this.VulnerabilityType != null)
                    hashCode = hashCode * 59 + this.VulnerabilityType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.PackageName != null)
                    hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Technology != null)
                    hashCode = hashCode * 59 + this.Technology.GetHashCode();
                if (this.FirstSeenTimestamp != null)
                    hashCode = hashCode * 59 + this.FirstSeenTimestamp.GetHashCode();
                if (this.LastUpdatedTimestamp != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimestamp.GetHashCode();
                if (this.RiskAssessment != null)
                    hashCode = hashCode * 59 + this.RiskAssessment.GetHashCode();
                if (this.ManagementZones != null)
                    hashCode = hashCode * 59 + this.ManagementZones.GetHashCode();
                if (this.CveIds != null)
                    hashCode = hashCode * 59 + this.CveIds.GetHashCode();
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
