using System.ComponentModel.DataAnnotations;

namespace tamrinerfan.Domain;
public class City
{
    [Key]
    public Guid Id { get; set; }
    public string NameCity { get; set; }
    public Province Province { get; set; }
}
