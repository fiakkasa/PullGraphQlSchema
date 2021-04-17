using Microsoft.AspNetCore.Mvc;
using PullGraphQlSchema.GraphQL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PullGraphQlSchema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConferenceController : ControllerBase
    {
        private readonly IConferenceClient _conferenceClient;

        public ConferenceController(IConferenceClient conferenceClient)
        {
            _conferenceClient = conferenceClient;
        }

        [HttpGet]
        public async ValueTask<IReadOnlyList<IGetSessions_Sessions_Nodes>?> Get() =>
            (await _conferenceClient.GetSessions.ExecuteAsync().ConfigureAwait(false))
                .Data?
                .Sessions?
                .Nodes;
    }
}
