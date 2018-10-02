using System;
using System.Runtime.Serialization;

namespace Procore.Api.Authentication
{
    /// <summary>
    ///     Represents an oAuth 2.0 token.
    /// </summary>
    [DataContract]
    public class OauthToken
    {
        //---------------------------------------------------------------------
        // Properties - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     The access token string.
        /// </summary>
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     The type of oAuth token.
        /// </summary>
        [DataMember(Name = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        ///     Indicates if the token has expired.
        /// </summary>
        public bool Expired => DateTime.UtcNow > new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(CreatedAt).AddSeconds(ExpiresIn);

        /// <summary>
        ///     Number of seconds from the <see cref="CreatedAt" /> time until the token expires.
        /// </summary>
        [DataMember(Name = "expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        ///     The refresh token string.
        /// </summary>
        [DataMember(Name = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        ///     Time the token was created.
        /// </summary>
        [DataMember(Name = "created_at")]
        public int CreatedAt { get; set; }
    }
}