﻿using Microsoft.AspNetCore.Mvc;
using tamrinerfan.Core.Domain.Person.Person;

namespace tamrinerfan.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    [HttpGet]
    public Person index()
    {
        var e = new Person();

        e.FirstName = "Test";

        e.LastName = "Test";

        return e;
    }
}