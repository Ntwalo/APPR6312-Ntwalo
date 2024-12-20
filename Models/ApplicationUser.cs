﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Ntwalo_APPR6312.Models
{
    public class ApplicationUser
    {
        [Key]
        public int UserId { get; set; }

        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }
    }
}
