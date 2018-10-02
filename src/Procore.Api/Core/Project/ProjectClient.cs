using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Procore.Api.Core.Project
{
    /// <summary>
    ///     Represents a client that interacts with the Procore Project API.
    /// </summary>
    public class ProjectClient
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
        ///     Initializes a new instance of the <see cref="ProjectClient" /> class.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient" /> used to make the API requests.</param>
        /// <exception cref="ArgumentNullException" />
        public ProjectClient(HttpClient httpClient)
        {
            // Set the private variables.
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        //---------------------------------------------------------------------
        // Functions - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Retrieves all <see cref="Project"/> objects from the API.
        /// </summary>
        /// <param name="company">Company ID.</param>
        /// <exception cref="Exception" />
        /// <exception cref="ArgumentException" />
        /// <exception cref="HttpRequestException" />
        public async Task<List<Project>> GetAsync(int company)
        {
            // Determine if the company is valid.
            if (company <= 0)
            {
                throw new ArgumentException("The company ID is not valid.", nameof(company));
            }

            // Create the stream task using the HTTP client.
            HttpResponseMessage response = await _httpClient.GetAsync($"/vapid/projects?company_id={company}");

            // If the request was successful, parse and return the response.
            if (response.IsSuccessStatusCode)
            {
                // Create the stream task using the HTTP client.
                string responseString = await response.Content.ReadAsStringAsync();

                // Read the stream and return the list of objects.
                return JsonConvert.DeserializeObject<List<Project>>(responseString);
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }
    }
}
