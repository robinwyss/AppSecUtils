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
    /// A list of synthetic nodes
    /// </summary>
    [DataContract]
        public partial class Nodes :  IEquatable<Nodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nodes" /> class.
        /// </summary>
        /// <param name="nodes">A list of synthetic nodes (required).</param>
        public Nodes(List<NodeCollectionElement> nodes = default(List<NodeCollectionElement>))
        {
            // to ensure "nodes" is required (not null)
            if (nodes == null)
            {
                throw new InvalidDataException("nodes is a required property for Nodes and cannot be null");
            }
            else
            {
                this._Nodes = nodes;
            }
        }
        
        /// <summary>
        /// A list of synthetic nodes
        /// </summary>
        /// <value>A list of synthetic nodes</value>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public List<NodeCollectionElement> _Nodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Nodes {\n");
            sb.Append("  _Nodes: ").Append(_Nodes).Append("\n");
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
            return this.Equals(input as Nodes);
        }

        /// <summary>
        /// Returns true if Nodes instances are equal
        /// </summary>
        /// <param name="input">Instance of Nodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Nodes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Nodes == input._Nodes ||
                    this._Nodes != null &&
                    input._Nodes != null &&
                    this._Nodes.SequenceEqual(input._Nodes)
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
                if (this._Nodes != null)
                    hashCode = hashCode * 59 + this._Nodes.GetHashCode();
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