using System.Net.Http;

namespace Nogginbox.Jira.Authentication
{
    public interface IJiraAuthentication
    {
        void ConfigureAuthentication(HttpClient http);
    }
}
