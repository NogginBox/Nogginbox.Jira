using Nogginbox.Jira.Authentication;
using System;
using System.Net.Http;

namespace Nogginbox.Jira
{
    public abstract class JiraClientBase
    {
        private readonly HttpClient _http;
        private bool _configured = false;

        public JiraClientBase(HttpClient http)
        {
            _http = http;
            _http.BaseAddress = new Uri("https://cqcwebdev.atlassian.net/");
        }

        protected HttpClient Http
        {
            get
            {
                if (!_configured)
                {
                    throw new Exception("You must call AddAuthentication");
                }
                return _http;
            }
        }

        public void AddAuthentication(IJiraAuthentication auth)
        {
            auth.ConfigureAuthentication(_http);
            _configured = true;
        }
    }
}