using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Employee
{
    [Column("EmployeeId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Employee {0} is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximun length for {0} is {1} characters. ")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Employee {0} is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximun length for {0} is {1} characters. ")]
    public string? Position { get; set; }

    [ForeignKey(nameof(Company))]
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
}