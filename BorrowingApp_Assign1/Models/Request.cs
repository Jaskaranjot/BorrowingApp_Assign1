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
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx.")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; } // Either "Student" or "Professor"

        [Required]
        public EquipmentType Equipment { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than 0.")]
        public int Duration { get; set; }

        public string Details { get; set; }
    }
}
