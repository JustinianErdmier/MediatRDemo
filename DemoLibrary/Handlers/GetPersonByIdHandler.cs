// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > GetPersonByIdHandler.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;

using MediatR;

namespace DemoLibrary.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
{
    private readonly IMediator _mediator;

    public GetPersonByIdHandler(IMediator mediator) => _mediator = mediator;

    public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        List<PersonModel> people = await _mediator.Send(new GetPersonListQuery(), cancellationToken);

        PersonModel? output = people.FirstOrDefault(person => person.Id == request.Id);

        if (output is null)
        {
            throw new Exception("Person Model is Null");
        }

        return output;
    }
}
