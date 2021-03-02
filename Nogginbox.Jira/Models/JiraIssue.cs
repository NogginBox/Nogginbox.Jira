namespace Nogginbox.Jira.Models
{
    public class JiraIssue
    {
        public int Id { get; set; }
        public string Key { get; set; }

        public JiraIssueFields Fields { get; set; }
    }
}
