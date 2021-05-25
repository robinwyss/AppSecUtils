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
    /// Configuration of the ActiveGate update job.
    /// </summary>
    [DataContract]
        public partial class UpdateJob :  IEquatable<UpdateJob>, IValidatableObject
    {
        /// <summary>
        /// The status of the update job.
        /// </summary>
        /// <value>The status of the update job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum JobStateEnum
        {
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 1,
            /// <summary>
            /// Enum INPROGRESS for value: IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            INPROGRESS = 2,
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 3,
            /// <summary>
            /// Enum ROLLBACK for value: ROLLBACK
            /// </summary>
            [EnumMember(Value = "ROLLBACK")]
            ROLLBACK = 4,
            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            SCHEDULED = 5,
            /// <summary>
            /// Enum SKIPPED for value: SKIPPED
            /// </summary>
            [EnumMember(Value = "SKIPPED")]
            SKIPPED = 6,
            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            [EnumMember(Value = "SUCCEED")]
            SUCCEED = 7        }
        /// <summary>
        /// The status of the update job.
        /// </summary>
        /// <value>The status of the update job.</value>
        [DataMember(Name="jobState", EmitDefaultValue=false)]
        public JobStateEnum? JobState { get; set; }
        /// <summary>
        /// The method of updating the ActiveGate or its component.
        /// </summary>
        /// <value>The method of updating the ActiveGate or its component.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UpdateMethodEnum
        {
            /// <summary>
            /// Enum AUTOMATIC for value: AUTOMATIC
            /// </summary>
            [EnumMember(Value = "AUTOMATIC")]
            AUTOMATIC = 1,
            /// <summary>
            /// Enum MANUALINSTALLATION for value: MANUAL_INSTALLATION
            /// </summary>
            [EnumMember(Value = "MANUAL_INSTALLATION")]
            MANUALINSTALLATION = 2,
            /// <summary>
            /// Enum ONDEMAND for value: ON_DEMAND
            /// </summary>
            [EnumMember(Value = "ON_DEMAND")]
            ONDEMAND = 3        }
        /// <summary>
        /// The method of updating the ActiveGate or its component.
        /// </summary>
        /// <value>The method of updating the ActiveGate or its component.</value>
        [DataMember(Name="updateMethod", EmitDefaultValue=false)]
        public UpdateMethodEnum? UpdateMethod { get; set; }
        /// <summary>
        /// The component to be updated.
        /// </summary>
        /// <value>The component to be updated.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UpdateTypeEnum
        {
            /// <summary>
            /// Enum ACTIVEGATE for value: ACTIVE_GATE
            /// </summary>
            [EnumMember(Value = "ACTIVE_GATE")]
            ACTIVEGATE = 1,
            /// <summary>
            /// Enum REMOTEPLUGINAGENT for value: REMOTE_PLUGIN_AGENT
            /// </summary>
            [EnumMember(Value = "REMOTE_PLUGIN_AGENT")]
            REMOTEPLUGINAGENT = 2,
            /// <summary>
            /// Enum SYNTHETIC for value: SYNTHETIC
            /// </summary>
            [EnumMember(Value = "SYNTHETIC")]
            SYNTHETIC = 3,
            /// <summary>
            /// Enum ZREMOTE for value: Z_REMOTE
            /// </summary>
            [EnumMember(Value = "Z_REMOTE")]
            ZREMOTE = 4        }
        /// <summary>
        /// The component to be updated.
        /// </summary>
        /// <value>The component to be updated.</value>
        [DataMember(Name="updateType", EmitDefaultValue=false)]
        public UpdateTypeEnum? UpdateType { get; set; }
        /// <summary>
        /// The type of the ActiveGate.
        /// </summary>
        /// <value>The type of the ActiveGate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AgTypeEnum
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
        [DataMember(Name="agType", EmitDefaultValue=false)]
        public AgTypeEnum? AgType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJob" /> class.
        /// </summary>
        /// <param name="targetVersion">The target version of the update.   Specify the version in the &#x60;&lt;major&gt;.&lt;minor&gt;.&lt;revision&gt;.&lt;timestamp&gt;&#x60; format.   To update to the latest available version, use the &#x60;latest&#x60; value. (required).</param>
        public UpdateJob(string targetVersion = default(string))
        {
            // to ensure "targetVersion" is required (not null)
            if (targetVersion == null)
            {
                throw new InvalidDataException("targetVersion is a required property for UpdateJob and cannot be null");
            }
            else
            {
                this.TargetVersion = targetVersion;
            }
        }
        
        /// <summary>
        /// The ID of the update job.
        /// </summary>
        /// <value>The ID of the update job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; private set; }




        /// <summary>
        /// The job can (&#x60;true&#x60;) or can&#x27;t (&#x60;false&#x60;) be cancelled at the moment.
        /// </summary>
        /// <value>The job can (&#x60;true&#x60;) or can&#x27;t (&#x60;false&#x60;) be cancelled at the moment.</value>
        [DataMember(Name="cancelable", EmitDefaultValue=false)]
        public bool? Cancelable { get; private set; }

        /// <summary>
        /// The initial version of the ActiveGate.
        /// </summary>
        /// <value>The initial version of the ActiveGate.</value>
        [DataMember(Name="startVersion", EmitDefaultValue=false)]
        public string StartVersion { get; private set; }

        /// <summary>
        /// The target version of the update.   Specify the version in the &#x60;&lt;major&gt;.&lt;minor&gt;.&lt;revision&gt;.&lt;timestamp&gt;&#x60; format.   To update to the latest available version, use the &#x60;latest&#x60; value.
        /// </summary>
        /// <value>The target version of the update.   Specify the version in the &#x60;&lt;major&gt;.&lt;minor&gt;.&lt;revision&gt;.&lt;timestamp&gt;&#x60; format.   To update to the latest available version, use the &#x60;latest&#x60; value.</value>
        [DataMember(Name="targetVersion", EmitDefaultValue=false)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// The timestamp of the update job completion.    The &#x60;null&#x60; value means the job is still running.
        /// </summary>
        /// <value>The timestamp of the update job completion.    The &#x60;null&#x60; value means the job is still running.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; private set; }


        /// <summary>
        /// A list of environments (specified by IDs) the ActiveGate can connect to.
        /// </summary>
        /// <value>A list of environments (specified by IDs) the ActiveGate can connect to.</value>
        [DataMember(Name="environments", EmitDefaultValue=false)]
        public List<string> Environments { get; private set; }

        /// <summary>
        /// The information about update error.
        /// </summary>
        /// <value>The information about update error.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; private set; }

        /// <summary>
        /// The duration of the update, in milliseconds.
        /// </summary>
        /// <value>The duration of the update, in milliseconds.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateJob {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobState: ").Append(JobState).Append("\n");
            sb.Append("  UpdateMethod: ").Append(UpdateMethod).Append("\n");
            sb.Append("  UpdateType: ").Append(UpdateType).Append("\n");
            sb.Append("  Cancelable: ").Append(Cancelable).Append("\n");
            sb.Append("  StartVersion: ").Append(StartVersion).Append("\n");
            sb.Append("  TargetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  AgType: ").Append(AgType).Append("\n");
            sb.Append("  Environments: ").Append(Environments).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as UpdateJob);
        }

        /// <summary>
        /// Returns true if UpdateJob instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobState == input.JobState ||
                    (this.JobState != null &&
                    this.JobState.Equals(input.JobState))
                ) && 
                (
                    this.UpdateMethod == input.UpdateMethod ||
                    (this.UpdateMethod != null &&
                    this.UpdateMethod.Equals(input.UpdateMethod))
                ) && 
                (
                    this.UpdateType == input.UpdateType ||
                    (this.UpdateType != null &&
                    this.UpdateType.Equals(input.UpdateType))
                ) && 
                (
                    this.Cancelable == input.Cancelable ||
                    (this.Cancelable != null &&
                    this.Cancelable.Equals(input.Cancelable))
                ) && 
                (
                    this.StartVersion == input.StartVersion ||
                    (this.StartVersion != null &&
                    this.StartVersion.Equals(input.StartVersion))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.AgType == input.AgType ||
                    (this.AgType != null &&
                    this.AgType.Equals(input.AgType))
                ) && 
                (
                    this.Environments == input.Environments ||
                    this.Environments != null &&
                    input.Environments != null &&
                    this.Environments.SequenceEqual(input.Environments)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobState != null)
                    hashCode = hashCode * 59 + this.JobState.GetHashCode();
                if (this.UpdateMethod != null)
                    hashCode = hashCode * 59 + this.UpdateMethod.GetHashCode();
                if (this.UpdateType != null)
                    hashCode = hashCode * 59 + this.UpdateType.GetHashCode();
                if (this.Cancelable != null)
                    hashCode = hashCode * 59 + this.Cancelable.GetHashCode();
                if (this.StartVersion != null)
                    hashCode = hashCode * 59 + this.StartVersion.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.AgType != null)
                    hashCode = hashCode * 59 + this.AgType.GetHashCode();
                if (this.Environments != null)
                    hashCode = hashCode * 59 + this.Environments.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
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
