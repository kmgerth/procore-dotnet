using System;
using System.Net.Http;
using System.Threading.Tasks;
using Procore.Api.Core.CompanyDirectory;
using Xunit;

namespace Procore.Api.Tests.Core
{
    public class CompanyUserClientTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null)]
        public void Constructor_InvalidHttpClient_ThrowArgumentNullException(HttpClient httpClient)
        {
            Assert.Throws<ArgumentNullException>(() => new CompanyUserClient(httpClient));
        }

        //---------------------------------------------------------------------
        // CreateAsync
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task CreateAsync_InvalidCompany_ThrowArgumentException(int company)
        {
            // Create the mock variables.
            CompanyUser user = new CompanyUser();
            HttpClient httpClient = new HttpClient();
            CompanyUserClient companyUserClient = new CompanyUserClient(httpClient);

            await Assert.ThrowsAsync<ArgumentException>(async () => await companyUserClient.CreateAsync(company, user));
        }

        [Theory]
        [InlineData(null)]
        public async Task CreateAsync_NullCompanyUser_ThrowArgumentNullException(CompanyUser user)
        {
            // Create the mock variables.
            const int company = 1;
            HttpClient httpClient = new HttpClient();
            CompanyUserClient companyUserClient = new CompanyUserClient(httpClient);

            await Assert.ThrowsAsync<ArgumentNullException>(async () => await companyUserClient.CreateAsync(company, user));
        }

        //---------------------------------------------------------------------
        // GetAsync
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task GetAsync_InvalidCompany_ThrowArgumentException(int company)
        {
            // Create the mock variables.
            HttpClient httpClient = new HttpClient();
            CompanyUserClient companyUserClient = new CompanyUserClient(httpClient);

            await Assert.ThrowsAsync<ArgumentException>(async () => await companyUserClient.GetAsync(company));
        }

        //---------------------------------------------------------------------
        // GetByIdAsync
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task GetByIdAsync_InvalidCompany_ThrowArgumentException(int company)
        {
            // Create the mock variables.
            const int id = 1;
            HttpClient httpClient = new HttpClient();
            CompanyUserClient companyUserClient = new CompanyUserClient(httpClient);

            await Assert.ThrowsAsync<ArgumentException>(async () => await companyUserClient.GetByIdAsync(company, id));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task GetByIdAsync_InvalidId_ThrowArgumentException(int id)
        {
            // Create the mock variables.
            const int company = 1;
            HttpClient httpClient = new HttpClient();
            CompanyUserClient companyUserClient = new CompanyUserClient(httpClient);

            await Assert.ThrowsAsync<ArgumentException>(async () => await companyUserClient.GetByIdAsync(company, id));
        }
    }
}
