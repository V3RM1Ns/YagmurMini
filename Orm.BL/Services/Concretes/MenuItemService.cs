using Microsoft.EntityFrameworkCore;
using Orm.BL.Dtos.MenuItemDtos;
using Orm.BL.Profiles;
using Orm.BL.Services.Interfaces;
using Orm.Core.Entities;
using Orm.DAL.DataStorage.Contexts;
using Orm.DAL.Repositories.Interfaces;

namespace Orm.BL.Services.Concretes;

public class MenuItemService : IMenuItemService
{
    private readonly IRepository<MenuItem> _menuItemRepository;
    private readonly AppDbContex _context;
 
    public MenuItemService(AppDbContex context, IRepository<MenuItem> menuItemRepository)
    {
        _context = context;
        _menuItemRepository = menuItemRepository;
    }

    public async Task AddMenuItem(MenuItemCreateDto menuItemCreateDto)
    {
        MenuItem menuItem = MenuItemProfile.MenuItemCreateToMenuItem(menuItemCreateDto);
        await _menuItemRepository.AddAsync(menuItem);
    }

    public async Task EditMenuItem(MenuItemCreateDto menuItemCreateDto)
    {
        MenuItem menuItem = MenuItemProfile.MenuItemCreateToMenuItem(menuItemCreateDto);
        await _menuItemRepository.UpdateAsync(menuItem.Id);
    }

    public async Task DeleteMenuItem(MenuItem menuItem)
    {
        await _menuItemRepository.DeleteAsync(menuItem.Id);
        _context.SaveChanges();
    }

    public async Task<List<MenuItemReturnDto>> GetAllAsync()
    {
        var menuItems = await _menuItemRepository.GetAllAsync();
        return menuItems.Select(MenuItemProfile.MenuItemToMenuItemReturnDto).ToList();
    }

    public async Task<List<MenuItemReturnDto>> GetByCategory(Category category)
    {
        var menuItems = await _context.MenuItems.Where(x => x.Category == category).ToListAsync();
        return menuItems.Select(MenuItemProfile.MenuItemToMenuItemReturnDto).ToList();
    }

    public async Task<List<MenuItemReturnDto>> GetByPriceRange(decimal min, decimal max)
    {
       var menuItems = await _context.MenuItems.Where(x => x.Price >= min && x.Price <= max).ToListAsync();
       return menuItems.Select(MenuItemProfile.MenuItemToMenuItemReturnDto).ToList();
    }

    public async Task<List<MenuItemReturnDto>> SearchByName(string keyword)
    {
        var menuItems = await _context.MenuItems.Where(x => x.Name.Contains(keyword)).ToListAsync();
        return menuItems.Select(MenuItemProfile.MenuItemToMenuItemReturnDto).ToList();
    }

    public async Task<MenuItemReturnDto> GetById(int id)
    {
        var menuItem = await _menuItemRepository.GetByIdAsync(id);
        return menuItem != null ? MenuItemProfile.MenuItemToMenuItemReturnDto(menuItem) : null;
    }
}