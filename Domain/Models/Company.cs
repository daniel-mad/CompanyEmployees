using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;
public class Company
{
    [Column("CompanyId")]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Company {0} is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for {0} is {1} characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Company {0} is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for {0} is {1} characters.")]
    public string? Address { get; set; }

    public string? Country { get; set; }
    public ICollection<Employee>? Employees { get; set; }
}
