﻿namespace TokenManager.Domain.Entities
{
    public class User
    {
        public string? Id { get; set; }
        public bool Enabled { get; set; }
        public bool EmailVerified { get; set; }
        public string? Username { get; set; } = null!;
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Totp { get; set; }
        public List<string> DisableableCredentialTypes { get; set; } = [];
        public List<string> RequiredActions { get; set; } = [];
        public int NotBefore { get; set; }
        public long CreatedTimestamp { get; set; }
        public Access? Access { get; set; }
        public Attributes? Attributes { get; set; }

        public User()
        {
                
        }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        public User(string userName, string email, string firstName, string lastName, Attributes attributes)
        {
            Enabled = true;
            EmailVerified = false;            
            Email = email;
            FirstName = firstName;
            Username = userName;
            LastName = lastName;
            Attributes = attributes;
        }
    }
}
