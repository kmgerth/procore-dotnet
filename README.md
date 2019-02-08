# procore-dotnet
Repository for a .NET standard implementation of the Procore API.

## Retrieve a token using Client Credentials
```
private static async Task<string> GetAuthenticationTokenAsync()
{
    OauthToken oauthToken = await AuthenticationClient.GetTokenUsingClientCredentialsGrantFlowAsync("ClientID", "ClientSecret");
    if (oauthToken == null)
    {
        throw new Exception("oAuth Token could not be obtained!");
    }

    return oauthToken.AccessToken;
}
```

## Query Procore API
```
private static async Task GetCompanies(string token)
{
    ProcoreClient client = new ProcoreClient(token);
    var companies = await client.CompanyClient.GetAsync();
}
```
