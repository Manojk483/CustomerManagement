namespace CustomerAPI.Models;
public class BaseModel
{
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public DateTime UpdatedOn { get; set; } = DateTime.Now;
}
