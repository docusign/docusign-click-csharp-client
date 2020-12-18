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
    /// Document
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>, IValidatableObject
    {
        public Document()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="DocumentBase64">DocumentBase64.</param>
        /// <param name="DocumentHtml">DocumentHtml.</param>
        /// <param name="DocumentName">DocumentName.</param>
        /// <param name="FileExtension">FileExtension.</param>
        /// <param name="Order">Order.</param>
        public Document(string DocumentBase64 = default(string), string DocumentHtml = default(string), string DocumentName = default(string), string FileExtension = default(string), int? Order = default(int?))
        {
            this.DocumentBase64 = DocumentBase64;
            this.DocumentHtml = DocumentHtml;
            this.DocumentName = DocumentName;
            this.FileExtension = FileExtension;
            this.Order = Order;
        }
        
        /// <summary>
        /// Gets or Sets DocumentBase64
        /// </summary>
        [DataMember(Name="documentBase64", EmitDefaultValue=false)]
        public string DocumentBase64 { get; set; }
        /// <summary>
        /// Gets or Sets DocumentHtml
        /// </summary>
        [DataMember(Name="documentHtml", EmitDefaultValue=false)]
        public string DocumentHtml { get; set; }
        /// <summary>
        /// Gets or Sets DocumentName
        /// </summary>
        [DataMember(Name="documentName", EmitDefaultValue=false)]
        public string DocumentName { get; set; }
        /// <summary>
        /// Gets or Sets FileExtension
        /// </summary>
        [DataMember(Name="fileExtension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  DocumentBase64: ").Append(DocumentBase64).Append("\n");
            sb.Append("  DocumentHtml: ").Append(DocumentHtml).Append("\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="other">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentBase64 == other.DocumentBase64 ||
                    this.DocumentBase64 != null &&
                    this.DocumentBase64.Equals(other.DocumentBase64)
                ) && 
                (
                    this.DocumentHtml == other.DocumentHtml ||
                    this.DocumentHtml != null &&
                    this.DocumentHtml.Equals(other.DocumentHtml)
                ) && 
                (
                    this.DocumentName == other.DocumentName ||
                    this.DocumentName != null &&
                    this.DocumentName.Equals(other.DocumentName)
                ) && 
                (
                    this.FileExtension == other.FileExtension ||
                    this.FileExtension != null &&
                    this.FileExtension.Equals(other.FileExtension)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.DocumentBase64 != null)
                    hash = hash * 59 + this.DocumentBase64.GetHashCode();
                if (this.DocumentHtml != null)
                    hash = hash * 59 + this.DocumentHtml.GetHashCode();
                if (this.DocumentName != null)
                    hash = hash * 59 + this.DocumentName.GetHashCode();
                if (this.FileExtension != null)
                    hash = hash * 59 + this.FileExtension.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
