// ---------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Justin Erdmier. All rights reserved.
// MediatRDemo > DemoLibrary > DemoDataAccess.cs
// Created: 02 08, 2022
// Modified: 02 08, 2022
// ---------------------------------------------------------------------------------------------------------------------------------

using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;

public class DemoDataAccess
    : IDataAccess
{
    private readonly List<PersonModel> _people = new ();

    public DemoDataAccess()
    {
        _people.Add(new PersonModel { Id = 1, FirstName = "Justin", LastName  = "Erdmier" });
        _people.Add(new PersonModel { Id = 2, FirstName = "Sabrina", LastName = "Butler" });
    }

    public List<PersonModel> GetPeople() => _people;

    public PersonModel InsertPerson(string firstName, string lastName)
    {
        var person = new PersonModel { Id = _people.Max(p => p.Id) + 1, FirstName = firstName, LastName = lastName };
        _people.Add(person);

        return person;
    }

    public bool RemovePerson(int id)
    {
        PersonModel? person = _people.FirstOrDefault(p => p.Id == id);

        return person is not null && _people.Remove(person);
    }
}
