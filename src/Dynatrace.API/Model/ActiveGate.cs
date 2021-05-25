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
    /// Parameters of the ActiveGate.
    /// </summary>
    [DataContract]
        public partial class ActiveGate :  IEquatable<ActiveGate>, IValidatableObject
    {
        /// <summary>
        /// The OS type that the ActiveGate is running on.
        /// </summary>
        /// <value>The OS type that the ActiveGate is running on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OsTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: LINUX
            /// </summary>
            [EnumMember(Value = "LINUX")]
            LINUX = 1,
            /// <summary>
            /// Enum WINDOWS for value: WINDOWS
            /// </summary>
            [EnumMember(Value = "WINDOWS")]
            WINDOWS = 2        }
        /// <summary>
        /// The OS type that the ActiveGate is running on.
        /// </summary>
        /// <value>The OS type that the ActiveGate is running on.</value>
        [DataMember(Name="osType", EmitDefaultValue=false)]
        public OsTypeEnum? OsType { get; set; }
        /// <summary>
        /// The current status of auto-updates of the ActiveGate.
        /// </summary>
        /// <value>The current status of auto-updates of the ActiveGate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AutoUpdateStatusEnum
        {
            /// <summary>
            /// Enum INCOMPATIBLE for value: INCOMPATIBLE
            /// </summary>
            [EnumMember(Value = "INCOMPATIBLE")]
            INCOMPATIBLE = 1,
            /// <summary>
            /// Enum OUTDATED for value: OUTDATED
            /// </summary>
            [EnumMember(Value = "OUTDATED")]
            OUTDATED = 2,
            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            SCHEDULED = 3,
            /// <summary>
            /// Enum SUPPRESSED for value: SUPPRESSED
            /// </summary>
            [EnumMember(Value = "SUPPRESSED")]
            SUPPRESSED = 4,
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 5,
            /// <summary>
            /// Enum UP2DATE for value: UP2DATE
            /// </summary>
            [EnumMember(Value = "UP2DATE")]
            UP2DATE = 6,
            /// <summary>
            /// Enum UPDATEINPROGRESS for value: UPDATE_IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "UPDATE_IN_PROGRESS")]
            UPDATEINPROGRESS = 7,
            /// <summary>
            /// Enum UPDATEPENDING for value: UPDATE_PENDING
            /// </summary>
            [EnumMember(Value = "UPDATE_PENDING")]
            UPDATEPENDING = 8,
            /// <summary>
            /// Enum UPDATEPROBLEM for value: UPDATE_PROBLEM
            /// </summary>
            [EnumMember(Value = "UPDATE_PROBLEM")]
            UPDATEPROBLEM = 9        }
        /// <summary>
        /// The current status of auto-updates of the ActiveGate.
        /// </summary>
        /// <value>The current status of auto-updates of the ActiveGate.</value>
        [DataMember(Name="autoUpdateStatus", EmitDefaultValue=false)]
        public AutoUpdateStatusEnum? AutoUpdateStatus { get; set; }
        /// <summary>
        /// The type of the ActiveGate.
        /// </summary>
        /// <value>The type of the ActiveGate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum CLUSTER for value: CLUSTER
            /// </summary>
            [EnumMember(Value = "CLUSTER")]
            CLUSTER = 1,
            /// <summary>
            /// Enum ENVIRONMENT for value: ENVIRONMENT
            /// </summary>
            [EnumMember(Value = "ENVIRONMENT")]
            ENVIRONMENT = 2,
            /// <summary>
            /// Enum ENVIRONMENTMULTI for value: ENVIRONMENT_MULTI
            /// </summary>
            [EnumMember(Value = "ENVIRONMENT_MULTI")]
            ENVIRONMENTMULTI = 3        }
        /// <summary>
        /// The type of the ActiveGate.
        /// </summary>
        /// <value>The type of the ActiveGate.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveGate" /> class.
        /// </summary>
        /// <param name="autoUpdateSettings">autoUpdateSettings.</param>
        public ActiveGate(ActiveGateAutoUpdateConfig autoUpdateSettings = default(ActiveGateAutoUpdateConfig))
        {
            this.AutoUpdateSettings = autoUpdateSettings;
        }
        
        /// <summary>
        /// The ID of the ActiveGate.
        /// </summary>
        /// <value>The ID of the ActiveGate.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// A list of network addresses of the ActiveGate.
        /// </summary>
        /// <value>A list of network addresses of the ActiveGate.</value>
        [DataMember(Name="networkAddresses", EmitDefaultValue=false)]
        public List<string> NetworkAddresses { get; private set; }



        /// <summary>
        /// The timestamp since when the ActiveGate is offline.    The &#x60;null&#x60; value means the ActiveGate is online.
        /// </summary>
        /// <value>The timestamp since when the ActiveGate is offline.    The &#x60;null&#x60; value means the ActiveGate is online.</value>
        [DataMember(Name="offlineSince", EmitDefaultValue=false)]
        public long? OfflineSince { get; private set; }

        /// <summary>
        /// The current version of the ActiveGate in the &#x60;&lt;major&gt;.&lt;minor&gt;.&lt;revision&gt;.&lt;timestamp&gt;&#x60; format.
        /// </summary>
        /// <value>The current version of the ActiveGate in the &#x60;&lt;major&gt;.&lt;minor&gt;.&lt;revision&gt;.&lt;timestamp&gt;&#x60; format.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; private set; }


        /// <summary>
        /// The name of the host the ActiveGate is running on.
        /// </summary>
        /// <value>The name of the host the ActiveGate is running on.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; private set; }

        /// <summary>
        /// The ID of the main environment for a multi-environment ActiveGate.
        /// </summary>
        /// <value>The ID of the main environment for a multi-environment ActiveGate.</value>
        [DataMember(Name="mainEnvironment", EmitDefaultValue=false)]
        public string MainEnvironment { get; private set; }

        /// <summary>
        /// A list of environments (specified by IDs) the ActiveGate can connect to.
        /// </summary>
        /// <value>A list of environments (specified by IDs) the ActiveGate can connect to.</value>
        [DataMember(Name="environments", EmitDefaultValue=false)]
        public List<string> Environments { get; private set; }

        /// <summary>
        /// Gets or Sets AutoUpdateSettings
        /// </summary>
        [DataMember(Name="autoUpdateSettings", EmitDefaultValue=false)]
        public ActiveGateAutoUpdateConfig AutoUpdateSettings { get; set; }

        /// <summary>
        /// The network zone of the ActiveGate.
        /// </summary>
        /// <value>The network zone of the ActiveGate.</value>
        [DataMember(Name="networkZone", EmitDefaultValue=false)]
        public string NetworkZone { get; private set; }

        /// <summary>
        /// The group of the ActiveGate.
        /// </summary>
        /// <value>The group of the ActiveGate.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; private set; }

        /// <summary>
        /// A list of modules of the ActiveGate.
        /// </summary>
        /// <value>A list of modules of the ActiveGate.</value>
        [DataMember(Name="modules", EmitDefaultValue=false)]
        public List<ActiveGateModule> Modules { get; private set; }

        /// <summary>
        /// ActiveGate is deployed in container (&#x60;true&#x60;) or not (&#x60;false&#x60;).
        /// </summary>
        /// <value>ActiveGate is deployed in container (&#x60;true&#x60;) or not (&#x60;false&#x60;).</value>
        [DataMember(Name="containerized", EmitDefaultValue=false)]
        public bool? Containerized { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveGate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NetworkAddresses: ").Append(NetworkAddresses).Append("\n");
            sb.Append("  OsType: ").Append(OsType).Append("\n");
            sb.Append("  AutoUpdateStatus: ").Append(AutoUpdateStatus).Append("\n");
            sb.Append("  OfflineSince: ").Append(OfflineSince).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  MainEnvironment: ").Append(MainEnvironment).Append("\n");
            sb.Append("  Environments: ").Append(Environments).Append("\n");
            sb.Append("  AutoUpdateSettings: ").Append(AutoUpdateSettings).Append("\n");
            sb.Append("  NetworkZone: ").Append(NetworkZone).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  Containerized: ").Append(Containerized).Append("\n");
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
            return this.Equals(input as ActiveGate);
        }

        /// <summary>
        /// Returns true if ActiveGate instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveGate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveGate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NetworkAddresses == input.NetworkAddresses ||
                    this.NetworkAddresses != null &&
                    input.NetworkAddresses != null &&
                    this.NetworkAddresses.SequenceEqual(input.NetworkAddresses)
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.AutoUpdateStatus == input.AutoUpdateStatus ||
                    (this.AutoUpdateStatus != null &&
                    this.AutoUpdateStatus.Equals(input.AutoUpdateStatus))
                ) && 
                (
                    this.OfflineSince == input.OfflineSince ||
                    (this.OfflineSince != null &&
                    this.OfflineSince.Equals(input.OfflineSince))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.MainEnvironment == input.MainEnvironment ||
                    (this.MainEnvironment != null &&
                    this.MainEnvironment.Equals(input.MainEnvironment))
                ) && 
                (
                    this.Environments == input.Environments ||
                    this.Environments != null &&
                    input.Environments != null &&
                    this.Environments.SequenceEqual(input.Environments)
                ) && 
                (
                    this.AutoUpdateSettings == input.AutoUpdateSettings ||
                    (this.AutoUpdateSettings != null &&
                    this.AutoUpdateSettings.Equals(input.AutoUpdateSettings))
                ) && 
                (
                    this.NetworkZone == input.NetworkZone ||
                    (this.NetworkZone != null &&
                    this.NetworkZone.Equals(input.NetworkZone))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    input.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
                ) && 
                (
                    this.Containerized == input.Containerized ||
                    (this.Containerized != null &&
                    this.Containerized.Equals(input.Containerized))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NetworkAddresses != null)
                    hashCode = hashCode * 59 + this.NetworkAddresses.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.AutoUpdateStatus != null)
                    hashCode = hashCode * 59 + this.AutoUpdateStatus.GetHashCode();
                if (this.OfflineSince != null)
                    hashCode = hashCode * 59 + this.OfflineSince.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.MainEnvironment != null)
                    hashCode = hashCode * 59 + this.MainEnvironment.GetHashCode();
                if (this.Environments != null)
                    hashCode = hashCode * 59 + this.Environments.GetHashCode();
                if (this.AutoUpdateSettings != null)
                    hashCode = hashCode * 59 + this.AutoUpdateSettings.GetHashCode();
                if (this.NetworkZone != null)
                    hashCode = hashCode * 59 + this.NetworkZone.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Modules != null)
                    hashCode = hashCode * 59 + this.Modules.GetHashCode();
                if (this.Containerized != null)
                    hashCode = hashCode * 59 + this.Containerized.GetHashCode();
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
