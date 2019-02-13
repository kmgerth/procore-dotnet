using System;
using System.Net.Http;
using System.Threading.Tasks;
using Procore.Api.Core.CompanyDirectory;
using Xunit;

namespace Procore.Api.Tests.Core
{
    public class CompanyVendorClientTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null)]
        public void Constructor_InvalidHttpClient_ThrowArgumentNullException(HttpClient httpClient)
        {
            Assert.Throws<ArgumentNullException>(() => new CompanyVendorClient(httpClient));
        }

        //---------------------------------------------------------------------
        // CreateAsync
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null)]
        public async Task CreateAsync_InvalidCompany_ThrowArgumentNullException(CompanyVendorCreate vendor)
        {
            // Create the mock variables.
            HttpClient httpClient = new HttpClient();
            CompanyVendorClient companyVendorClient = new CompanyVendorClient(httpClient);

            await Assert.ThrowsAsync<ArgumentNullException>(async () => await companyVendorClient.CreateComapnyVendorAsync(vendor));
        }        
    }
}
