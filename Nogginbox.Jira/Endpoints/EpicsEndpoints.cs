using Nogginbox.Jira.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nogginbox.Jira
{
    public partial class JiraClient
    {
        public class EpicsEndpoints
        {
            private readonly JiraClient _client;
            private readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

            public EpicsEndpoints(JiraClient client)
            {
                _client = client;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <remarks>API docs: https://docs.atlassian.com/jira-software/REST/7.3.1/#agile/1.0/board/{boardId}/epic-getIssuesForEpic</remarks>
            public async Task<IList<JiraIssue>> GetIssuesForEpic(int boardId, int epicId)
            {
                var apiName = $"rest/agile/1.0/board/{boardId}/epic/{epicId}/issue";
                var httpResponse = await _client.Http.GetAsync(apiName);
                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception(httpResponse.StatusCode + " - " + httpResponse.Content);
                }

                var content = await httpResponse.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<JiraIssuesPagedResponse>(content, _jsonOptions);
                var issues = data.Issues;
                return issues;
            }
        }
    }
}
