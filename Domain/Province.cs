using System.ComponentModel.DataAnnotations;

namespace tamrinerfan.Domain;
public class Province
{
    [Key]
    public Guid Id { get; set; }
    public ICollection<City> Citys { get; set; }
}
