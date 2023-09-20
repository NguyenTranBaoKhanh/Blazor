using Share.Enums;

namespace Share;
public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
    public Priority Priority { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}
