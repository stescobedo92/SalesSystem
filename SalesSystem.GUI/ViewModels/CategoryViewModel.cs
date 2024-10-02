namespace SalesSystem.GUI.ViewModels;

public class CategoryViewModel
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int MeasurementId { get; set; }
    public string Measurement { get; set; } = string.Empty;
    public bool Active { get; set; } = true;
    public string Available { get; set; } = string.Empty;
}
