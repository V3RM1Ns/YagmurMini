using Orm.BL.Dtos.OrderDtos;

namespace Orm.BL.Dtos.OrderItemDtos;

public class OrderReturnDto
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public int TotalOrderCount { get; set; } // Derived from OrderItems.Count
    public decimal TotalOrderPrice { get; set; } // Calculated from OrderItems
    public List<OrderItemReturnDto> OrderItems { get; set; }
}