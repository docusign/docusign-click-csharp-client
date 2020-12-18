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
    /// ClickwrapVersionSummaryResponse
    /// </summary>
    [DataContract]
    public partial class ClickwrapVersionSummaryResponse :  IEquatable<ClickwrapVersionSummaryResponse>, IValidatableObject
    {
        public ClickwrapVersionSummaryResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickwrapVersionSummaryResponse" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="ClickwrapId">ClickwrapId.</param>
        /// <param name="ClickwrapName">ClickwrapName.</param>
        /// <param name="ClickwrapVersionId">ClickwrapVersionId.</param>
        /// <param name="CreatedTime">CreatedTime.</param>
        /// <param name="LastModified">LastModified.</param>
        /// <param name="LastModifiedBy">LastModifiedBy.</param>
        /// <param name="OwnerUserId">OwnerUserId.</param>
        /// <param name="RequireReacceptance">RequireReacceptance.</param>
        /// <param name="ScheduledDate">ScheduledDate.</param>
        /// <param name="ScheduledReacceptance">ScheduledReacceptance.</param>
        /// <param name="Status">Status.</param>
        /// <param name="VersionId">VersionId.</param>
        /// <param name="VersionNumber">VersionNumber.</param>
        public ClickwrapVersionSummaryResponse(string AccountId = default(string), string ClickwrapId = default(string), string ClickwrapName = default(string), string ClickwrapVersionId = default(string), Object CreatedTime = default(Object), Object LastModified = default(Object), string LastModifiedBy = default(string), string OwnerUserId = default(string), bool? RequireReacceptance = default(bool?), Object ScheduledDate = default(Object), ClickwrapScheduledReacceptance ScheduledReacceptance = default(ClickwrapScheduledReacceptance), string Status = default(string), string VersionId = default(string), string VersionNumber = default(string))
        {
            this.AccountId = AccountId;
            this.ClickwrapId = ClickwrapId;
            this.ClickwrapName = ClickwrapName;
            this.ClickwrapVersionId = ClickwrapVersionId;
            this.CreatedTime = CreatedTime;
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
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// Gets or Sets ClickwrapId
        /// </summary>
        [DataMember(Name="clickwrapId", EmitDefaultValue=false)]
        public string ClickwrapId { get; set; }
        /// <summary>
        /// Gets or Sets ClickwrapName
        /// </summary>
        [DataMember(Name="clickwrapName", EmitDefaultValue=false)]
        public string ClickwrapName { get; set; }
        /// <summary>
        /// Gets or Sets ClickwrapVersionId
        /// </summary>
        [DataMember(Name="clickwrapVersionId", EmitDefaultValue=false)]
        public string ClickwrapVersionId { get; set; }
        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public Object CreatedTime { get; set; }
        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public Object LastModified { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// Gets or Sets OwnerUserId
        /// </summary>
        [DataMember(Name="ownerUserId", EmitDefaultValue=false)]
        public string OwnerUserId { get; set; }
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
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public string VersionId { get; set; }
        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name="versionNumber", EmitDefaultValue=false)]
        public string VersionNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickwrapVersionSummaryResponse {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ClickwrapId: ").Append(ClickwrapId).Append("\n");
            sb.Append("  ClickwrapName: ").Append(ClickwrapName).Append("\n");
            sb.Append("  ClickwrapVersionId: ").Append(ClickwrapVersionId).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
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
            return this.Equals(obj as ClickwrapVersionSummaryResponse);
        }

        /// <summary>
        /// Returns true if ClickwrapVersionSummaryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickwrapVersionSummaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickwrapVersionSummaryResponse other)
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
