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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Click.Model
{
    /// <summary>
    /// ClickwrapVersionResponse
    /// </summary>
    [DataContract]
    public partial class ClickwrapVersionResponse :  IEquatable<ClickwrapVersionResponse>, IValidatableObject
    {
        public ClickwrapVersionResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickwrapVersionResponse" /> class.
        /// </summary>
        /// <param name="AccountId">The external account number (int) or account ID GUID..</param>
        /// <param name="ClickwrapId">The ID of the clickwrap..</param>
        /// <param name="ClickwrapName">The name of the clickwrap..</param>
        /// <param name="ClickwrapVersionId">The unique version ID, a GUID, of this clickwrap version..</param>
        /// <param name="CreatedTime">The time that the clickwrap was created..</param>
        /// <param name="DataFields">The list of all the data fields available for the clickwrap (custom fields and standard fields)..</param>
        /// <param name="DisplaySettings">Display settings for a clickwrap..</param>
        /// <param name="Documents">An array of documents..</param>
        /// <param name="LastModified">The time that the clickwrap was last modified..</param>
        /// <param name="LastModifiedBy">The user ID of the last user who modified this clickwrap..</param>
        /// <param name="OwnerUserId">The user ID of the owner of this clickwrap..</param>
        /// <param name="RequireReacceptance">When **true,** requires signers who have previously agreed to this clickwrap to sign again. The version number is incremented..</param>
        /// <param name="ScheduledDate">The time and date when this clickwrap is activated..</param>
        /// <param name="ScheduledReacceptance">Specifies the interval between reacceptances in days, weeks, months, or years..</param>
        /// <param name="Status">Clickwrap status. Possible values:  - &#x60;active&#x60; - &#x60;inactive&#x60; - &#x60;deleted&#x60;.</param>
        /// <param name="VersionId">The ID of the version..</param>
        /// <param name="VersionNumber">Version of the clickwrap..</param>
        public ClickwrapVersionResponse(string AccountId = default(string), string ClickwrapId = default(string), string ClickwrapName = default(string), string ClickwrapVersionId = default(string), Object CreatedTime = default(Object), List<DataField> DataFields = default(List<DataField>), DisplaySettings DisplaySettings = default(DisplaySettings), List<Document> Documents = default(List<Document>), Object LastModified = default(Object), string LastModifiedBy = default(string), string OwnerUserId = default(string), bool? RequireReacceptance = default(bool?), Object ScheduledDate = default(Object), ClickwrapScheduledReacceptance ScheduledReacceptance = default(ClickwrapScheduledReacceptance), string Status = default(string), string VersionId = default(string), string VersionNumber = default(string))
        {
            this.AccountId = AccountId;
            this.ClickwrapId = ClickwrapId;
            this.ClickwrapName = ClickwrapName;
            this.ClickwrapVersionId = ClickwrapVersionId;
            this.CreatedTime = CreatedTime;
            this.DataFields = DataFields;
            this.DisplaySettings = DisplaySettings;
            this.Documents = Documents;
            this.LastModified = LastModified;
            this.LastModifiedBy = LastModifiedBy;
            this.OwnerUserId = OwnerUserId;
            this.RequireReacceptance = RequireReacceptance;
            this.ScheduledDate = ScheduledDate;
            this.ScheduledReacceptance = ScheduledReacceptance;
            this.Status = Status;
            this.VersionId = VersionId;
            this.VersionNumber = VersionNumber;
        }
        
        /// <summary>
        /// The external account number (int) or account ID GUID.
        /// </summary>
        /// <value>The external account number (int) or account ID GUID.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
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
        /// The unique version ID, a GUID, of this clickwrap version.
        /// </summary>
        /// <value>The unique version ID, a GUID, of this clickwrap version.</value>
        [DataMember(Name="clickwrapVersionId", EmitDefaultValue=false)]
        public string ClickwrapVersionId { get; set; }
        /// <summary>
        /// The time that the clickwrap was created.
        /// </summary>
        /// <value>The time that the clickwrap was created.</value>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public Object CreatedTime { get; set; }
        /// <summary>
        /// The list of all the data fields available for the clickwrap (custom fields and standard fields).
        /// </summary>
        /// <value>The list of all the data fields available for the clickwrap (custom fields and standard fields).</value>
        [DataMember(Name="dataFields", EmitDefaultValue=false)]
        public List<DataField> DataFields { get; set; }
        /// <summary>
        /// Display settings for a clickwrap.
        /// </summary>
        /// <value>Display settings for a clickwrap.</value>
        [DataMember(Name="displaySettings", EmitDefaultValue=false)]
        public DisplaySettings DisplaySettings { get; set; }
        /// <summary>
        /// An array of documents.
        /// </summary>
        /// <value>An array of documents.</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<Document> Documents { get; set; }
        /// <summary>
        /// The time that the clickwrap was last modified.
        /// </summary>
        /// <value>The time that the clickwrap was last modified.</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public Object LastModified { get; set; }
        /// <summary>
        /// The user ID of the last user who modified this clickwrap.
        /// </summary>
        /// <value>The user ID of the last user who modified this clickwrap.</value>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// The user ID of the owner of this clickwrap.
        /// </summary>
        /// <value>The user ID of the owner of this clickwrap.</value>
        [DataMember(Name="ownerUserId", EmitDefaultValue=false)]
        public string OwnerUserId { get; set; }
        /// <summary>
        /// When **true,** requires signers who have previously agreed to this clickwrap to sign again. The version number is incremented.
        /// </summary>
        /// <value>When **true,** requires signers who have previously agreed to this clickwrap to sign again. The version number is incremented.</value>
        [DataMember(Name="requireReacceptance", EmitDefaultValue=false)]
        public bool? RequireReacceptance { get; set; }
        /// <summary>
        /// The time and date when this clickwrap is activated.
        /// </summary>
        /// <value>The time and date when this clickwrap is activated.</value>
        [DataMember(Name="scheduledDate", EmitDefaultValue=false)]
        public Object ScheduledDate { get; set; }
        /// <summary>
        /// Specifies the interval between reacceptances in days, weeks, months, or years.
        /// </summary>
        /// <value>Specifies the interval between reacceptances in days, weeks, months, or years.</value>
        [DataMember(Name="scheduledReacceptance", EmitDefaultValue=false)]
        public ClickwrapScheduledReacceptance ScheduledReacceptance { get; set; }
        /// <summary>
        /// Clickwrap status. Possible values:  - &#x60;active&#x60; - &#x60;inactive&#x60; - &#x60;deleted&#x60;
        /// </summary>
        /// <value>Clickwrap status. Possible values:  - &#x60;active&#x60; - &#x60;inactive&#x60; - &#x60;deleted&#x60;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// The ID of the version.
        /// </summary>
        /// <value>The ID of the version.</value>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public string VersionId { get; set; }
        /// <summary>
        /// Version of the clickwrap.
        /// </summary>
        /// <value>Version of the clickwrap.</value>
        [DataMember(Name="versionNumber", EmitDefaultValue=false)]
        public string VersionNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickwrapVersionResponse {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ClickwrapId: ").Append(ClickwrapId).Append("\n");
            sb.Append("  ClickwrapName: ").Append(ClickwrapName).Append("\n");
            sb.Append("  ClickwrapVersionId: ").Append(ClickwrapVersionId).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  DataFields: ").Append(DataFields).Append("\n");
            sb.Append("  DisplaySettings: ").Append(DisplaySettings).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  OwnerUserId: ").Append(OwnerUserId).Append("\n");
            sb.Append("  RequireReacceptance: ").Append(RequireReacceptance).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  ScheduledReacceptance: ").Append(ScheduledReacceptance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
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
            return this.Equals(obj as ClickwrapVersionResponse);
        }

        /// <summary>
        /// Returns true if ClickwrapVersionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickwrapVersionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickwrapVersionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
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
                    this.ClickwrapVersionId == other.ClickwrapVersionId ||
                    this.ClickwrapVersionId != null &&
                    this.ClickwrapVersionId.Equals(other.ClickwrapVersionId)
                ) && 
                (
                    this.CreatedTime == other.CreatedTime ||
                    this.CreatedTime != null &&
                    this.CreatedTime.Equals(other.CreatedTime)
                ) && 
                (
                    this.DataFields == other.DataFields ||
                    this.DataFields != null &&
                    this.DataFields.SequenceEqual(other.DataFields)
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
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.LastModifiedBy == other.LastModifiedBy ||
                    this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(other.LastModifiedBy)
                ) && 
                (
                    this.OwnerUserId == other.OwnerUserId ||
                    this.OwnerUserId != null &&
                    this.OwnerUserId.Equals(other.OwnerUserId)
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
                    this.VersionId == other.VersionId ||
                    this.VersionId != null &&
                    this.VersionId.Equals(other.VersionId)
                ) && 
                (
                    this.VersionNumber == other.VersionNumber ||
                    this.VersionNumber != null &&
                    this.VersionNumber.Equals(other.VersionNumber)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.ClickwrapId != null)
                    hash = hash * 59 + this.ClickwrapId.GetHashCode();
                if (this.ClickwrapName != null)
                    hash = hash * 59 + this.ClickwrapName.GetHashCode();
                if (this.ClickwrapVersionId != null)
                    hash = hash * 59 + this.ClickwrapVersionId.GetHashCode();
                if (this.CreatedTime != null)
                    hash = hash * 59 + this.CreatedTime.GetHashCode();
                if (this.DataFields != null)
                    hash = hash * 59 + this.DataFields.GetHashCode();
                if (this.DisplaySettings != null)
                    hash = hash * 59 + this.DisplaySettings.GetHashCode();
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hash = hash * 59 + this.LastModifiedBy.GetHashCode();
                if (this.OwnerUserId != null)
                    hash = hash * 59 + this.OwnerUserId.GetHashCode();
                if (this.RequireReacceptance != null)
                    hash = hash * 59 + this.RequireReacceptance.GetHashCode();
                if (this.ScheduledDate != null)
                    hash = hash * 59 + this.ScheduledDate.GetHashCode();
                if (this.ScheduledReacceptance != null)
                    hash = hash * 59 + this.ScheduledReacceptance.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.VersionId != null)
                    hash = hash * 59 + this.VersionId.GetHashCode();
                if (this.VersionNumber != null)
                    hash = hash * 59 + this.VersionNumber.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
