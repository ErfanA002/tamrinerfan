﻿using System.ComponentModel.DataAnnotations;

namespace tamrinerfan.Core.Domain.Entites.Person;
public class Province
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    //public ICollection<City> Citys { get; set; }
}
