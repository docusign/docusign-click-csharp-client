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
    /// Data used to start a bulk agreements export.
    /// </summary>
    [DataContract]
    public partial class BulkClickwrapRequest :  IEquatable<BulkClickwrapRequest>, IValidatableObject
    {
        public BulkClickwrapRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkClickwrapRequest" /> class.
        /// </summary>
        /// <param name="FromDate">The earliest date to return agreements from..</param>
        /// <param name="Status">User agreement status. One of:  - &#x60;agreed&#x60; - &#x60;declined&#x60;.</param>
        /// <param name="ToDate">The latest date to return agreements from..</param>
        public BulkClickwrapRequest(Object FromDate = default(Object), string Status = default(string), Object ToDate = default(Object))
        {
            this.FromDate = FromDate;
            this.Status = Status;
            this.ToDate = ToDate;
        }
        
        /// <summary>
        /// The earliest date to return agreements from.
        /// </summary>
        /// <value>The earliest date to return agreements from.</value>
        [DataMember(Name="fromDate", EmitDefaultValue=false)]
        public Object FromDate { get; set; }
        /// <summary>
        /// User agreement status. One of:  - &#x60;agreed&#x60; - &#x60;declined&#x60;
        /// </summary>
        /// <value>User agreement status. One of:  - &#x60;agreed&#x60; - &#x60;declined&#x60;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// The latest date to return agreements from.
        /// </summary>
        /// <value>The latest date to return agreements from.</value>
        [DataMember(Name="toDate", EmitDefaultValue=false)]
        public Object ToDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkClickwrapRequest {\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
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
            return this.Equals(obj as BulkClickwrapRequest);
        }

        /// <summary>
        /// Returns true if BulkClickwrapRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkClickwrapRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkClickwrapRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FromDate == other.FromDate ||
                    this.FromDate != null &&
                    this.FromDate.Equals(other.FromDate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ToDate == other.ToDate ||
                    this.ToDate != null &&
                    this.ToDate.Equals(other.ToDate)
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
                if (this.FromDate != null)
                    hash = hash * 59 + this.FromDate.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ToDate != null)
                    hash = hash * 59 + this.ToDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}