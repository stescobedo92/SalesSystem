using Microsoft.Data.SqlClient;
using SalesSystem.Repository.DB;
using SalesSystem.Repository.Entities;
using SalesSystem.Repository.Interfaces;
using System.Data;

namespace SalesSystem.Repository.Implementation;

public class CategoryRepository : ICategory
{
    private readonly Connection _connection;

    public CategoryRepository(Connection connection) => _connection = connection;

    public async Task<IEnumerable<Category>> GetCategories(string search = "")
    {
        List<Category> categories = new();

        await using SqlConnection connection = _connection.GetConnection();
        await connection.OpenAsync();
        await using SqlCommand command = new SqlCommand("sp_listCategory", connection);
        command.Parameters.AddWithValue("@Search", search);
        command.CommandType = CommandType.StoredProcedure;
        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        while (reader.Read())
        {
            categories.Add(new Category()
            {
                CategoryId = reader.GetInt32(0),
                Name = reader.GetString(1),
                Active = reader.GetBoolean(2),
                MeasurementReference = new Measurement()
                {
                    MeasurementId = reader.GetInt32(3),
                    Name = reader.GetString(4)
                }
            });
        }

        return categories;
    }

    public async Task<string> InsertCategory(Category category)
    {
        string answer = string.Empty;

        await using SqlConnection connection = _connection.GetConnection();
        await connection.OpenAsync();
        await using SqlCommand command = new SqlCommand("sp_createCategory", connection);
        command.Parameters.AddWithValue("@Name", category.Name);
        command.Parameters.AddWithValue("@MeasurementId", category.MeasurementReference.MeasurementId);
        command.Parameters.Add("@ErrorMessage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        command.CommandType = CommandType.StoredProcedure;

        try
        {
            await command.ExecuteNonQueryAsync();
            answer = command.Parameters["@ErrorMessage"].Value?.ToString() ?? string.Empty;
        }
        catch
        {
            answer = "An error occurred while trying to insert a new category.";
        }

        return answer;
    }

    public async Task<string> UpdateCategory(Category category)
    {
        string answer = string.Empty;

        await using SqlConnection connection = _connection.GetConnection();
        await connection.OpenAsync();
        await using SqlCommand command = new SqlCommand("sp_createCategory", connection);
        command.Parameters.AddWithValue("@CategoryId", category.CategoryId);
        command.Parameters.AddWithValue("@Name", category.Name);
        command.Parameters.AddWithValue("@MeasurementId", category.MeasurementReference.MeasurementId);
        command.Parameters.AddWithValue("@Active", category.Active);
        command.Parameters.Add("@ErrorMessage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        command.CommandType = CommandType.StoredProcedure;

        try
        {
            await command.ExecuteNonQueryAsync();
            answer = command.Parameters["@ErrorMessage"].Value?.ToString() ?? string.Empty;
        }
        catch
        {
            answer = "An error occurred while trying to insert a new category.";
        }

        return answer;
    }
}