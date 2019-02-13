using System;
using System.Net.Http;
using System.Threading.Tasks;
using Procore.Api.Core.Project;
using Xunit;

namespace Procore.Api.Tests.Core.Project
{
    public class ProjectClientTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null)]
        public void Constructor_InvalidHttpClient_ThrowArgumentNullException(HttpClient httpClient)
        {
            Assert.Throws<ArgumentNullException>(() => new ProjectClient(httpClient));
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
            ProjectClient companyUserClient = new ProjectClient(httpClient);

            await Assert.ThrowsAsync<ArgumentException>(async () => await companyUserClient.GetProjectsAsync(company));
        }
    }
}
