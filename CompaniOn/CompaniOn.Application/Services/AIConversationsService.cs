using AutoMapper;
using FluentValidation;

using CompaniOn.Core;
using CompaniOn.Application.Interfaces;
using CompaniOn.Infrastructure;
using CompaniOn.Infrastructure.Interfaces;
using CompaniOn.Core.Entities;

namespace CompaniOn.Application
{
    public class AIConversationsService : BaseService<AIConversation, AIConversationDto, AIConversationUpsertDto, AIConversationSearchObject, IAIConversationsRepository>, IAIConversationsService
    {
        public AIConversationsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<AIConversationUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {

        }
    }
}
