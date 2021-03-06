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
    /// An update of a settings object.
    /// </summary>
    [DataContract]
        public partial class SettingsObjectUpdate :  IEquatable<SettingsObjectUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsObjectUpdate" /> class.
        /// </summary>
        /// <param name="updateToken">The update token of the object. You can use it to detect simultaneous modifications by different users. It is generated upon retrieval (GET requests). If set on update (PUT request) or deletion, the update/deletion will be allowed only if there wasn&#x27;t any change between the retrieval and the update. If omitted on update/deletion, the operation overrides the current value or deletes it without any checks..</param>
        /// <param name="schemaVersion">The version of the schema on which the object is based..</param>
        /// <param name="value">value (required).</param>
        public SettingsObjectUpdate(string updateToken = default(string), string schemaVersion = default(string), SettingsValue value = default(SettingsValue))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for SettingsObjectUpdate and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            this.UpdateToken = updateToken;
            this.SchemaVersion = schemaVersion;
        }
        
        /// <summary>
        /// The update token of the object. You can use it to detect simultaneous modifications by different users. It is generated upon retrieval (GET requests). If set on update (PUT request) or deletion, the update/deletion will be allowed only if there wasn&#x27;t any change between the retrieval and the update. If omitted on update/deletion, the operation overrides the current value or deletes it without any checks.
        /// </summary>
        /// <value>The update token of the object. You can use it to detect simultaneous modifications by different users. It is generated upon retrieval (GET requests). If set on update (PUT request) or deletion, the update/deletion will be allowed only if there wasn&#x27;t any change between the retrieval and the update. If omitted on update/deletion, the operation overrides the current value or deletes it without any checks.</value>
        [DataMember(Name="updateToken", EmitDefaultValue=false)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// The version of the schema on which the object is based.
        /// </summary>
        /// <value>The version of the schema on which the object is based.</value>
        [DataMember(Name="schemaVersion", EmitDefaultValue=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public SettingsValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsObjectUpdate {\n");
            sb.Append("  UpdateToken: ").Append(UpdateToken).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SettingsObjectUpdate);
        }

        /// <summary>
        /// Returns true if SettingsObjectUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingsObjectUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsObjectUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdateToken == input.UpdateToken ||
                    (this.UpdateToken != null &&
                    this.UpdateToken.Equals(input.UpdateToken))
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    (this.SchemaVersion != null &&
                    this.SchemaVersion.Equals(input.SchemaVersion))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.UpdateToken != null)
                    hashCode = hashCode * 59 + this.UpdateToken.GetHashCode();
                if (this.SchemaVersion != null)
                    hashCode = hashCode * 59 + this.SchemaVersion.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
