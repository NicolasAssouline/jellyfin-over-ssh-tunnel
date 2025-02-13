﻿namespace Jellyfin.Api.Models.UserDtos;

/// <summary>
/// The create user by name request body.
/// </summary>
public class CreateUserByName
{
    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    public string? Password { get; set; }
}
