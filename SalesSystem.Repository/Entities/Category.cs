namespace SalesSystem.Repository.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int MeasurementId { get; set; }
    public Measurement MeasurementReference { get; set; } = new Measurement();
    public bool Active { get; set; } = true;
}
