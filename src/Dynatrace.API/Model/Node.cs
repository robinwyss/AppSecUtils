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
    /// Configuration of a synthetic node.    A *synthetic node* is an ActiveGate that is able to execute synthetic monitors.
    /// </summary>
    [DataContract]
        public partial class Node :  IEquatable<Node>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node" /> class.
        /// </summary>
        /// <param name="entityId">The ID of the synthetic node. (required).</param>
        /// <param name="hostname">The hostname of the synthetic node. (required).</param>
        /// <param name="ips">The IP of the synthetic node. (required).</param>
        /// <param name="version">The version of the synthetic node. (required).</param>
        /// <param name="browserMonitorsEnabled">The synthetic node is able to execute browser monitors (&#x60;true&#x60;) or not (&#x60;false&#x60;). (required).</param>
        /// <param name="activeGateVersion">The version of the Active Gate. (required).</param>
        /// <param name="oneAgentRoutingEnabled_">The Active Gate has the One Agent routing enabled (&#x27;true&#x27;) or not (&#x27;false&#x27;). (required).</param>
        /// <param name="operatingSystem">The Active Gate&#x27;s host operating system. (required).</param>
        /// <param name="autoUpdateEnabled">The Active Gate has the Auto update option enabled (&#x27;true&#x27;) or not (&#x27;false&#x27;) (required).</param>
        /// <param name="status">The status of the synthetic node. (required).</param>
        /// <param name="playerVersion">The version of the synthetic player. (required).</param>
        /// <param name="healthCheckStatus">The health check status of the synthetic node. (required).</param>
        /// <param name="browserType">The browser type. (required).</param>
        /// <param name="browserVersion">The browser version. (required).</param>
        public Node(string entityId = default(string), string hostname = default(string), List<string> ips = default(List<string>), string version = default(string), bool? browserMonitorsEnabled = default(bool?), string activeGateVersion = default(string), bool? oneAgentRoutingEnabled_ = default(bool?), string operatingSystem = default(string), bool? autoUpdateEnabled = default(bool?), string status = default(string), string playerVersion = default(string), string healthCheckStatus = default(string), string browserType = default(string), string browserVersion = default(string))
        {
            // to ensure "entityId" is required (not null)
            if (entityId == null)
            {
                throw new InvalidDataException("entityId is a required property for Node and cannot be null");
            }
            else
            {
                this.EntityId = entityId;
            }
            // to ensure "hostname" is required (not null)
            if (hostname == null)
            {
                throw new InvalidDataException("hostname is a required property for Node and cannot be null");
            }
            else
            {
                this.Hostname = hostname;
            }
            // to ensure "ips" is required (not null)
            if (ips == null)
            {
                throw new InvalidDataException("ips is a required property for Node and cannot be null");
            }
            else
            {
                this.Ips = ips;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for Node and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            // to ensure "browserMonitorsEnabled" is required (not null)
            if (browserMonitorsEnabled == null)
            {
                throw new InvalidDataException("browserMonitorsEnabled is a required property for Node and cannot be null");
            }
            else
            {
                this.BrowserMonitorsEnabled = browserMonitorsEnabled;
            }
            // to ensure "activeGateVersion" is required (not null)
            if (activeGateVersion == null)
            {
                throw new InvalidDataException("activeGateVersion is a required property for Node and cannot be null");
            }
            else
            {
                this.ActiveGateVersion = activeGateVersion;
            }
            // to ensure "oneAgentRoutingEnabled_" is required (not null)
            if (oneAgentRoutingEnabled_ == null)
            {
                throw new InvalidDataException("oneAgentRoutingEnabled_ is a required property for Node and cannot be null");
            }
            else
            {
                this.OneAgentRoutingEnabled_ = oneAgentRoutingEnabled_;
            }
            // to ensure "operatingSystem" is required (not null)
            if (operatingSystem == null)
            {
                throw new InvalidDataException("operatingSystem is a required property for Node and cannot be null");
            }
            else
            {
                this.OperatingSystem = operatingSystem;
            }
            // to ensure "autoUpdateEnabled" is required (not null)
            if (autoUpdateEnabled == null)
            {
                throw new InvalidDataException("autoUpdateEnabled is a required property for Node and cannot be null");
            }
            else
            {
                this.AutoUpdateEnabled = autoUpdateEnabled;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Node and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "playerVersion" is required (not null)
            if (playerVersion == null)
            {
                throw new InvalidDataException("playerVersion is a required property for Node and cannot be null");
            }
            else
            {
                this.PlayerVersion = playerVersion;
            }
            // to ensure "healthCheckStatus" is required (not null)
            if (healthCheckStatus == null)
            {
                throw new InvalidDataException("healthCheckStatus is a required property for Node and cannot be null");
            }
            else
            {
                this.HealthCheckStatus = healthCheckStatus;
            }
            // to ensure "browserType" is required (not null)
            if (browserType == null)
            {
                throw new InvalidDataException("browserType is a required property for Node and cannot be null");
            }
            else
            {
                this.BrowserType = browserType;
            }
            // to ensure "browserVersion" is required (not null)
            if (browserVersion == null)
            {
                throw new InvalidDataException("browserVersion is a required property for Node and cannot be null");
            }
            else
            {
                this.BrowserVersion = browserVersion;
            }
        }
        
        /// <summary>
        /// The ID of the synthetic node.
        /// </summary>
        /// <value>The ID of the synthetic node.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// The hostname of the synthetic node.
        /// </summary>
        /// <value>The hostname of the synthetic node.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// The IP of the synthetic node.
        /// </summary>
        /// <value>The IP of the synthetic node.</value>
        [DataMember(Name="ips", EmitDefaultValue=false)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// The version of the synthetic node.
        /// </summary>
        /// <value>The version of the synthetic node.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The synthetic node is able to execute browser monitors (&#x60;true&#x60;) or not (&#x60;false&#x60;).
        /// </summary>
        /// <value>The synthetic node is able to execute browser monitors (&#x60;true&#x60;) or not (&#x60;false&#x60;).</value>
        [DataMember(Name="browserMonitorsEnabled", EmitDefaultValue=false)]
        public bool? BrowserMonitorsEnabled { get; set; }

        /// <summary>
        /// The version of the Active Gate.
        /// </summary>
        /// <value>The version of the Active Gate.</value>
        [DataMember(Name="activeGateVersion", EmitDefaultValue=false)]
        public string ActiveGateVersion { get; set; }

        /// <summary>
        /// The Active Gate has the One Agent routing enabled (&#x27;true&#x27;) or not (&#x27;false&#x27;).
        /// </summary>
        /// <value>The Active Gate has the One Agent routing enabled (&#x27;true&#x27;) or not (&#x27;false&#x27;).</value>
        [DataMember(Name="oneAgentRoutingEnabled ", EmitDefaultValue=false)]
        public bool? OneAgentRoutingEnabled_ { get; set; }

        /// <summary>
        /// The Active Gate&#x27;s host operating system.
        /// </summary>
        /// <value>The Active Gate&#x27;s host operating system.</value>
        [DataMember(Name="operatingSystem", EmitDefaultValue=false)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// The Active Gate has the Auto update option enabled (&#x27;true&#x27;) or not (&#x27;false&#x27;)
        /// </summary>
        /// <value>The Active Gate has the Auto update option enabled (&#x27;true&#x27;) or not (&#x27;false&#x27;)</value>
        [DataMember(Name="autoUpdateEnabled", EmitDefaultValue=false)]
        public bool? AutoUpdateEnabled { get; set; }

        /// <summary>
        /// The status of the synthetic node.
        /// </summary>
        /// <value>The status of the synthetic node.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The version of the synthetic player.
        /// </summary>
        /// <value>The version of the synthetic player.</value>
        [DataMember(Name="playerVersion", EmitDefaultValue=false)]
        public string PlayerVersion { get; set; }

        /// <summary>
        /// The health check status of the synthetic node.
        /// </summary>
        /// <value>The health check status of the synthetic node.</value>
        [DataMember(Name="healthCheckStatus", EmitDefaultValue=false)]
        public string HealthCheckStatus { get; set; }

        /// <summary>
        /// The browser type.
        /// </summary>
        /// <value>The browser type.</value>
        [DataMember(Name="browserType", EmitDefaultValue=false)]
        public string BrowserType { get; set; }

        /// <summary>
        /// The browser version.
        /// </summary>
        /// <value>The browser version.</value>
        [DataMember(Name="browserVersion", EmitDefaultValue=false)]
        public string BrowserVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Node {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BrowserMonitorsEnabled: ").Append(BrowserMonitorsEnabled).Append("\n");
            sb.Append("  ActiveGateVersion: ").Append(ActiveGateVersion).Append("\n");
            sb.Append("  OneAgentRoutingEnabled_: ").Append(OneAgentRoutingEnabled_).Append("\n");
            sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
            sb.Append("  AutoUpdateEnabled: ").Append(AutoUpdateEnabled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PlayerVersion: ").Append(PlayerVersion).Append("\n");
            sb.Append("  HealthCheckStatus: ").Append(HealthCheckStatus).Append("\n");
            sb.Append("  BrowserType: ").Append(BrowserType).Append("\n");
            sb.Append("  BrowserVersion: ").Append(BrowserVersion).Append("\n");
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
            return this.Equals(input as Node);
        }

        /// <summary>
        /// Returns true if Node instances are equal
        /// </summary>
        /// <param name="input">Instance of Node to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Node input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    input.Ips != null &&
                    this.Ips.SequenceEqual(input.Ips)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.BrowserMonitorsEnabled == input.BrowserMonitorsEnabled ||
                    (this.BrowserMonitorsEnabled != null &&
                    this.BrowserMonitorsEnabled.Equals(input.BrowserMonitorsEnabled))
                ) && 
                (
                    this.ActiveGateVersion == input.ActiveGateVersion ||
                    (this.ActiveGateVersion != null &&
                    this.ActiveGateVersion.Equals(input.ActiveGateVersion))
                ) && 
                (
                    this.OneAgentRoutingEnabled_ == input.OneAgentRoutingEnabled_ ||
                    (this.OneAgentRoutingEnabled_ != null &&
                    this.OneAgentRoutingEnabled_.Equals(input.OneAgentRoutingEnabled_))
                ) && 
                (
                    this.OperatingSystem == input.OperatingSystem ||
                    (this.OperatingSystem != null &&
                    this.OperatingSystem.Equals(input.OperatingSystem))
                ) && 
                (
                    this.AutoUpdateEnabled == input.AutoUpdateEnabled ||
                    (this.AutoUpdateEnabled != null &&
                    this.AutoUpdateEnabled.Equals(input.AutoUpdateEnabled))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PlayerVersion == input.PlayerVersion ||
                    (this.PlayerVersion != null &&
                    this.PlayerVersion.Equals(input.PlayerVersion))
                ) && 
                (
                    this.HealthCheckStatus == input.HealthCheckStatus ||
                    (this.HealthCheckStatus != null &&
                    this.HealthCheckStatus.Equals(input.HealthCheckStatus))
                ) && 
                (
                    this.BrowserType == input.BrowserType ||
                    (this.BrowserType != null &&
                    this.BrowserType.Equals(input.BrowserType))
                ) && 
                (
                    this.BrowserVersion == input.BrowserVersion ||
                    (this.BrowserVersion != null &&
                    this.BrowserVersion.Equals(input.BrowserVersion))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BrowserMonitorsEnabled != null)
                    hashCode = hashCode * 59 + this.BrowserMonitorsEnabled.GetHashCode();
                if (this.ActiveGateVersion != null)
                    hashCode = hashCode * 59 + this.ActiveGateVersion.GetHashCode();
                if (this.OneAgentRoutingEnabled_ != null)
                    hashCode = hashCode * 59 + this.OneAgentRoutingEnabled_.GetHashCode();
                if (this.OperatingSystem != null)
                    hashCode = hashCode * 59 + this.OperatingSystem.GetHashCode();
                if (this.AutoUpdateEnabled != null)
                    hashCode = hashCode * 59 + this.AutoUpdateEnabled.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PlayerVersion != null)
                    hashCode = hashCode * 59 + this.PlayerVersion.GetHashCode();
                if (this.HealthCheckStatus != null)
                    hashCode = hashCode * 59 + this.HealthCheckStatus.GetHashCode();
                if (this.BrowserType != null)
                    hashCode = hashCode * 59 + this.BrowserType.GetHashCode();
                if (this.BrowserVersion != null)
                    hashCode = hashCode * 59 + this.BrowserVersion.GetHashCode();
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
