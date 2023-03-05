using System.ComponentModel.DataAnnotations;

namespace Contacts_Frontend.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required]
    public string? Name { get; set; }
    public bool IsAddingSubcategoryPossible { get; set; } = false;
}