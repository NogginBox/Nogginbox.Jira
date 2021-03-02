using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Nogginbox.Jira.Authentication
{
    /// <summary>
    /// Get an API token at https://id.atlassian.com/manage/api-tokens
    /// </summary>
    public class UsernameTokenAuthentication : IJiraAuthentication
    {
        public string Username { get; init; }

        public string Token { get; init; }

        public void ConfigureAuthentication(HttpClient httpClient)
        {
            if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Token))
            {
                throw new ArgumentException("Username and Token are required");
            }

            var authenticationString = $"{Username}:{Token}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString));

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
        }
    }
}
