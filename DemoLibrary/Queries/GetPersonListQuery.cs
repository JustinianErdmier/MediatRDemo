// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > GetPersonListQuery.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.Models;

using MediatR;

namespace DemoLibrary.Queries;

public record GetPersonListQuery() : IRequest<List<PersonModel>>;
