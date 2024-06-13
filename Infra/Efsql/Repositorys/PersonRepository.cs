using tamrinerfan.Core.Domain.Person.Person;
using tamrinerfan.Core.IRepositorys;
using tamrinerfan.Infra.Context;
namespace tamrinerfan.Infra.Efsql.Repositorys;
public class PersonRepository : IPersonRepository
{
    private readonly TamrinErfanDbContext _dbContext;

    public PersonRepository(TamrinErfanDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreatePerson(Person person)
    {
        _dbContext.Persons.Add(person);
    }

    public List<Person> GetAllPersons()
    {
        return _dbContext.Persons.ToList();
    }

    public Person GetPersonById(Guid id)
    {
        var res = _dbContext.Persons.Single(x => x.Id == id);
        return res;
    }

    public void UpdatePerson(Person person)
    {
        _dbContext.Persons.Update(person);
    }

    public void DeletePerson(Guid id)
    {
        Person myperson = _dbContext.Persons.Single(x => x.Id == id);
        _dbContext.Persons.Remove(myperson);
    }

    public void saveChange()
    {
        _dbContext.SaveChanges();
    }
}
