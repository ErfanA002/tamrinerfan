using Microsoft.EntityFrameworkCore;
using tamrinerfan.Core.Domain.Entites.Person;

namespace tamrinerfan.Core.Domain.IRepositorys;
public interface IPersonRepository
{
    public void CreatePerson(Person person);
    public IEnumerable<Person> GetPersons(int numberpage, int pagesize);
    public Person GetPersonById(Guid id);
    public void UpdatePerson(Person person);
    public void DeletePerson(Guid id);
    public void saveChange();
}
