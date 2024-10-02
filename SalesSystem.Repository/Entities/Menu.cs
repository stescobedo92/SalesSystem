namespace SalesSystem.Repository.Entities;
public class Menu
{
    public int MenuId { get; set; }
    public string MenuName { get; set; } = string.Empty;
    public int ParentMenuId { get; set; } = 0;
}
