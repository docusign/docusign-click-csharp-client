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
    /// ClickwrapRequest
    /// </summary>
    [DataContract]
    public partial class ClickwrapRequest :  IEquatable<ClickwrapRequest>, IValidatableObject
    {
        public ClickwrapRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickwrapRequest" /> class.
        /// </summary>
        /// <param name="ClickwrapName">ClickwrapName.</param>
        /// <param name="DisplaySettings">DisplaySettings.</param>
        /// <param name="Documents">Documents.</param>
        /// <param name="FieldsToNull">FieldsToNull.</param>
        /// <param name="IsMajorversion">IsMajorversion.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RequireReacceptance">RequireReacceptance.</param>
        /// <param name="ScheduledDate">ScheduledDate.</param>
        /// <param name="ScheduledReacceptance">ScheduledReacceptance.</param>
        /// <param name="Status">Status.</param>
        /// <param name="TransferFromUserId">TransferFromUserId.</param>
        /// <param name="TransferToUserId">TransferToUserId.</param>
        public ClickwrapRequest(string ClickwrapName = default(string), DisplaySettings DisplaySettings = default(DisplaySettings), List<Document> Documents = default(List<Document>), string FieldsToNull = default(string), bool? IsMajorversion = default(bool?), string Name = default(string), bool? RequireReacceptance = default(bool?), Object ScheduledDate = default(Object), ClickwrapScheduledReacceptance ScheduledReacceptance = default(ClickwrapScheduledReacceptance), Object Status = default(Object), string TransferFromUserId = default(string), string TransferToUserId = default(string))
        {
            this.ClickwrapName = ClickwrapName;
            this.DisplaySettings = DisplaySettings;
            this.Documents = Documents;
            this.FieldsToNull = FieldsToNull;
            this.IsMajorversion = IsMajorversion;
            this.Name = Name;
            this.RequireReacceptance = RequireReacceptance;
            this.ScheduledDate = ScheduledDate;
            this.ScheduledReacceptance = ScheduledReacceptance;
            this.Status = Status;
            this.TransferFromUserId = TransferFromUserId;
            this.TransferToUserId = TransferToUserId;
        }
        
        /// <summary>
        /// Gets or Sets ClickwrapName
        /// </summary>
        [DataMember(Name="clickwrapName", EmitDefaultValue=false)]
        public string ClickwrapName { get; set; }
        /// <summary>
        /// Gets or Sets DisplaySettings
        /// </summary>
        [DataMember(Name="displaySettings", EmitDefaultValue=false)]
        public DisplaySettings DisplaySettings { get; set; }
        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<Document> Documents { get; set; }
        /// <summary>
        /// Gets or Sets FieldsToNull
        /// </summary>
        [DataMember(Name="fieldsToNull", EmitDefaultValue=false)]
        public string FieldsToNull { get; set; }
        /// <summary>
        /// Gets or Sets IsMajorversion
        /// </summary>
        [DataMember(Name="isMajorversion", EmitDefaultValue=false)]
        public bool? IsMajorversion { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets RequireReacceptance
        /// </summary>
        [DataMember(Name="requireReacceptance", EmitDefaultValue=false)]
        public bool? RequireReacceptance { get; set; }
        /// <summary>
        /// Gets or Sets ScheduledDate
        /// </summary>
        [DataMember(Name="scheduledDate", EmitDefaultValue=false)]
        public Object ScheduledDate { get; set; }
        /// <summary>
        /// Gets or Sets ScheduledReacceptance
        /// </summary>
        [DataMember(Name="scheduledReacceptance", EmitDefaultValue=false)]
        public ClickwrapScheduledReacceptance ScheduledReacceptance { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Object Status { get; set; }
        /// <summary>
        /// Gets or Sets TransferFromUserId
        /// </summary>
        [DataMember(Name="transferFromUserId", EmitDefaultValue=false)]
        public string TransferFromUserId { get; set; }
        /// <summary>
        /// Gets or Sets TransferToUserId
        /// </summary>
        [DataMember(Name="transferToUserId", EmitDefaultValue=false)]
        public string TransferToUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickwrapRequest {\n");
            sb.Append("  ClickwrapName: ").Append(ClickwrapName).Append("\n");
            sb.Append("  DisplaySettings: ").Append(DisplaySettings).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  FieldsToNull: ").Append(FieldsToNull).Append("\n");
            sb.Append("  IsMajorversion: ").Append(IsMajorversion).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequireReacceptance: ").Append(RequireReacceptance).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  ScheduledReacceptance: ").Append(ScheduledReacceptance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransferFromUserId: ").Append(TransferFromUserId).Append("\n");
            sb.Append("  TransferToUserId: ").Append(TransferToUserId).Append("\n");
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
            return this.Equals(obj as ClickwrapRequest);
        }

        /// <summary>
        /// Returns true if ClickwrapRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickwrapRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickwrapRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClickwrapName == other.ClickwrapName ||
                    this.ClickwrapName != null &&
                    this.ClickwrapName.Equals(other.ClickwrapName)
                ) && 
                (
                    this.DisplaySettings == other.DisplaySettings ||
                    this.DisplaySettings != null &&
                    this.DisplaySettings.Equals(other.DisplaySettings)
                ) && 
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) && 
                (
                    this.FieldsToNull == other.FieldsToNull ||
                    this.FieldsToNull != null &&
                    this.FieldsToNull.Equals(other.FieldsToNull)
                ) && 
                (
                    this.IsMajorversion == other.IsMajorversion ||
                    this.IsMajorversion != null &&
                    this.IsMajorversion.Equals(other.IsMajorversion)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RequireReacceptance == other.RequireReacceptance ||
                    this.RequireReacceptance != null &&
                    this.RequireReacceptance.Equals(other.RequireReacceptance)
                ) && 
                (
                    this.ScheduledDate == other.ScheduledDate ||
                    this.ScheduledDate != null &&
                    this.ScheduledDate.Equals(other.ScheduledDate)
                ) && 
                (
                    this.ScheduledReacceptance == other.ScheduledReacceptance ||
                    this.ScheduledReacceptance != null &&
                    this.ScheduledReacceptance.Equals(other.ScheduledReacceptance)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TransferFromUserId == other.TransferFromUserId ||
                    this.TransferFromUserId != null &&
                    this.TransferFromUserId.Equals(other.TransferFromUserId)
                ) && 
                (
                    this.TransferToUserId == other.TransferToUserId ||
                    this.TransferToUserId != null &&
                    this.TransferToUserId.Equals(other.TransferToUserId)
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
                if (this.ClickwrapName != null)
                    hash = hash * 59 + this.ClickwrapName.GetHashCode();
                if (this.DisplaySettings != null)
                    hash = hash * 59 + this.DisplaySettings.GetHashCode();
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                if (this.FieldsToNull != null)
                    hash = hash * 59 + this.FieldsToNull.GetHashCode();
                if (this.IsMajorversion != null)
                    hash = hash * 59 + this.IsMajorversion.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RequireReacceptance != null)
                    hash = hash * 59 + this.RequireReacceptance.GetHashCode();
                if (this.ScheduledDate != null)
                    hash = hash * 59 + this.ScheduledDate.GetHashCode();
                if (this.ScheduledReacceptance != null)
                    hash = hash * 59 + this.ScheduledReacceptance.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TransferFromUserId != null)
                    hash = hash * 59 + this.TransferFromUserId.GetHashCode();
                if (this.TransferToUserId != null)
                    hash = hash * 59 + this.TransferToUserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}