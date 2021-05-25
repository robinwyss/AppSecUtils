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
    /// The comment to a problem.
    /// </summary>
    [DataContract]
        public partial class Comment :  IEquatable<Comment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="authorName">The user who wrote the comment..</param>
        /// <param name="createdAtTimestamp">The timestamp of comment creation, in UTC milliseconds. (required).</param>
        /// <param name="context">The context of the comment..</param>
        /// <param name="id">The ID of the comment..</param>
        /// <param name="content">The text of the comment..</param>
        public Comment(string authorName = default(string), long? createdAtTimestamp = default(long?), string context = default(string), string id = default(string), string content = default(string))
        {
            // to ensure "createdAtTimestamp" is required (not null)
            if (createdAtTimestamp == null)
            {
                throw new InvalidDataException("createdAtTimestamp is a required property for Comment and cannot be null");
            }
            else
            {
                this.CreatedAtTimestamp = createdAtTimestamp;
            }
            this.AuthorName = authorName;
            this.Context = context;
            this.Id = id;
            this.Content = content;
        }
        
        /// <summary>
        /// The user who wrote the comment.
        /// </summary>
        /// <value>The user who wrote the comment.</value>
        [DataMember(Name="authorName", EmitDefaultValue=false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// The timestamp of comment creation, in UTC milliseconds.
        /// </summary>
        /// <value>The timestamp of comment creation, in UTC milliseconds.</value>
        [DataMember(Name="createdAtTimestamp", EmitDefaultValue=false)]
        public long? CreatedAtTimestamp { get; set; }

        /// <summary>
        /// The context of the comment.
        /// </summary>
        /// <value>The context of the comment.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// The ID of the comment.
        /// </summary>
        /// <value>The ID of the comment.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        /// <value>The text of the comment.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comment {\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  CreatedAtTimestamp: ").Append(CreatedAtTimestamp).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as Comment);
        }

        /// <summary>
        /// Returns true if Comment instances are equal
        /// </summary>
        /// <param name="input">Instance of Comment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.CreatedAtTimestamp == input.CreatedAtTimestamp ||
                    (this.CreatedAtTimestamp != null &&
                    this.CreatedAtTimestamp.Equals(input.CreatedAtTimestamp))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.AuthorName != null)
                    hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.CreatedAtTimestamp != null)
                    hashCode = hashCode * 59 + this.CreatedAtTimestamp.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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