using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;

public record UserForAuthenticationDto
{
    [Required(ErrorMessage = "{0} is required.")]
    public string? UserName { get; init; }
    [Required(ErrorMessage = "{0} is required.")]
    public string? Password { get; init; }


}

