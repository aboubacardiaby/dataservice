using Microsoft.AspNetCore.Authentication;

namespace dataservice.Extensions
{

    /// <summary>
    /// Defines options.
    /// </summary>
    public class ApiKeyAuthenticationOptions : AuthenticationSchemeOptions
    {
        /// <summary>
        /// The default scheme
        /// </summary>
        public const string DefaultScheme = "API Key";

        /// <summary>
        /// Scheme
        /// </summary>
        public string Scheme => DefaultScheme;

        /// <summary>
        /// AuthenticationType
        /// </summary>
        public string AuthenticationType = DefaultScheme;


    }
}