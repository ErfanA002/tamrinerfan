namespace tamrinerfan.Core.Domain.IRepositorys;
public interface IPersonRepository
{
    public void CreatePerson(Person.Person.Person person);
    public List<Person.Person.Person> GetAllPersons();
    public Person.Person.Person GetPersonById(Guid id);
    public void UpdatePerson(Person.Person.Person person);
    public void DeletePerson(Guid id);
    public void saveChange();
}
