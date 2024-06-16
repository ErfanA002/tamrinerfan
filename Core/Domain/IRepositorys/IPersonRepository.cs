using tamrinerfan.Core.Domain.Entites.Person;

namespace tamrinerfan.Core.Domain.IRepositorys;
public interface IPersonRepository
{
    public void CreatePerson(Person person);
    public List<Person> GetAllPersons();
    public Person GetPersonById(Guid id);
    public void UpdatePerson(Person person);
    public void DeletePerson(Guid id);
    public void saveChange();
}
