using Orm.BL.Dtos.MenuItemDtos;
using Orm.Core.Entities;

namespace Orm.BL.Services.Interfaces;

public interface IMenuItemService
{
    Task AddMenuItem(MenuItemCreateDto menuItemCreateDto);
    Task EditMenuItem(MenuItemCreateDto menuItemCreateDto);
    Task DeleteMenuItem(MenuItem menuItem);
    Task<List<MenuItemReturnDto>> GetAllAsync(); 
    Task<List<MenuItemReturnDto>> GetByCategory(Category category);
    Task<List<MenuItemReturnDto>> GetByPriceRange(decimal min, decimal max);
    Task<List<MenuItemReturnDto>> SearchByName(string keyword); 
    Task<MenuItemReturnDto> GetById(int id); 
}