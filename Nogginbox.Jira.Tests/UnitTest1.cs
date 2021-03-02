using Nogginbox.Jira.Authentication;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Nogginbox.Jira.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var client = new JiraClient(new HttpClient());
            client.AddAuthentication(new UsernameTokenAuthentication { Username = "***", Token = "***" });

            var epicIssues = await client.Epics.GetIssuesForEpic(216, 84109);

            Assert.NotEmpty(epicIssues);
        }
    }
}