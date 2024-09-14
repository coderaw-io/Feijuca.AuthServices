﻿using Newtonsoft.Json;

namespace TokenManager.Application.Requests.User
{
    public record AddUserRequest(string Username, string Password, string Email, string FirstName, string LastName, Dictionary<string, string> Attributes);
}
