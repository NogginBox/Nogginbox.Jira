namespace Nogginbox.Jira.Models
{
    public abstract class BasePagedResponse
    {
        public int StartAt { get; set; }
    
        public int MaxResults { get; set; }
    
        public int Total { get; set; }
    }
}