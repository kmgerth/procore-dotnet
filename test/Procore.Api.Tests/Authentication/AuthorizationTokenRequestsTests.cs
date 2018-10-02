using Procore.Api.Authentication;
using System;
using Xunit;

namespace Procore.Api.Tests.Authentication
{
    public class AuthorizationTokenRequestsTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null, "client_secret", "code")]
        [InlineData("", "client_secret", "code")]
        [InlineData(" ", "client_secret", "code")]
        [InlineData("client_id", null, "code")]
        [InlineData("client_id", "", "code")]
        [InlineData("client_id", " ", "code")]
        [InlineData("client_id", "client_secret", null)]
        [InlineData("client_id", "client_secret", "")]
        [InlineData("client_id", "client_secret", " ")]
        public void AuthorizationTokenRequests_InvalidParameters_ThrowArgumentNullException(string clientId, string clientSecret, string code)
        {
            Assert.Throws<ArgumentNullException>(() => new AuthorizationTokenRequests(clientId, clientSecret, code));
        }

        [Theory]
        [InlineData("client_id", "client_secret", "code")]
        public void AuthorizationTokenRequests_ValidParameters_AssertAllPropertiesAssigned(string clientId, string clientSecret, string code)
        {
            AuthorizationTokenRequests request = new AuthorizationTokenRequests(clientId, clientSecret, code);

            Assert.NotNull(request.ClientId);
            Assert.NotNull(request.ClientSecret);
            Assert.NotNull(request.Code);
            Assert.NotNull(request.RedirectUri);
            Assert.NotNull(request.GrantType);
        }
    }
}