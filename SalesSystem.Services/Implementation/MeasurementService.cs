using SalesSystem.Repository.Entities;
using SalesSystem.Repository.Interfaces;
using SalesSystem.Services.Interfaces;

namespace SalesSystem.Services.Implementation;

public class MeasurementService(IMeasurement measurementRepository) : IMeasurementService
{
    private readonly IMeasurement _measurementRepository = measurementRepository;

    public async Task<IEnumerable<Measurement>> GetAllAsync() => await _measurementRepository.GetMeasurements();
}
