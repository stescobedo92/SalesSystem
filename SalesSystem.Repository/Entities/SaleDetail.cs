namespace SalesSystem.Repository.Entities;

public class SaleDetail
{
    public int SaleDetailId { get; set; }
    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal SalePrice { get; set; }
    public decimal TotalPrice { get; set; }
}
