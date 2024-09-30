using System;
using System.ComponentModel.DataAnnotations;

namespace BorrowingApp_Assign1.Models
{
    public enum EquipmentType
    {
        Laptop,
        Phone,
        Tablet,
        Other
    }

    public class Request
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; } // Student or Professor

        [Required]
        public EquipmentType Equipment { get; set; }

        [Required]
        [Range(1, 365, ErrorMessage = "Duration must be between 1 and 365 days.")]
        public int Duration { get; set; }

        public string Details { get; set; }
    }
}
