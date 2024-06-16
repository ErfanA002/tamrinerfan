using Microsoft.AspNetCore.Mvc;
using tamrinerfan.Controllers.DTOs;
using tamrinerfan.Core.Domain.Entites.Person;
using tamrinerfan.Core.Domain.IServices;

namespace tamrinerfan.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet("GetPersonById/{personId}")]
    public Person GetPersonById(Guid personId)
    {
        return _personService.GetPersonById(personId);
    }

    [HttpGet("GetAllPersons/{numberpage}/{pagesize}")]
    public IEnumerable<Person> GetAllPersons(int numberpage,int pagesize)
    {
        var data = _personService.GetAllPersons();

        var countData = data.Count();

        var Pagesize = pagesize;
        
        var totalpage = countData / Pagesize;

        var skip = (numberpage - 1) * Pagesize;
        
        var take = Math.Min(countData - skip, Pagesize);

        var pagination = data.Skip(skip).Take(take);

        return pagination;
    }
    
    [HttpPost("CreatePerson")]
    public void CreatePerson([FromForm]PersonDTO personDTO)
    {
        Person person = new Person()
        {
            FirstName = personDTO.FirstName,
            LastName = personDTO.LastName,
            Address = personDTO.Address,
        };
        
        _personService.CreatePerson(person);
    }
    
    [HttpDelete("Person/{id}")]
    public void DeletePerson(Guid id)
    {
        _personService.DeletePerson(id);
    }
    
    [HttpPut("UpdatePerson")]
    public void UpdatePerson(Person p)
    {
        _personService.UpdatePerson(p);
    }
}
