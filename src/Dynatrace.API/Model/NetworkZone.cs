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
    /// Configuration of a network zone.
    /// </summary>
    [DataContract]
        public partial class NetworkZone :  IEquatable<NetworkZone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkZone" /> class.
        /// </summary>
        /// <param name="alternativeZones">A list of alternative network zones..</param>
        /// <param name="description">A short description of the network zone.</param>
        public NetworkZone(List<string> alternativeZones = default(List<string>), string description = default(string))
        {
            this.AlternativeZones = alternativeZones;
            this.Description = description;
        }
        
        /// <summary>
        /// A list of alternative network zones.
        /// </summary>
        /// <value>A list of alternative network zones.</value>
        [DataMember(Name="alternativeZones", EmitDefaultValue=false)]
        public List<string> AlternativeZones { get; set; }

        /// <summary>
        /// The number of OneAgents that are using ActiveGates in the network zone.
        /// </summary>
        /// <value>The number of OneAgents that are using ActiveGates in the network zone.</value>
        [DataMember(Name="numOfOneAgentsUsing", EmitDefaultValue=false)]
        public int? NumOfOneAgentsUsing { get; private set; }

        /// <summary>
        /// The number of OneAgents that are configured to use the network zone as primary.
        /// </summary>
        /// <value>The number of OneAgents that are configured to use the network zone as primary.</value>
        [DataMember(Name="numOfConfiguredOneAgents", EmitDefaultValue=false)]
        public int? NumOfConfiguredOneAgents { get; private set; }

        /// <summary>
        /// The number of OneAgents from other network zones that are using ActiveGates in the network zone.  This is a fraction of??**numOfOneAgentsUsing**. One possible reason for switching to another zone is that a firewall is preventing a OneAgent from connecting to any ActiveGate in the preferred network zone.
        /// </summary>
        /// <value>The number of OneAgents from other network zones that are using ActiveGates in the network zone.  This is a fraction of??**numOfOneAgentsUsing**. One possible reason for switching to another zone is that a firewall is preventing a OneAgent from connecting to any ActiveGate in the preferred network zone.</value>
        [DataMember(Name="numOfOneAgentsFromOtherZones", EmitDefaultValue=false)]
        public int? NumOfOneAgentsFromOtherZones { get; private set; }

        /// <summary>
        /// The number of ActiveGates in the network zone.
        /// </summary>
        /// <value>The number of ActiveGates in the network zone.</value>
        [DataMember(Name="numOfConfiguredActiveGates", EmitDefaultValue=false)]
        public int? NumOfConfiguredActiveGates { get; private set; }

        /// <summary>
        /// The ID of the network zone
        /// </summary>
        /// <value>The ID of the network zone</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// A short description of the network zone
        /// </summary>
        /// <value>A short description of the network zone</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkZone {\n");
            sb.Append("  AlternativeZones: ").Append(AlternativeZones).Append("\n");
            sb.Append("  NumOfOneAgentsUsing: ").Append(NumOfOneAgentsUsing).Append("\n");
            sb.Append("  NumOfConfiguredOneAgents: ").Append(NumOfConfiguredOneAgents).Append("\n");
            sb.Append("  NumOfOneAgentsFromOtherZones: ").Append(NumOfOneAgentsFromOtherZones).Append("\n");
            sb.Append("  NumOfConfiguredActiveGates: ").Append(NumOfConfiguredActiveGates).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as NetworkZone);
        }

        /// <summary>
        /// Returns true if NetworkZone instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlternativeZones == input.AlternativeZones ||
                    this.AlternativeZones != null &&
                    input.AlternativeZones != null &&
                    this.AlternativeZones.SequenceEqual(input.AlternativeZones)
                ) && 
                (
                    this.NumOfOneAgentsUsing == input.NumOfOneAgentsUsing ||
                    (this.NumOfOneAgentsUsing != null &&
                    this.NumOfOneAgentsUsing.Equals(input.NumOfOneAgentsUsing))
                ) && 
                (
                    this.NumOfConfiguredOneAgents == input.NumOfConfiguredOneAgents ||
                    (this.NumOfConfiguredOneAgents != null &&
                    this.NumOfConfiguredOneAgents.Equals(input.NumOfConfiguredOneAgents))
                ) && 
                (
                    this.NumOfOneAgentsFromOtherZones == input.NumOfOneAgentsFromOtherZones ||
                    (this.NumOfOneAgentsFromOtherZones != null &&
                    this.NumOfOneAgentsFromOtherZones.Equals(input.NumOfOneAgentsFromOtherZones))
                ) && 
                (
                    this.NumOfConfiguredActiveGates == input.NumOfConfiguredActiveGates ||
                    (this.NumOfConfiguredActiveGates != null &&
                    this.NumOfConfiguredActiveGates.Equals(input.NumOfConfiguredActiveGates))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AlternativeZones != null)
                    hashCode = hashCode * 59 + this.AlternativeZones.GetHashCode();
                if (this.NumOfOneAgentsUsing != null)
                    hashCode = hashCode * 59 + this.NumOfOneAgentsUsing.GetHashCode();
                if (this.NumOfConfiguredOneAgents != null)
                    hashCode = hashCode * 59 + this.NumOfConfiguredOneAgents.GetHashCode();
                if (this.NumOfOneAgentsFromOtherZones != null)
                    hashCode = hashCode * 59 + this.NumOfOneAgentsFromOtherZones.GetHashCode();
                if (this.NumOfConfiguredActiveGates != null)
                    hashCode = hashCode * 59 + this.NumOfConfiguredActiveGates.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
