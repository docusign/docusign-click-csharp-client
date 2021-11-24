/* 
 * DocuSign Click API
 *
 * DocuSign Click lets you capture consent to standard agreement terms with a single click: terms and conditions, terms of service, terms of use, privacy policies, and more. The Click API lets you include this customizable clickwrap solution in your DocuSign integrations.
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
    /// UserAgreementRequest
    /// </summary>
    [DataContract]
    public partial class UserAgreementRequest :  IEquatable<UserAgreementRequest>, IValidatableObject
    {
        public UserAgreementRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgreementRequest" /> class.
        /// </summary>
        /// <param name="ClientUserId">ClientUserId.</param>
        /// <param name="DocumentData">DocumentData.</param>
        /// <param name="Metadata">Metadata.</param>
        public UserAgreementRequest(string ClientUserId = default(string), DocumentData DocumentData = default(DocumentData), string Metadata = default(string))
        {
            this.ClientUserId = ClientUserId;
            this.DocumentData = DocumentData;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// Gets or Sets ClientUserId
        /// </summary>
        [DataMember(Name="clientUserId", EmitDefaultValue=false)]
        public string ClientUserId { get; set; }
        /// <summary>
        /// Gets or Sets DocumentData
        /// </summary>
        [DataMember(Name="documentData", EmitDefaultValue=false)]
        public DocumentData DocumentData { get; set; }
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAgreementRequest {\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  DocumentData: ").Append(DocumentData).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as UserAgreementRequest);
        }

        /// <summary>
        /// Returns true if UserAgreementRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAgreementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAgreementRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientUserId == other.ClientUserId ||
                    this.ClientUserId != null &&
                    this.ClientUserId.Equals(other.ClientUserId)
                ) && 
                (
                    this.DocumentData == other.DocumentData ||
                    this.DocumentData != null &&
                    this.DocumentData.Equals(other.DocumentData)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.ClientUserId != null)
                    hash = hash * 59 + this.ClientUserId.GetHashCode();
                if (this.DocumentData != null)
                    hash = hash * 59 + this.DocumentData.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
