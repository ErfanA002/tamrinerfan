using Microsoft.EntityFrameworkCore;
using tamrinerfan.Core.Domain.Entites.Person;
using tamrinerfan.Core.Domain.IRepositorys;
using tamrinerfan.Core.Domain.IServices;

namespace tamrinerfan.Core.Application.Services;
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

    public IEnumerable<Person> GetPersons(int numberpage, int pagesize)
    {
        return _personRepository.GetPersons(numberpage,pagesize);
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