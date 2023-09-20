using System.ComponentModel.DataAnnotations;
using Share.Enums;

namespace Share;
public class CategoryCreate
{
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(1, 15, ErrorMessage = "Can only be between 0 .. 15")]
    public int DisplayOrder { get; set; }

    [Required]
    public Priority? Priority { get; set; }
}
