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
    /// ServiceVersion
    /// </summary>
    [DataContract]
    public partial class ServiceVersion :  IEquatable<ServiceVersion>, IValidatableObject
    {
        public ServiceVersion()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVersion" /> class.
        /// </summary>
        /// <param name="Version">The human-readable semver version string..</param>
        /// <param name="VersionUrl">The URL where this version of the API can be found..</param>
        public ServiceVersion(string Version = default(string), string VersionUrl = default(string))
        {
            this.Version = Version;
            this.VersionUrl = VersionUrl;
        }
        
        /// <summary>
        /// The human-readable semver version string.
        /// </summary>
        /// <value>The human-readable semver version string.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// The URL where this version of the API can be found.
        /// </summary>
        /// <value>The URL where this version of the API can be found.</value>
        [DataMember(Name="versionUrl", EmitDefaultValue=false)]
        public string VersionUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceVersion {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VersionUrl: ").Append(VersionUrl).Append("\n");
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
            return this.Equals(obj as ServiceVersion);
        }

        /// <summary>
        /// Returns true if ServiceVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceVersion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.VersionUrl == other.VersionUrl ||
                    this.VersionUrl != null &&
                    this.VersionUrl.Equals(other.VersionUrl)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.VersionUrl != null)
                    hash = hash * 59 + this.VersionUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
