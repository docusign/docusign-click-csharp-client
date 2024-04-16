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
    /// Control the display of the header.
    /// </summary>
    [DataContract]
    public partial class HeaderStyles :  IEquatable<HeaderStyles>, IValidatableObject
    {
        public HeaderStyles()
        {
            // Empty Constructor
        }

                /// <summary>
        /// Control the display of the header. Can only be set to &#39;none&#39; over the default for hiding purposes.
        /// </summary>
        /// <value>Control the display of the header. Can only be set to &#39;none&#39; over the default for hiding purposes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayEnum
        {
            
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1
        }

        /// <summary>
        /// Control the display of the header. Can only be set to 'none' over the default for hiding purposes.
        /// </summary>
        /// <value>Control the display of the header. Can only be set to 'none' over the default for hiding purposes.</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public DisplayEnum? Display { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderStyles" /> class.
        /// </summary>
        /// <param name="Color">Control the fore-ground color of the element..</param>
        /// <param name="Display">Control the display of the header. Can only be set to &#39;none&#39; over the default for hiding purposes..</param>
        /// <param name="FontFamily">Control the font family of the text..</param>
        /// <param name="FontSize">Control the font size of the text..</param>
        /// <param name="FontStyle">Control the font style of the text..</param>
        /// <param name="FontWeight">Control the font weight of the text..</param>
        /// <param name="TextDecoration">Control the underline and other styles of the text..</param>
        public HeaderStyles(string Color = default(string), DisplayEnum? Display = default(DisplayEnum?), string FontFamily = default(string), string FontSize = default(string), string FontStyle = default(string), Object FontWeight = default(Object), string TextDecoration = default(string))
        {
            this.Color = Color;
            this.Display = Display;
            this.FontFamily = FontFamily;
            this.FontSize = FontSize;
            this.FontStyle = FontStyle;
            this.FontWeight = FontWeight;
            this.TextDecoration = TextDecoration;
        }
        
        /// <summary>
        /// Control the fore-ground color of the element.
        /// </summary>
        /// <value>Control the fore-ground color of the element.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        /// <summary>
        /// Control the font family of the text.
        /// </summary>
        /// <value>Control the font family of the text.</value>
        [DataMember(Name="fontFamily", EmitDefaultValue=false)]
        public string FontFamily { get; set; }
        /// <summary>
        /// Control the font size of the text.
        /// </summary>
        /// <value>Control the font size of the text.</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }
        /// <summary>
        /// Control the font style of the text.
        /// </summary>
        /// <value>Control the font style of the text.</value>
        [DataMember(Name="fontStyle", EmitDefaultValue=false)]
        public string FontStyle { get; set; }
        /// <summary>
        /// Control the font weight of the text.
        /// </summary>
        /// <value>Control the font weight of the text.</value>
        [DataMember(Name="fontWeight", EmitDefaultValue=false)]
        public Object FontWeight { get; set; }
        /// <summary>
        /// Control the underline and other styles of the text.
        /// </summary>
        /// <value>Control the underline and other styles of the text.</value>
        [DataMember(Name="textDecoration", EmitDefaultValue=false)]
        public string TextDecoration { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeaderStyles {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  FontStyle: ").Append(FontStyle).Append("\n");
            sb.Append("  FontWeight: ").Append(FontWeight).Append("\n");
            sb.Append("  TextDecoration: ").Append(TextDecoration).Append("\n");
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
            return this.Equals(obj as HeaderStyles);
        }

        /// <summary>
        /// Returns true if HeaderStyles instances are equal
        /// </summary>
        /// <param name="other">Instance of HeaderStyles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeaderStyles other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) && 
                (
                    this.FontFamily == other.FontFamily ||
                    this.FontFamily != null &&
                    this.FontFamily.Equals(other.FontFamily)
                ) && 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) && 
                (
                    this.FontStyle == other.FontStyle ||
                    this.FontStyle != null &&
                    this.FontStyle.Equals(other.FontStyle)
                ) && 
                (
                    this.FontWeight == other.FontWeight ||
                    this.FontWeight != null &&
                    this.FontWeight.Equals(other.FontWeight)
                ) && 
                (
                    this.TextDecoration == other.TextDecoration ||
                    this.TextDecoration != null &&
                    this.TextDecoration.Equals(other.TextDecoration)
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
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                if (this.FontFamily != null)
                    hash = hash * 59 + this.FontFamily.GetHashCode();
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                if (this.FontStyle != null)
                    hash = hash * 59 + this.FontStyle.GetHashCode();
                if (this.FontWeight != null)
                    hash = hash * 59 + this.FontWeight.GetHashCode();
                if (this.TextDecoration != null)
                    hash = hash * 59 + this.TextDecoration.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
