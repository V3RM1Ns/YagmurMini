using Orm.BL.Dtos.OrderDtos;
using Orm.BL.Dtos.OrderItemDtos;
using Orm.Core.Entities;

namespace Orm.BL.Services.Interfaces;


public interface IOrderService
{
    Task AddOrder(OrderCreateDto orderCreateDto);
    Task UpdateOrder(OrderCreateDto orderCreateDto);
    Task DeleteOrder(Order order); 
    Task<List<OrderReturnDto>> GetByPriceRange(decimal min, decimal max);
    Task<List<OrderReturnDto>> GetByDateRange(DateTime min, DateTime max); 
    Task<OrderReturnDto> GetById(int id);
    Task<List<OrderReturnDto>> GetAllOrdersAsync(); 
}