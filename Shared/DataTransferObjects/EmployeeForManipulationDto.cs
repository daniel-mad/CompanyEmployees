using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;

public record EmployeeForManipulationDto
{
    [Required(ErrorMessage = "Employee {0} is required.")]
    [MaxLength(30, ErrorMessage = "Maximum length for Name is {1} characters.")]
    public string? Name { get; init; }
    [Range(18, int.MaxValue, ErrorMessage = "Age is required and it can't be lower then {1}.")]
    public int Age { get; init; }
    [Required(ErrorMessage = "Employee {0} is required.")]
    [MaxLength(20, ErrorMessage = "Maximum length for Position is {1} characters.")]
    public string? Position { get; init; }
}


