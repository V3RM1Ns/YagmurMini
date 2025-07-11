using Orm.Core.Entities.Common;

namespace Orm.Core.Entities;

public class Order:BaseEntity
{
    public int Count { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public int TableId { get; set; }
    public Table Table { get; set; }
}