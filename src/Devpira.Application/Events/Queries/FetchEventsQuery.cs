using Devpira.Domain.Events;

using MediatR;

namespace Devpira.Application.Events.Queries;

public class FetchEventsQuery: IRequest<IEnumerable<Event>>
{
    
}