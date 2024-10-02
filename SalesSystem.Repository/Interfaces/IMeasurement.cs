using SalesSystem.Repository.Entities;

namespace SalesSystem.Repository.Interfaces;

public interface IMeasurement
{
    Task<IEnumerable<Measurement>> GetMeasurements();
}
