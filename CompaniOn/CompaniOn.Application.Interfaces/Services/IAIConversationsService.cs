using CompaniOn.Core;
using CompaniOn.Infrastructure.Interfaces;

namespace CompaniOn.Application.Interfaces
{
    public interface IAIConversationsService : IBaseService<int, AIConversationDto, AIConversationUpsertDto, AIConversationSearchObject>
    {

    }
}
