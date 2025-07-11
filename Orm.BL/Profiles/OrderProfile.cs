using Orm.BL.Dtos.OrderDtos;
using Orm.BL.Dtos.OrderItemDtos;
using Orm.Core.Entities;

namespace Orm.BL.Profiles;

public class OrderProfile
{
    public static Order OrderCreateToOrder(OrderCreateDto orderCreateDto)
    {
        var order = new Order
        {
            OrderDate = orderCreateDto.OrderDate,
            OrderItems = new List<OrderItem>()
        };

        // Map OrderItems
        foreach (var itemDto in orderCreateDto.OrderItems)
        {
            order.OrderItems.Add(new OrderItem
            {
                MenuItemId = itemDto.MenuItemId,
                Quantity = itemDto.Quantity,
            });
        }
        return order;
    }

    public static OrderReturnDto OrderToOrderReturnDto(Order order)
    {
        return new OrderReturnDto
        {
            Id = order.Id,
            OrderDate = order.OrderDate,
            
            TotalOrderCount = order.OrderItems?.Count ?? 0,
            TotalOrderPrice = order.OrderItems?.Sum(oi => oi.TotalAmount) ?? 0,
            OrderItems = order.OrderItems?
                .Select(oi => OrderItemToOrderItemReturnDto(oi))
                .ToList() ?? new List<OrderItemReturnDto>()
        };
    }

    public static OrderItemReturnDto OrderItemToOrderItemReturnDto(OrderItem orderItem)
    {
        return new OrderItemReturnDto
        {
            Id = orderItem.Id,
            MenuItemId = orderItem.MenuItemId,
            MenuItemName = orderItem.MenuItem?.Name,
            Quantity = orderItem.Quantity,
            TotalAmount = orderItem.TotalAmount
        };
    }
}