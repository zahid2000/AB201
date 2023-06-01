using System.ComponentModel.DataAnnotations;

namespace Bilet1.Models;

public class Post
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    [Required]
    [MaxLength(255)]
    public string Description { get; set; }
    public bool IsDeleted { get; set; } = default;
    [Required]
    public string ImagePath { get; set; }
}
