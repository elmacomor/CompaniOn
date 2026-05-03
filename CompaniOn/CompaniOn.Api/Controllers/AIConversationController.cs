using CompaniOn.Core;
using CompaniOn.Application.Interfaces;
using CompaniOn.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CompaniOn.Api.Controllers
{
    public class AIConversationController : BaseCrudController<AIConversationDto, AIConversationUpsertDto, AIConversationSearchObject, IAIConversationsService>
    {
        public AIConversationController(IAIConversationsService service, ILogger<AIConversationController> logger) : base(service, logger)
        {
        }

        [AllowAnonymous]
        public override Task<IActionResult> GetPaged([FromQuery] AIConversationSearchObject searchObject, CancellationToken cancellationToken = default)
        {
            return base.GetPaged(searchObject, cancellationToken);
        }
    }
}
