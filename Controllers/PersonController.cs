using Microsoft.AspNetCore.Mvc;
using tamrinerfan.Controllers.DTOs;
using tamrinerfan.Core.Domain.Person.Person;
using tamrinerfan.Core.DomainServices;
namespace tamrinerfan.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    private PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet("Home")]
    public string Home()
    {
        return "salam erfan";
    }

    [HttpGet("GetPersonById/{personId}")]
    public Person GetPersonById(Guid personId)
    {
        return _personService.GetPersonById(personId);
    }

    [HttpGet("GetAllPersons")]
    public List<Person> GetAllPersons()
    {
        return _personService.GetAllPersons();
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
    
    [HttpPut("UpdatePerson/{id}")]
    public void UpdatePerson(Person person, Guid id)
    {
        _personService.UpdatePerson(person,id);
    }
}
