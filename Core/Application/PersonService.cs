﻿using tamrinerfan.Controllers.DTOs;
using tamrinerfan.Core.Domain.Person.Person;
using tamrinerfan.Core.DomainServices;
using tamrinerfan.Core.IRepositorys;
namespace tamrinerfan.Core.Application;
public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public void CreatePerson(Person person)
    {
        _personRepository.CreatePerson(person);
        _personRepository.saveChange();
    }

    public List<Person> GetAllPersons()
    {
        return _personRepository.GetAllPersons();
    }

    public Person GetPersonById(Guid id)
    {
        return _personRepository.GetPersonById(id);
    }

    public void UpdatePerson(Person person)
    {
        _personRepository.UpdatePerson(person);
        _personRepository.saveChange();
    }

    public void DeletePerson(Guid id)
    {
        _personRepository.DeletePerson(id);
        _personRepository.saveChange();
    }
}