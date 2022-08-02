// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > GetPersonListHandler.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;

using MediatR;

namespace DemoLibrary.Handlers;

public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
{
    private readonly IDataAccess _data;

    public GetPersonListHandler(IDataAccess data) => _data = data;

    /// <inheritdoc />
    public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken) => Task.FromResult(_data.GetPeople());
}
