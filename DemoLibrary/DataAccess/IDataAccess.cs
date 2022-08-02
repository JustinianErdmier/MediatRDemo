// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > IDataAccess.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;

public interface IDataAccess
{
    List<PersonModel> GetPeople();

    PersonModel InsertPerson(string firstName, string lastName);

    bool RemovePerson(int id);
}
