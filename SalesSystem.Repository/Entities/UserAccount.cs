namespace SalesSystem.Repository.Entities;

public class UserAccount
{
    public int UserId { get; set; }
    public int RoleId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool ResetPassword { get; set; } = true;
    public bool Active { get; set; } = true;
}