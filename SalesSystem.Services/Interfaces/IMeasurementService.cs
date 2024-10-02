using SalesSystem.Repository.Entities;

namespace SalesSystem.Services.Interfaces;

public interface IMeasurementService
{
    Task<IEnumerable<Measurement>> GetAllAsync();
}