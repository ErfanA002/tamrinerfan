using System.ComponentModel.DataAnnotations;
using tamrinerfan.Core.Domain.Person.Person;

namespace tamrinerfan.Core.Domain.Person;
public class Province
{
    [Key]
    public Guid Id { get; set; }
    public ICollection<City> Citys { get; set; }
}
