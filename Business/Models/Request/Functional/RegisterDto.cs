﻿using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Functional;

public class RegisterDto
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public UserType UserType { get; set; }
    public string CategoryName { get; set; } = default!;
}