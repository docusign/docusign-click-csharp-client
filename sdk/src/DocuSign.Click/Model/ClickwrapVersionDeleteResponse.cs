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
    /// ClickwrapVersionDeleteResponse
    /// </summary>
    [DataContract]
    public partial class ClickwrapVersionDeleteResponse :  IEquatable<ClickwrapVersionDeleteResponse>, IValidatableObject
    {
        public ClickwrapVersionDeleteResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickwrapVersionDeleteResponse" /> class.
        /// </summary>
        /// <param name="ClickwrapVersionId">The unique version ID, a GUID, of this clickwrap version..</param>
        /// <param name="CreatedTime">The time that the clickwrap was created..</param>
        /// <param name="DataFields">The list of all the data fields available for the clickwrap (custom fields and standard fields)..</param>
        /// <param name="DeletionMessage">A message describing the result of deletion request. One of:  - &#x60;alreadyDeleted&#x60;: Clickwrap is already deleted. - &#x60;deletionSuccess&#x60;: Successfully deleted the clickwrap. - &#x60;deletionFailure&#x60;: Failed to delete the clickwrap. - &#x60;cannotDelete&#x60;: Active clickwrap version cannot be deleted..</param>
        /// <param name="DeletionSuccess">**True** if the clickwrap was deleted successfully. **False** otherwise..</param>
        /// <param name="LastModified">The time that the clickwrap was last modified..</param>
        /// <param name="LastModifiedBy">The user ID of the last user who modified this clickwrap..</param>
        /// <param name="OwnerUserId">The user ID of the owner of this clickwrap..</param>
        /// <param name="RequireReacceptance">When **true,** requires signers who have previously agreed to this clickwrap to sign again. The version number is incremented..</param>
        /// <param name="ScheduledDate">The time and date when this clickwrap is activated..</param>
        /// <param name="ScheduledReacceptance">Specifies the interval between reacceptances in days, weeks, months, or years..</param>
        /// <param name="Status">Clickwrap status. Possible values:  - &#x60;active&#x60; - &#x60;inactive&#x60; - &#x60;deleted&#x60;.</param>
        /// <param name="VersionId">The ID of the version..</param>
        /// <param name="VersionNumber">Version of the clickwrap..</param>
        public ClickwrapVersionDeleteResponse(string ClickwrapVersionId = default(string), Object CreatedTime = default(Object), List<DataField> DataFields = default(List<DataField>), string DeletionMessage = default(string), bool? DeletionSuccess = default(bool?), Object LastModified = default(Object), string LastModifiedBy = default(string), string OwnerUserId = default(string), bool? RequireReacceptance = default(bool?), Object ScheduledDate = default(Object), ClickwrapScheduledReacceptance ScheduledReacceptance = default(ClickwrapScheduledReacceptance), string Status = default(string), string VersionId = default(string), string VersionNumber = default(string))
        {
            this.ClickwrapVersionId = ClickwrapVersionId;
            this.CreatedTime = CreatedTime;
            this.DataFields = DataFields;
            this.DeletionMessage = DeletionMessage;
            this.DeletionSuccess = DeletionSuccess;
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
        /// A message describing the result of deletion request. One of:  - &#x60;alreadyDeleted&#x60;: Clickwrap is already deleted. - &#x60;deletionSuccess&#x60;: Successfully deleted the clickwrap. - &#x60;deletionFailure&#x60;: Failed to delete the clickwrap. - &#x60;cannotDelete&#x60;: Active clickwrap version cannot be deleted.
        /// </summary>
        /// <value>A message describing the result of deletion request. One of:  - &#x60;alreadyDeleted&#x60;: Clickwrap is already deleted. - &#x60;deletionSuccess&#x60;: Successfully deleted the clickwrap. - &#x60;deletionFailure&#x60;: Failed to delete the clickwrap. - &#x60;cannotDelete&#x60;: Active clickwrap version cannot be deleted.</value>
        [DataMember(Name="deletionMessage", EmitDefaultValue=false)]
        public string DeletionMessage { get; set; }
        /// <summary>
        /// **True** if the clickwrap was deleted successfully. **False** otherwise.
        /// </summary>
        /// <value>**True** if the clickwrap was deleted successfully. **False** otherwise.</value>
        [DataMember(Name="deletionSuccess", EmitDefaultValue=false)]
        public bool? DeletionSuccess { get; set; }
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
            sb.Append("class ClickwrapVersionDeleteResponse {\n");
            sb.Append("  ClickwrapVersionId: ").Append(ClickwrapVersionId).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  DataFields: ").Append(DataFields).Append("\n");
            sb.Append("  DeletionMessage: ").Append(DeletionMessage).Append("\n");
            sb.Append("  DeletionSuccess: ").Append(DeletionSuccess).Append("\n");
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
            return this.Equals(obj as ClickwrapVersionDeleteResponse);
        }

        /// <summary>
        /// Returns true if ClickwrapVersionDeleteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickwrapVersionDeleteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickwrapVersionDeleteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.DeletionMessage == other.DeletionMessage ||
                    this.DeletionMessage != null &&
                    this.DeletionMessage.Equals(other.DeletionMessage)
                ) && 
                (
                    this.DeletionSuccess == other.DeletionSuccess ||
                    this.DeletionSuccess != null &&
                    this.DeletionSuccess.Equals(other.DeletionSuccess)
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
                if (this.ClickwrapVersionId != null)
                    hash = hash * 59 + this.ClickwrapVersionId.GetHashCode();
                if (this.CreatedTime != null)
                    hash = hash * 59 + this.CreatedTime.GetHashCode();
                if (this.DataFields != null)
                    hash = hash * 59 + this.DataFields.GetHashCode();
                if (this.DeletionMessage != null)
                    hash = hash * 59 + this.DeletionMessage.GetHashCode();
                if (this.DeletionSuccess != null)
                    hash = hash * 59 + this.DeletionSuccess.GetHashCode();
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
