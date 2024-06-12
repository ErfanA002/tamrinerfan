using tamrinerfan.Core.Domain.Person.Person;
using tamrinerfan.Core.DomainServices;
using tamrinerfan.Core.IRepositorys;
namespace tamrinerfan.Core.Application;
public class PersonService : IPersonService
{
    private IPersonRepository personRepository;
    public void CreatePerson(Person person)
    {
        personRepository.CreatePerson(person);
    }

    public List<Person> GetAllPersons()
    {
        return personRepository.GetAllPersons();
    }

    public Person GetPersonById(Guid id)
    {
        return personRepository.GetPersonById(id);
    }

    public void UpdatePerson(Person person, Guid id)
    {
        personRepository.UpdatePerson(person,id);
    }

    public void DeletePerson(Guid id)
    {
        personRepository.DeletePerson(id);
    }
}