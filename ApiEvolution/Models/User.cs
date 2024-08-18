﻿using System.ComponentModel.DataAnnotations;

namespace ApiEvolution.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Role { get; set; }
    }
}