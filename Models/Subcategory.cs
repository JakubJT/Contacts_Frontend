using System.ComponentModel.DataAnnotations;

namespace Contacts_Frontend.Models;

public class Subcategory
{
    public int SubcategoryId { get; set; }
    public string? Name { get; set; }
    public int CategoryId { get; set; }
}