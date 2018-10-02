using System;
using System.Net.Http;
using Procore.Api.Core.CompanyDirectory;
using Xunit;

namespace Procore.Api.Tests.Core
{
    public class CompanyClientTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null)]
        public void Constructor_InvalidHttpClient_ThrowArgumentNullException(HttpClient httpClient)
        {
            Assert.Throws<ArgumentNullException>(() => new CompanyClient(httpClient));
        }
    }
}
