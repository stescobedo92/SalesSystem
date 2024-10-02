using System.Data;
using Microsoft.Data.SqlClient;
using SalesSystem.Repository.DB;
using SalesSystem.Repository.Entities;
using SalesSystem.Repository.Interfaces;

namespace SalesSystem.Repository.Implementation;

public class MeasurementRepository : IMeasurement
{
    private readonly Connection _connection;

    public MeasurementRepository(Connection connection) => _connection = connection;

    public async Task<IEnumerable<Measurement>> GetMeasurements()
    {
        List<Measurement> measurements = new();

        await using SqlConnection connection = _connection.GetConnection();
        await connection.OpenAsync();
        await using SqlCommand command = new SqlCommand("sp_listMeasurement");
        command.CommandType = CommandType.StoredProcedure;
        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        while (reader.Read())
        {
            measurements.Add(new Measurement()
            {
                MeasurementId = reader.GetInt32(0),
                Name = reader.GetString(1),
                Abbreviation = reader.GetString(2),
                Equivalent = reader.GetString(3),
                Value = reader.GetInt32(4)
            });
        }

        return measurements;
    }
}
