using System.Text.Json.Serialization;

namespace Nogginbox.Jira.Models
{
    public class JiraIssueFields
    {
        public string Description { get; set; }

        public JiraStatus Status { get; set; }

        [JsonPropertyName("customfield_10004")]
        public decimal StoryPoints { get; set; }

        public string Summary { get; set; }
    }
}
