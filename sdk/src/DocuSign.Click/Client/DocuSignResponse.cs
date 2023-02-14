/* 
 * DocuSign Click API
 *
 * Elastic signing (also known as DocuSign Click)  lets you capture consent to standard agreement terms with a single click: terms and conditions, terms of service, terms of use, privacy policies, and more. The Click API lets you include this customizable elastic template solution in your DocuSign integrations.
 *
 * OpenAPI spec version: v1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;

namespace DocuSign.Click.Client
{
    public class DocuSignResponse
    {
        readonly HttpStatusCode statusCode = HttpStatusCode.OK;
        readonly IDictionary<string, string> headers = null;
        readonly string errorMessage = string.Empty;
        readonly string contentType = string.Empty;
        readonly byte[] rawBytes = null;

        public byte[] RawBytes => rawBytes;

        public string ContentType => contentType;

        public HttpStatusCode StatusCode => statusCode;
        
        public string Content => rawBytes != null ? System.Text.Encoding.UTF8.GetString(rawBytes) : null;
        
        public string ErrorMessage => errorMessage;

        public IDictionary<string, string> Headers => headers;

        public DocuSignResponse(HttpStatusCode _statusCode, IDictionary<string, string> _headers, byte[] _rawBytes, string _contentType)
        {
            statusCode = _statusCode;
            headers = _headers;
            rawBytes = _rawBytes;
            contentType = _contentType;
        }
    }
}
