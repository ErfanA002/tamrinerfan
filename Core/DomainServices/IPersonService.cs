using tamrinerfan.Core.Domain.Person.Person;
namespace tamrinerfan.Core.DomainServices;
public interface IPersonService
{
    public void CreatePerson(Person person);
    public List<Person> GetAllPersons();
    public Person GetPersonById(Guid id);
    public void UpdatePerson(Person person, Guid id);
    public void DeletePerson(Guid id);
}