using System.ComponentModel.DataAnnotations;

namespace Contacts_Frontend.Models;

public class Contact
{
    public int ContactId { get; set; }

    [Required]
    [StringLength(15, MinimumLength = 3)]
    public string? Name { get; set; }

    [Required]
    [StringLength(15, MinimumLength = 3)]
    public string? Surname { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(16)]
    public string? Email { get; set; }

    [StringLength(15, MinimumLength = 6)]
    [RegularExpression(@"(?=(.*\d)+)(?=(.*\W)+)(?=(.*[A-Z])+)(?=(.*[a-z])+)")]
    public string? Password { get; set; }

    [Phone]
    [StringLength(9, MinimumLength = 9)]
    public string? PhoneNumber { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public int CategoryId { get; set; }
    public Subcategory? Subcategory { get; set; }
}