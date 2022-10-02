namespace Tiraet1.Data;

public class BaseEntity
{
    public long ID { get; set; }
    public DateTime AddedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string IPAddress { get;set; }
}