using System;
using System.Runtime.Serialization;

namespace Procore.Api.Authentication
{
    /// <summary>
    ///     Represents a request to refresh an oAuth 2.0 token.
    /// </summary>
    [DataContract]
    internal class AuthorizationTokenRequests
    {
        //---------------------------------------------------------------------
        // Properties - Public
        //---------------------------------------------------------------------
        /// <summary>
        ///     The authorization code.
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; }

        /// <summary>
        ///     Client secret assigned when registering the application.
        /// </summary>
        [DataMember(Name = "client_secret")]
        public string ClientSecret { get; }

        /// <summary>
        ///     The URL within your application that will receive OAuth 2.0 credentials.
        /// </summary>
        [DataMember(Name = "redirect_uri")]
        public string RedirectUri => "urn:ietf:wg:oauth:2.0:oob";

        /// <summary>
        ///     Type of token.
        /// </summary>
        [DataMember(Name = "grant_type")]
        public string GrantType => "authorization_code";

        /// <summary>
        ///     Client ID assigned when registering the application.
        /// </summary>
        [DataMember(Name = "client_id")]
        public string ClientId { get; }

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        /// <summary>
        ///     Initializes a new instance of the <see cref="AuthorizationTokenRequests"/> class.
        /// </summary>
        /// <param name="clientId">Client ID assigned when registering the application.</param>
        /// <param name="clientSecret">Client secret assigned when registering the application.</param>
        /// <param name="code">The authorization code.></param>
        public AuthorizationTokenRequests(string clientId, string clientSecret, string code)
        {
            // Determine if the Client ID is null.
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            // Determine if the Client Secret is null.
            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new ArgumentNullException(nameof(clientSecret));
            }

            // Determine if the refresh token is null.
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentNullException(nameof(code));
            }

            // Set the properties.
            ClientId = clientId;
            ClientSecret = clientSecret;
            Code = code;
        }
    }
}