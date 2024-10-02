namespace SalesSystem.Repository.Entities;

public class Business
{
    public int BusinessId { get; set; }
    public string BusinessName { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string CurrencySymbol { get; set; } = string.Empty;
    public string LogoName { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
}
