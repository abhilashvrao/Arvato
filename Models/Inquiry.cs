using System.ComponentModel.DataAnnotations;
namespace CustomerSupport.Models;

public class Inquiry
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Phone { get; set; }
    public string Number { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public string Description { get; set; }

}