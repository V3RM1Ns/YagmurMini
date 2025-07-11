namespace Orm.BL.Dtos.OrderDtos;

public class OrderItemReturnDto
{
    public int Id { get; set; }
    public int MenuItemId { get; set; }
    public string MenuItemName { get; set; }
    public int Quantity { get; set; }
    public int TotalAmount { get; set; }
}