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
    /// Configuration of a private synthetic location.  Some fields are inherited from the base *SyntheticLocation* object.
    /// </summary>
    [DataContract]
        public partial class PrivateSyntheticLocation : SyntheticLocation,  IEquatable<PrivateSyntheticLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSyntheticLocation" /> class.
        /// </summary>
        /// <param name="nodes">A list of synthetic nodes belonging to the location.  You can retrieve the list of available nodes with the [GET all nodes](https://dt-url.net/miy3rpl) call. (required).</param>
        /// <param name="availabilityLocationOutage">The alerting of location outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;)..</param>
        /// <param name="availabilityNodeOutage">The alerting of node outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;).  If enabled, the outage of *any* node in the location triggers an alert..</param>
        /// <param name="locationNodeOutageDelayInMinutes">Alert if the location or node outage lasts longer than *X* minutes.  Only applicable when **availabilityLocationOutage** or **availabilityNodeOutage** is set to &#x60;true&#x60;..</param>
        /// <param name="availabilityNotificationsEnabled">The notifications of location and node outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;)..</param>
        public PrivateSyntheticLocation(List<string> nodes = default(List<string>), bool? availabilityLocationOutage = default(bool?), bool? availabilityNodeOutage = default(bool?), int? locationNodeOutageDelayInMinutes = default(int?), bool? availabilityNotificationsEnabled = default(bool?), string entityId = default(string), TypeEnum type = default(TypeEnum), string name = default(string), string countryCode = default(string), string regionCode = default(string), string city = default(string), double? latitude = default(double?), double? longitude = default(double?), StatusEnum? status = default(StatusEnum?), string geoLocationId = default(string)) : base(entityId, type, name, countryCode, regionCode, city, latitude, longitude, status, geoLocationId)
        {
            // to ensure "nodes" is required (not null)
            if (nodes == null)
            {
                throw new InvalidDataException("nodes is a required property for PrivateSyntheticLocation and cannot be null");
            }
            else
            {
                this.Nodes = nodes;
            }
            this.AvailabilityLocationOutage = availabilityLocationOutage;
            this.AvailabilityNodeOutage = availabilityNodeOutage;
            this.LocationNodeOutageDelayInMinutes = locationNodeOutageDelayInMinutes;
            this.AvailabilityNotificationsEnabled = availabilityNotificationsEnabled;
        }
        
        /// <summary>
        /// A list of synthetic nodes belonging to the location.  You can retrieve the list of available nodes with the [GET all nodes](https://dt-url.net/miy3rpl) call.
        /// </summary>
        /// <value>A list of synthetic nodes belonging to the location.  You can retrieve the list of available nodes with the [GET all nodes](https://dt-url.net/miy3rpl) call.</value>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// The alerting of location outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;).
        /// </summary>
        /// <value>The alerting of location outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;).</value>
        [DataMember(Name="availabilityLocationOutage", EmitDefaultValue=false)]
        public bool? AvailabilityLocationOutage { get; set; }

        /// <summary>
        /// The alerting of node outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;).  If enabled, the outage of *any* node in the location triggers an alert.
        /// </summary>
        /// <value>The alerting of node outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;).  If enabled, the outage of *any* node in the location triggers an alert.</value>
        [DataMember(Name="availabilityNodeOutage", EmitDefaultValue=false)]
        public bool? AvailabilityNodeOutage { get; set; }

        /// <summary>
        /// Alert if the location or node outage lasts longer than *X* minutes.  Only applicable when **availabilityLocationOutage** or **availabilityNodeOutage** is set to &#x60;true&#x60;.
        /// </summary>
        /// <value>Alert if the location or node outage lasts longer than *X* minutes.  Only applicable when **availabilityLocationOutage** or **availabilityNodeOutage** is set to &#x60;true&#x60;.</value>
        [DataMember(Name="locationNodeOutageDelayInMinutes", EmitDefaultValue=false)]
        public int? LocationNodeOutageDelayInMinutes { get; set; }

        /// <summary>
        /// The notifications of location and node outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;).
        /// </summary>
        /// <value>The notifications of location and node outage is enabled (&#x60;true&#x60;) or disabled (&#x60;false&#x60;).</value>
        [DataMember(Name="availabilityNotificationsEnabled", EmitDefaultValue=false)]
        public bool? AvailabilityNotificationsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateSyntheticLocation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  AvailabilityLocationOutage: ").Append(AvailabilityLocationOutage).Append("\n");
            sb.Append("  AvailabilityNodeOutage: ").Append(AvailabilityNodeOutage).Append("\n");
            sb.Append("  LocationNodeOutageDelayInMinutes: ").Append(LocationNodeOutageDelayInMinutes).Append("\n");
            sb.Append("  AvailabilityNotificationsEnabled: ").Append(AvailabilityNotificationsEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as PrivateSyntheticLocation);
        }

        /// <summary>
        /// Returns true if PrivateSyntheticLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivateSyntheticLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateSyntheticLocation input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && base.Equals(input) && 
                (
                    this.AvailabilityLocationOutage == input.AvailabilityLocationOutage ||
                    (this.AvailabilityLocationOutage != null &&
                    this.AvailabilityLocationOutage.Equals(input.AvailabilityLocationOutage))
                ) && base.Equals(input) && 
                (
                    this.AvailabilityNodeOutage == input.AvailabilityNodeOutage ||
                    (this.AvailabilityNodeOutage != null &&
                    this.AvailabilityNodeOutage.Equals(input.AvailabilityNodeOutage))
                ) && base.Equals(input) && 
                (
                    this.LocationNodeOutageDelayInMinutes == input.LocationNodeOutageDelayInMinutes ||
                    (this.LocationNodeOutageDelayInMinutes != null &&
                    this.LocationNodeOutageDelayInMinutes.Equals(input.LocationNodeOutageDelayInMinutes))
                ) && base.Equals(input) && 
                (
                    this.AvailabilityNotificationsEnabled == input.AvailabilityNotificationsEnabled ||
                    (this.AvailabilityNotificationsEnabled != null &&
                    this.AvailabilityNotificationsEnabled.Equals(input.AvailabilityNotificationsEnabled))
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
                int hashCode = base.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.AvailabilityLocationOutage != null)
                    hashCode = hashCode * 59 + this.AvailabilityLocationOutage.GetHashCode();
                if (this.AvailabilityNodeOutage != null)
                    hashCode = hashCode * 59 + this.AvailabilityNodeOutage.GetHashCode();
                if (this.LocationNodeOutageDelayInMinutes != null)
                    hashCode = hashCode * 59 + this.LocationNodeOutageDelayInMinutes.GetHashCode();
                if (this.AvailabilityNotificationsEnabled != null)
                    hashCode = hashCode * 59 + this.AvailabilityNotificationsEnabled.GetHashCode();
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
