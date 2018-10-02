using Procore.Api.Authentication;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Procore.Api.Tests.Authentication
{
    public static class AuthenticationClientTests
    {
        //---------------------------------------------------------------------
        // GetTokenUsingClientCredentialsGrantFlowAsync
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null, "client_secret")]
        [InlineData("", "client_secret")]
        [InlineData(" ", "client_secret")]
        [InlineData("client_id", null)]
        [InlineData("client_id", "")]
        [InlineData("client_id", " ")]
        public static async Task GetTokenUsingClientCredentialsGrantFlowAsync_InvalidParameters_ThrowArgumentNullException(string clientId, string clientSecret)
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await AuthenticationClient.GetTokenUsingClientCredentialsGrantFlowAsync(clientId, clientSecret));
        }

        //---------------------------------------------------------------------
        // GetTokenAsync
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
        public static async Task GetTokenAsync_InvalidParameters_ThrowArgumentNullException(string clientId, string clientSecret, string code)
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await AuthenticationClient.GetTokenAsync(clientId, clientSecret, code));
        }

        //---------------------------------------------------------------------
        // RefreshTokenRequestAsync
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
        public static async Task RefreshTokenRequestAsync_InvalidParameters_ThrowArgumentNullException(string clientId, string clientSecret, string refreshToken)
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await AuthenticationClient.RefreshTokenAsync(clientId, clientSecret, refreshToken));
        }
    }
}