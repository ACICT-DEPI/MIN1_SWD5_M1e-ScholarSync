﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ScholarSyncMVC.Models
{
    
    public class AppUser:IdentityUser
    {
        
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
        public string LastName { get; set; }

        
        public DateOnly? BirthDate { get; set; }

        
        [MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
        public string? Nationality { get; set; }

        
        [MaxLength(250, ErrorMessage = "Max 250 characters allowed.")]
        public string? Description { get; set; }

        public string? PhotoURL { get; set; }
        public string? FilePath { get; set; }


        [ForeignKey(nameof(Department))]
        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

    }
}
