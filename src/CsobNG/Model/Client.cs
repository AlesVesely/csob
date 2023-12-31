﻿namespace Model
{
    public class Client
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Email}";
        }
    }
 }
