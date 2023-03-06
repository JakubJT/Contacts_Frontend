using System.ComponentModel.DataAnnotations;

namespace Contacts_Frontend.Models;

public class Subcategory
{
    [Range(0, 100)]
    public int? SubcategoryId { get; set; }

    [Required]
    [StringLength(16, MinimumLength = 3)]
    public string? Name { get; set; }
    public bool IsDefaultSubcategory { get; set; } = false;

    [Required]
    public int CategoryId { get; set; }
}