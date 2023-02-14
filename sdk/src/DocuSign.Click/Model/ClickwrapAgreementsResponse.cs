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
    /// ClickwrapAgreementsResponse
    /// </summary>
    [DataContract]
    public partial class ClickwrapAgreementsResponse :  IEquatable<ClickwrapAgreementsResponse>, IValidatableObject
    {
        public ClickwrapAgreementsResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickwrapAgreementsResponse" /> class.
        /// </summary>
        /// <param name="BeginCreatedOn">User agreements from this datetime..</param>
        /// <param name="MinimumPagesRemaining">Number of pages remaining in the response..</param>
        /// <param name="Page">The number of the current page..</param>
        /// <param name="PageSize">The number of items per page..</param>
        /// <param name="UserAgreements">An array of user agreements..</param>
        public ClickwrapAgreementsResponse(Object BeginCreatedOn = default(Object), int? MinimumPagesRemaining = default(int?), int? Page = default(int?), int? PageSize = default(int?), List<UserAgreementResponse> UserAgreements = default(List<UserAgreementResponse>))
        {
            this.BeginCreatedOn = BeginCreatedOn;
            this.MinimumPagesRemaining = MinimumPagesRemaining;
            this.Page = Page;
            this.PageSize = PageSize;
            this.UserAgreements = UserAgreements;
        }
        
        /// <summary>
        /// User agreements from this datetime.
        /// </summary>
        /// <value>User agreements from this datetime.</value>
        [DataMember(Name="beginCreatedOn", EmitDefaultValue=false)]
        public Object BeginCreatedOn { get; set; }
        /// <summary>
        /// Number of pages remaining in the response.
        /// </summary>
        /// <value>Number of pages remaining in the response.</value>
        [DataMember(Name="minimumPagesRemaining", EmitDefaultValue=false)]
        public int? MinimumPagesRemaining { get; set; }
        /// <summary>
        /// The number of the current page.
        /// </summary>
        /// <value>The number of the current page.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// The number of items per page.
        /// </summary>
        /// <value>The number of items per page.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        /// <summary>
        /// An array of user agreements.
        /// </summary>
        /// <value>An array of user agreements.</value>
        [DataMember(Name="userAgreements", EmitDefaultValue=false)]
        public List<UserAgreementResponse> UserAgreements { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickwrapAgreementsResponse {\n");
            sb.Append("  BeginCreatedOn: ").Append(BeginCreatedOn).Append("\n");
            sb.Append("  MinimumPagesRemaining: ").Append(MinimumPagesRemaining).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  UserAgreements: ").Append(UserAgreements).Append("\n");
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
            return this.Equals(obj as ClickwrapAgreementsResponse);
        }

        /// <summary>
        /// Returns true if ClickwrapAgreementsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickwrapAgreementsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickwrapAgreementsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BeginCreatedOn == other.BeginCreatedOn ||
                    this.BeginCreatedOn != null &&
                    this.BeginCreatedOn.Equals(other.BeginCreatedOn)
                ) && 
                (
                    this.MinimumPagesRemaining == other.MinimumPagesRemaining ||
                    this.MinimumPagesRemaining != null &&
                    this.MinimumPagesRemaining.Equals(other.MinimumPagesRemaining)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.UserAgreements == other.UserAgreements ||
                    this.UserAgreements != null &&
                    this.UserAgreements.SequenceEqual(other.UserAgreements)
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
                if (this.BeginCreatedOn != null)
                    hash = hash * 59 + this.BeginCreatedOn.GetHashCode();
                if (this.MinimumPagesRemaining != null)
                    hash = hash * 59 + this.MinimumPagesRemaining.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.UserAgreements != null)
                    hash = hash * 59 + this.UserAgreements.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
