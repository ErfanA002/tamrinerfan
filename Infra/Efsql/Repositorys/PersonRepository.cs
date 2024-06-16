using tamrinerfan.Core.Domain.Entites.Person;
using tamrinerfan.Core.Domain.IRepositorys;
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

    public IEnumerable<Person> GetPersons(int numberpage, int pagesize)
    {
        try
        {
            var countData = _dbContext.Persons.Count();

            var Pagesize = pagesize;

            var totalpage = countData / Pagesize;

            var skip = (numberpage - 1) * Pagesize;

            var take = Math.Min(countData - skip, Pagesize);

            var pagination = _dbContext.Persons.Skip(skip).Take(take);

            return pagination;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;
        }
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
