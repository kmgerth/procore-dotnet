using Procore.Api.Authentication;
using System;
using Xunit;

namespace Procore.Api.Tests.Authentication
{
    public class ClientCredentialsGrantFlowTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null, "client_secret")]
        [InlineData("", "client_secret")]
        [InlineData(" ", "client_secret")]
        [InlineData("client_id", null)]
        [InlineData("client_id", "")]
        [InlineData("client_id", " ")]
        public void ClientCredentialsGrantFlow_InvalidParameters_ThrowArgumentNullException(string clientId, string clientSecret)
        {
            Assert.Throws<ArgumentNullException>(() => new ClientCredentialsGrantFlow(clientId, clientSecret));
        }
    }
}