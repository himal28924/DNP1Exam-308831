using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public class X
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(15)]
    public string FirstName { get; set; }
    [Required,MaxLength(15)]
    public string LastName { get; set; }
}