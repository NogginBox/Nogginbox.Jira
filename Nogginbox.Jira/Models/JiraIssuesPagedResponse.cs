using System.Collections.Generic;

namespace Nogginbox.Jira.Models
{
    public class JiraIssuesPagedResponse : BasePagedResponse
    {
        public IList<JiraIssue> Issues {get;set;}
    }
}
