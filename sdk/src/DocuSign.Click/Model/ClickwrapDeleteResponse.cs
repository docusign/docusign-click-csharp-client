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
    /// The result of a clickwrap deletion request.
    /// </summary>
    [DataContract]
    public partial class ClickwrapDeleteResponse :  IEquatable<ClickwrapDeleteResponse>, IValidatableObject
    {
        public ClickwrapDeleteResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickwrapDeleteResponse" /> class.
        /// </summary>
        /// <param name="ClickwrapId">The ID of the clickwrap..</param>
        /// <param name="ClickwrapName">The name of the clickwrap..</param>
        /// <param name="DeletionMessage">A message describing the result of deletion request. One of:  - &#x60;alreadyDeleted&#x60;: Clickwrap is already deleted. - &#x60;deletionSuccess&#x60;: Successfully deleted the clickwrap. - &#x60;deletionFailure&#x60;: Failed to delete the clickwrap. - &#x60;cannotDelete&#x60;: Active clickwrap version cannot be deleted..</param>
        /// <param name="DeletionSuccess">**True** if the clickwrap was deleted successfully. **False** otherwise..</param>
        /// <param name="Status">Clickwrap status. Possible values:  - &#x60;active&#x60; - &#x60;inactive&#x60; - &#x60;deleted&#x60;.</param>
        public ClickwrapDeleteResponse(string ClickwrapId = default(string), string ClickwrapName = default(string), string DeletionMessage = default(string), bool? DeletionSuccess = default(bool?), string Status = default(string))
        {
            this.ClickwrapId = ClickwrapId;
            this.ClickwrapName = ClickwrapName;
            this.DeletionMessage = DeletionMessage;
            this.DeletionSuccess = DeletionSuccess;
            this.Status = Status;
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
        /// Clickwrap status. Possible values:  - &#x60;active&#x60; - &#x60;inactive&#x60; - &#x60;deleted&#x60;
        /// </summary>
        /// <value>Clickwrap status. Possible values:  - &#x60;active&#x60; - &#x60;inactive&#x60; - &#x60;deleted&#x60;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickwrapDeleteResponse {\n");
            sb.Append("  ClickwrapId: ").Append(ClickwrapId).Append("\n");
            sb.Append("  ClickwrapName: ").Append(ClickwrapName).Append("\n");
            sb.Append("  DeletionMessage: ").Append(DeletionMessage).Append("\n");
            sb.Append("  DeletionSuccess: ").Append(DeletionSuccess).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as ClickwrapDeleteResponse);
        }

        /// <summary>
        /// Returns true if ClickwrapDeleteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickwrapDeleteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickwrapDeleteResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.DeletionMessage != null)
                    hash = hash * 59 + this.DeletionMessage.GetHashCode();
                if (this.DeletionSuccess != null)
                    hash = hash * 59 + this.DeletionSuccess.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
