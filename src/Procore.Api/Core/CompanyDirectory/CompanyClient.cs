using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Represents a client that interacts with the Procore Company API.
    /// </summary>
    public class CompanyClient
    {
        //---------------------------------------------------------------------
        // Variables - Private
        //---------------------------------------------------------------------

        /// <summary>
        ///     <see cref="HttpClient" /> used to make the API requests.
        /// </summary>
        private readonly HttpClient _httpClient;

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        /// <summary>
        ///     Initializes a new instance of the <see cref="CompanyClient" /> class.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient" /> used to make the API requests.</param>
        /// <exception cref="ArgumentNullException" />
        public CompanyClient(HttpClient httpClient)
        {
            // Set the private variables.
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        //---------------------------------------------------------------------
        // Functions - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Retrieves all companies from the API.
        /// </summary>
        /// <exception cref="Exception" />
        /// <exception cref="HttpRequestException" />
        public async Task<List<Company>> GetAsync()
        {
            // Create the stream task using the HTTP client.
            HttpResponseMessage response = await _httpClient.GetAsync($"/vapid/companies");

            // If the request was successful, parse and return the response.
            if (response.IsSuccessStatusCode)
            {
                // Create the stream task using the HTTP client.
                string responseString = await response.Content.ReadAsStringAsync();

                // Read the stream and return the list of objects.
                return JsonConvert.DeserializeObject<List<Company>>(responseString);
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }
    }
}
