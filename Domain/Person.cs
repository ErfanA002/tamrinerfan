using System.ComponentModel.DataAnnotations;

namespace tamrinerfan.Domain;
public class Person
{
    [Key]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<int> Phones { get; set; }
    public Province Province { get; set; }
}
