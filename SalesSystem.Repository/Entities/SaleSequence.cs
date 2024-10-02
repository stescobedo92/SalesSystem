namespace SalesSystem.Repository.Entities;

public class SaleSequence
{
    public string Series { get; set; } = string.Empty;
    public int Number { get; set; }
    public bool Active { get; set; } = true;
}
