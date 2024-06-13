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
    }

    public List<Person> GetAllPersons()
    {
        return _personRepository.GetAllPersons();
    }

    public Person GetPersonById(Guid id)
    {
        return _personRepository.GetPersonById(id);
    }

    public void UpdatePerson(Person person, Guid id)
    {
        _personRepository.UpdatePerson(person,id);
    }

    public void DeletePerson(Guid id)
    {
        _personRepository.DeletePerson(id);
    }
}