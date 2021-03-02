namespace Nogginbox.Jira.Models
{
    public class JiraStatus
    {
        public string Self { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public JiraStatusCategory StatusCategory { get; set; }
    }
}
