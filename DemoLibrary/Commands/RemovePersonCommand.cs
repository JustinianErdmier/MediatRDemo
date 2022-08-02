// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > RemovePersonCommand.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using MediatR;

namespace DemoLibrary.Commands;

public record RemovePersonCommand(int Id) : IRequest<bool>;
