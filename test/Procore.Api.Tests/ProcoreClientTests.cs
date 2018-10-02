using System;
using Xunit;

namespace Procore.Api.Tests
{
    public class ProcoreClientTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Constructor_InvalidToken_ThrowArgumentNullException(string token)
        {
            Assert.Throws<ArgumentNullException>(() => new ProcoreClient(token));
        }

        //---------------------------------------------------------------------
        // Properties
        //---------------------------------------------------------------------

        [Fact]
        public void Constructor_ValidArgument_PropertiesNotNull_Succeed()
        {
            const string token = "invalid_token";
            var client = new ProcoreClient(token);
            
            Assert.NotNull(client.CompanyClient);
            Assert.NotNull(client.CompanyUserClient);
            Assert.NotNull(client.CompanyVendorClient);
            Assert.NotNull(client.ProjectClient);
        }
    }
}