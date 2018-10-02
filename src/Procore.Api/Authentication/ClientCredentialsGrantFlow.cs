using System;
using System.Runtime.Serialization;

namespace Procore.Api.Authentication
{
    /// <summary>
    ///     Represents a request to obtain an oAuth 2.0 token using the Client Credentials grant flow.
    /// </summary>
    [DataContract]
    internal class ClientCredentialsGrantFlow
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
        ///     Type of token.
        /// </summary>
        [DataMember(Name = "grant_type")]
        public string GrantType => "client_credentials";

        /// <summary>
        ///     Client ID assigned when registering the application.
        /// </summary>
        [DataMember(Name = "client_id")]
        public string ClientId { get; }

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        /// <summary>
        ///     Initializes a new instance of the <see cref="ClientCredentialsGrantFlow"/> class.
        /// </summary>
        /// <param name="clientId">Client ID assigned when registering the application.</param>
        /// <param name="clientSecret">Client secret assigned when registering the application.</param>
        public ClientCredentialsGrantFlow(string clientId, string clientSecret)
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

            // Set the properties.
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
}