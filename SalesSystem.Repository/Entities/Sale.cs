namespace SalesSystem.Repository.Entities;

public class Sale
{
    public int SaleId { get; set; }
    public string SaleNumber { get; set; } = string.Empty;
    public int UserId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public decimal TotalPrice { get; set; }
    public decimal? Payment { get; set; }
    public decimal? Change { get; set; }
    public DateTime RegistrationDate { get; set; } = DateTime.Now;
    public bool Active { get; set; } = true;
}
