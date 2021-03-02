using System.Net.Http;

namespace Nogginbox.Jira
{

    public partial class JiraClient : JiraClientBase
    {
        public JiraClient(HttpClient http) : base(http)
        {
            Epics = new EpicsEndpoints(this);
        }


        public EpicsEndpoints Epics { get; private set; }

     
    }

    
}
