using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Procore.Api.Authentication
{
    /// <summary>
    ///     Represents a client that interacts with the Procore Authentication API.
    /// </summary>
    public static class AuthenticationClient
    {
        //---------------------------------------------------------------------
        // Functions - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Used to request a token using an authorization code.
        /// </summary>
        /// <param name="clientId">Client ID assigned when registering the application.</param>
        /// <param name="clientSecret">Client secret assigned when registering the application.</param>
        /// <param name="code">The authorization code.></param>
        /// <param name="client"><see cref="HttpClient" /> used to make the API requests.</param>
        /// <exception cref="Exception" />
        /// <exception cref="ArgumentNullException" />
        public static async Task<OauthToken> GetTokenAsync(string clientId, string clientSecret, string code, HttpClient client = null)
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

            // If a client was not passed in, construct one.
            if (client == null)
            {
                client = new HttpClient { BaseAddress = new Uri("https://app.procore.com/") };
                client.DefaultRequestHeaders.Accept.Clear();
            }

            // Construct the request.
            AuthorizationTokenRequests request = new AuthorizationTokenRequests(clientId, clientSecret, code);

            // Pass the request to the API.
            string contentString = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(contentString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("oauth/token", content);

            // If the response was successful, extract the new token.
            if (response.IsSuccessStatusCode)
            {
                // Create the serializer.
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OauthToken));
                Task<Stream> streamTask = response.Content.ReadAsStreamAsync();
                return serializer.ReadObject(await streamTask) as OauthToken;
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }

        /// <summary>
        ///     Used to request a token using an authorization code.
        /// </summary>
        /// <param name="clientId">Client ID assigned when registering the application.</param>
        /// <param name="clientSecret">Client secret assigned when registering the application.</param>
        /// <param name="code">The authorization code.></param>
        /// <param name="client"><see cref="HttpClient" /> used to make the API requests.</param>
        /// <exception cref="Exception" />
        /// <exception cref="ArgumentNullException" />
        public static async Task<OauthToken> GetTokenUsingClientCredentialsGrantFlowAsync(string clientId, string clientSecret, HttpClient client = null)
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

            // If a client was not passed in, construct one.
            if (client == null)
            {
                client = new HttpClient { BaseAddress = new Uri("https://app.procore.com/") };
                client.DefaultRequestHeaders.Accept.Clear();
            }

            // Construct the request.
            ClientCredentialsGrantFlow request = new ClientCredentialsGrantFlow(clientId, clientSecret);

            // Pass the request to the API.
            string contentString = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(contentString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("oauth/token", content);

            // If the response was successful, extract the new token.
            if (response.IsSuccessStatusCode)
            {
                // Create the serializer.
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OauthToken));
                Task<Stream> streamTask = response.Content.ReadAsStreamAsync();
                return serializer.ReadObject(await streamTask) as OauthToken;
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }

        /// <summary>
        ///     Used to refresh an existing access token.
        /// </summary>
        /// <param name="clientId">Client ID assigned when registering the application.</param>
        /// <param name="clientSecret">Client secret assigned when registering the application.</param>
        /// <param name="refreshToken">The refresh token string.></param>
        /// <param name="client"><see cref="HttpClient" /> used to make the API requests.</param>
        /// <exception cref="Exception" />
        /// <exception cref="ArgumentNullException" />
        public static async Task<OauthToken> RefreshTokenAsync(string clientId, string clientSecret, string refreshToken, HttpClient client = null)
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

            // If a client was not passed in, construct one.
            if (client == null)
            {
                client = new HttpClient { BaseAddress = new Uri("https://app.procore.com/") };
                client.DefaultRequestHeaders.Accept.Clear();
            }

            // Construct the request.
            RefreshTokenRequest request = new RefreshTokenRequest(clientId, clientSecret, refreshToken);

            // Pass the request to the API.
            string contentString = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(contentString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("oauth/token", content);

            // If the response was successful, extract the new token.
            if (response.IsSuccessStatusCode)
            {
                // Create the serializer.
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OauthToken));
                Task<Stream> streamTask = response.Content.ReadAsStreamAsync();
                return serializer.ReadObject(await streamTask) as OauthToken;
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }
    }
}