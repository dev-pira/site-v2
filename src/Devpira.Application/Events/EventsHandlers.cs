using Devpira.Application.Events.Commands;
using Devpira.Application.Events.Queries;
using Devpira.Domain.Events;

using MediatR;

namespace Devpira.Application.Events;

public class EventsHandlers :
    IRequestHandler<CreateEventCommand, Event>,
    IRequestHandler<UpdateEventCommand>,
    IRequestHandler<DeleteEventCommand>,
    IRequestHandler<GetEventByIdQuery, Event?>,
    IRequestHandler<FetchEventsQuery, IEnumerable<Event>>
{
    public Task<Event> Handle(CreateEventCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Handle(UpdateEventCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Handle(DeleteEventCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Event?> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Event>> Handle(FetchEventsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}