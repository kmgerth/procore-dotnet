using System;
using System.Runtime.Serialization;

namespace Procore.Api.Authentication
{
    /// <summary>
    ///     Represents a request to refresh an oAuth 2.0 token.
    /// </summary>
    [DataContract]
    internal class RefreshTokenRequest
    {
        //---------------------------------------------------------------------
        // Properties - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Client secret assigned when registering the application.
        /// </summary>
        [DataMember(Name = "client_secret")]
        public string ClientSecret { get; }

        /// <summary>
        ///     The refresh token string.
        /// </summary>
        [DataMember(Name = "refresh_token")]
        public string RefreshToken { get; }

        /// <summary>
        ///     Type of token.
        /// </summary>
        [DataMember(Name = "grant_type")]
        public string GrantType => "refresh_token";

        /// <summary>
        ///     Client ID assigned when registering the application.
        /// </summary>
        [DataMember(Name = "client_id")]
        public string ClientId { get; }

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        /// <summary>
        ///     Initializes a new instance of the <see cref="RefreshTokenRequest"/> class.
        /// </summary>
        /// <param name="clientId">Client ID assigned when registering the application.</param>
        /// <param name="clientSecret">Client secret assigned when registering the application.</param>
        /// <param name="refreshToken">The refresh token string.></param>
        public RefreshTokenRequest(string clientId, string clientSecret, string refreshToken)
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
            if (string.IsNullOrWhiteSpace(refreshToken))
            {
                throw new ArgumentNullException(nameof(refreshToken));
            }

            // Set the properties.
            ClientId = clientId;
            ClientSecret = clientSecret;
            RefreshToken = refreshToken;
        }
    }
}