﻿using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;
public record UserForRegistrationDto
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    [Required(ErrorMessage = "{0} is required.")]
    public string? UserName { get; init; }
    [Required(ErrorMessage = "{0} is required.")]
    public string? Password { get; init; }
    public string? Email { get; init; }
    public string? PhoneNumber { get; init; }
    public ICollection<string>? Roles { get; init; }

}
