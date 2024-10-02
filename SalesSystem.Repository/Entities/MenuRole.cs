namespace SalesSystem.Repository.Entities;

public class MenuRole
{
    public int MenuRoleId { get; set; }
    public int MenuId { get; set; }
    public int RoleId { get; set; }
    public bool Active { get; set; } = true;
}
