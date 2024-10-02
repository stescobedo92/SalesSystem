namespace SalesSystem.Repository.Entities;

public class Measurement
{
    public int MeasurementId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Abbreviation { get; set; } = string.Empty;
    public string Equivalent { get; set; } = string.Empty;
    public int Value { get; set; }
}
