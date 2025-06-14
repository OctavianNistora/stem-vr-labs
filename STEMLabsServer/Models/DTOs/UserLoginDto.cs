﻿namespace STEMLabsServer.Models.DTOs;

public class UserLoginDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public bool RespondWithRefreshToken { get; set; } = false;
}