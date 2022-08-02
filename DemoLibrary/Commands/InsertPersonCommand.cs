// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > InsertPersonCommand.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.Models;

using MediatR;

namespace DemoLibrary.Commands;

public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
