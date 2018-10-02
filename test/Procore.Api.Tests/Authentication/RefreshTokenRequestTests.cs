using Procore.Api.Authentication;
using System;
using Xunit;

namespace Procore.Api.Authentication
{
    public class RefreshTokenRequestTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null, "client_secret", "refresh_token")]
        [InlineData("", "client_secret", "refresh_token")]
        [InlineData(" ", "client_secret", "refresh_token")]
        [InlineData("client_id", null, "refresh_token")]
        [InlineData("client_id", "", "refresh_token")]
        [InlineData("client_id", " ", "refresh_token")]
        [InlineData("client_id", "client_secret", null)]
        [InlineData("client_id", "client_secret", "")]
        [InlineData("client_id", "client_secret", " ")]
        public void RefreshTokenRequest_InvalidParameters_ThrowArgumentNullException(string clientId, string clientSecret, string refreshToken)
        {
            Assert.Throws<ArgumentNullException>(() => new RefreshTokenRequest(clientId, clientSecret, refreshToken));
        }

        [Theory]
        [InlineData("client_id", "client_secret", "refresh_token")]
        public void AuthorizationTokenRequests_ValidParameters_AssertAllPropertiesAssigned(string clientId, string clientSecret, string refreshToken)
        {
            RefreshTokenRequest request = new RefreshTokenRequest(clientId, clientSecret, refreshToken);

            Assert.NotNull(request.ClientSecret);
            Assert.NotNull(request.ClientId);
            Assert.NotNull(request.RefreshToken);
            Assert.NotNull(request.GrantType);
        }
    }
}
