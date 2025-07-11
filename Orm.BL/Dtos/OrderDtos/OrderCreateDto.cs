using Orm.BL.Dtos.OrderItemDtos;

namespace Orm.BL.Dtos.OrderDtos;

public class OrderCreateDto
{
    public DateTime OrderDate { get; set; }
    public List<OrderItemCreateDto> OrderItems { get; set; } 
}