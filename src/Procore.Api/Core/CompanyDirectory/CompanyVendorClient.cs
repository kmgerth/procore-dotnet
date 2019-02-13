﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Represents a client that interacts with the Procore Company Vendor API.
    /// </summary>
    public class CompanyVendorClient
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
        ///     Initializes a new instance of the <see cref="CompanyVendorClient" /> class.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient" /> used to make the API requests.</param>
        /// <exception cref="ArgumentNullException" />
        public CompanyVendorClient(HttpClient httpClient)
        {
            // Set the private variables.
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        //---------------------------------------------------------------------
        // Functions - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Retrieves all <see cref="CompanyVendor"/> objects from the API.
        /// </summary>
        /// <param name="company">Company ID.</param>
        /// <exception cref="Exception" />
        /// <exception cref="ArgumentException" />
        /// <exception cref="HttpRequestException" />
        public async Task<List<CompanyVendor>> GetCompanyVendorAsync(int company)
        {
            // Determine if the company is valid.
            if (company <= 0)
            {
                throw new ArgumentException("The company ID is not valid.", nameof(company));
            }

            // Create the stream task using the HTTP client.
            HttpResponseMessage response = await _httpClient.GetAsync($"/vapid/vendors?company_id={company}");

            // If the request was successful, parse and return the response.
            if (response.IsSuccessStatusCode)
            {
                // Create the stream task using the HTTP client.
                string responseString = await response.Content.ReadAsStringAsync();

                // Read the stream and return the list of objects.
                return JsonConvert.DeserializeObject<List<CompanyVendor>>(responseString);
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }

        /// <summary>
        ///     Creates a new <see cref="CompanyVendor" />.
        /// </summary>
        /// <param name="vendor">Vendor of the <see cref="Company" />.</param>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="HttpRequestException" />
        public async Task<CompanyVendor> CreateComapnyVendorAsync(CompanyVendorCreate vendor)
        {
            // Determine if the company vendor is null.
            if (vendor == null)
            {
                throw new ArgumentNullException(nameof(vendor));
            }

            // Pass the request to the API.
            string contentString = JsonConvert.SerializeObject(vendor);
            StringContent content = new StringContent(contentString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("vapid/vendors", content);

            // If the request was successful, parse and return the response.
            if (response.IsSuccessStatusCode)
            {
                // Create the stream task using the HTTP client.
                string responseString = await response.Content.ReadAsStringAsync();

                // Read the stream and return the list of objects.
                return JsonConvert.DeserializeObject<CompanyVendor>(responseString);
            }

            // If the request was not successful, throw an error.
            throw new Exception(response.ReasonPhrase);
        }        
    }
}
