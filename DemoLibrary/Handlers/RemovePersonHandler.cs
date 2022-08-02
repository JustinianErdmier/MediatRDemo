// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > RemovePersonHandler.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.Commands;
using DemoLibrary.DataAccess;

using MediatR;

namespace DemoLibrary.Handlers;

public class RemovePersonHandler : IRequestHandler<RemovePersonCommand, bool>
{
    private readonly IDataAccess _data;

    public RemovePersonHandler(IDataAccess data) => _data = data;

    /// <inheritdoc />
    public Task<bool> Handle(RemovePersonCommand request, CancellationToken cancellationToken) => Task.FromResult(_data.RemovePerson(request.Id));
}
