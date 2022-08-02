// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > InsertPersonHandler.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;

using MediatR;

namespace DemoLibrary.Handlers;

public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
{
    private readonly IDataAccess _data;

    public InsertPersonHandler(IDataAccess data) => _data = data;

    public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken) => Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
}
