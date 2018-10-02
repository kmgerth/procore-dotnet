using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Represents a client that interacts with the Procore Company User API.
    /// </summary>
    public class CompanyUserClient
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
        ///     Initializes a new instance of the <see cref="CompanyUserClient" /> class.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient" /> used to make the API requests.</param>
        /// <exception cref="ArgumentNullException" />
        public CompanyUserClient(HttpClient httpClient)
        {
            // Set the private variables.
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        //---------------------------------------------------------------------
        // Functions - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Creates a new <see cref="CompanyUser"/> in the the specified Company.
        /// </summary>
        /// <param name="company">Company ID.</param>
        /// <param name="companyUser">User of the company.</param>
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="HttpRequestException" />
        public async Task<CompanyUser> CreateAsync(int company, CompanyUser companyUser)
        {
            // Determine if the company is valid.
            if (company <= 0)
            {
                throw new ArgumentException("The company ID is not valid.", nameof(company));
            }

            // Determine if the companyUser is null.
            if (companyUser == null)
            {
                throw new ArgumentNullException(nameof(companyUser));
            }

            // Pass the request to the API.
            string contentString = JsonConvert.SerializeObject(companyUser);
            StringContent content = new StringContent(contentString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"/vapid/companies/{company}/users", content);

            // If the request was successful, parse and return the response.
            if (response.IsSuccessStatusCode)
            {
                // Create the stream task using the HTTP client.
                string responseString = await response.Content.ReadAsStringAsync();

                // Read the stream and return the list of objects.
                return JsonConvert.DeserializeObject<CompanyUser>(responseString);
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }

        /// <summary>
        ///     Retrieves all users from the company.
        /// </summary>
        /// <param name="company">Company ID.</param>
        /// <exception cref="ArgumentException" />
        /// <exception cref="HttpRequestException" />
        public async Task<List<CompanyUserDetail>> GetAsync(int company)
        {
            // Determine if the company is null.
            if (company <= 0)
            {
                throw new ArgumentException("The company ID is not valid.", nameof(company));
            }

            // Create the stream task using the HTTP client.
            HttpResponseMessage response = await _httpClient.GetAsync($"/vapid/companies/{company}/users");

            // If the request was successful, parse and return the response.
            if (response.IsSuccessStatusCode)
            {
                // Create the stream task using the HTTP client.
                string responseString = await response.Content.ReadAsStringAsync();

                // Read the stream and return the list of objects.
                return JsonConvert.DeserializeObject<List<CompanyUserDetail>>(responseString);
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }

        /// <summary>
        ///     Retrieves the specific companyUser from the company.
        /// </summary>
        /// <param name="company">Company ID.</param>
        /// <param name="id">ID of the companyUser of the company.</param>
        /// <exception cref="Exception" />
        /// <exception cref="ArgumentException" />
        /// <exception cref="HttpRequestException" />
        public async Task<CompanyUserDetail> GetByIdAsync(int company, int id)
        {
            // Determine if the company is null.
            if (company <= 0)
            {
                throw new ArgumentException("The company ID is not valid.", nameof(company));
            }

            // Determine if the company is null.
            if (id <= 0)
            {
                throw new ArgumentException("The ID is not valid.", nameof(company));
            }

            // Create the stream task using the HTTP client.
            HttpResponseMessage response = await _httpClient.GetAsync($"/vapid/companies/{company}/users/{id}");

            // If the request was successful, parse and return the response.
            if (response.IsSuccessStatusCode)
            {
                // Create the stream task using the HTTP client.
                string responseString = await response.Content.ReadAsStringAsync();

                // Read the stream and return the list of objects.
                return JsonConvert.DeserializeObject<CompanyUserDetail>(responseString);
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }
    }
}
