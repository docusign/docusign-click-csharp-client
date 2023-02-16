/* 
 * DocuSign Click API
 *
 * Elastic signing (also known as DocuSign Click)  lets you capture consent to standard agreement terms with a single click: terms and conditions, terms of service, terms of use, privacy policies, and more. The Click API lets you include this customizable elastic template solution in your DocuSign integrations.
 *
 * OpenAPI spec version: v1
 * Contact: devcenter@docusign.com
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
using SwaggerDateConverter = DocuSign.Click.Client.SwaggerDateConverter;

namespace DocuSign.Click.Model
{
    /// <summary>
    /// ClickwrapVersionsDeleteResponse
    /// </summary>
    [DataContract]
    public partial class ClickwrapVersionsDeleteResponse :  IEquatable<ClickwrapVersionsDeleteResponse>, IValidatableObject
    {
        public ClickwrapVersionsDeleteResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickwrapVersionsDeleteResponse" /> class.
        /// </summary>
        /// <param name="ClickwrapId">The ID of the clickwrap..</param>
        /// <param name="ClickwrapName">The name of the clickwrap..</param>
        /// <param name="Versions">An array of delete responses..</param>
        public ClickwrapVersionsDeleteResponse(string ClickwrapId = default(string), string ClickwrapName = default(string), List<ClickwrapVersionDeleteResponse> Versions = default(List<ClickwrapVersionDeleteResponse>))
        {
            this.ClickwrapId = ClickwrapId;
            this.ClickwrapName = ClickwrapName;
            this.Versions = Versions;
        }
        
        /// <summary>
        /// The ID of the clickwrap.
        /// </summary>
        /// <value>The ID of the clickwrap.</value>
        [DataMember(Name="clickwrapId", EmitDefaultValue=false)]
        public string ClickwrapId { get; set; }
        /// <summary>
        /// The name of the clickwrap.
        /// </summary>
        /// <value>The name of the clickwrap.</value>
        [DataMember(Name="clickwrapName", EmitDefaultValue=false)]
        public string ClickwrapName { get; set; }
        /// <summary>
        /// An array of delete responses.
        /// </summary>
        /// <value>An array of delete responses.</value>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public List<ClickwrapVersionDeleteResponse> Versions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickwrapVersionsDeleteResponse {\n");
            sb.Append("  ClickwrapId: ").Append(ClickwrapId).Append("\n");
            sb.Append("  ClickwrapName: ").Append(ClickwrapName).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ClickwrapVersionsDeleteResponse);
        }

        /// <summary>
        /// Returns true if ClickwrapVersionsDeleteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickwrapVersionsDeleteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickwrapVersionsDeleteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClickwrapId == other.ClickwrapId ||
                    this.ClickwrapId != null &&
                    this.ClickwrapId.Equals(other.ClickwrapId)
                ) && 
                (
                    this.ClickwrapName == other.ClickwrapName ||
                    this.ClickwrapName != null &&
                    this.ClickwrapName.Equals(other.ClickwrapName)
                ) && 
                (
                    this.Versions == other.Versions ||
                    this.Versions != null &&
                    this.Versions.SequenceEqual(other.Versions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ClickwrapId != null)
                    hash = hash * 59 + this.ClickwrapId.GetHashCode();
                if (this.ClickwrapName != null)
                    hash = hash * 59 + this.ClickwrapName.GetHashCode();
                if (this.Versions != null)
                    hash = hash * 59 + this.Versions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
