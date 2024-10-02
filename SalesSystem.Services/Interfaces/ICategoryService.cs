using SalesSystem.Repository.Entities;

namespace SalesSystem.Services.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetCategoriesAsync(string search = "");
    Task<string> CreateCategoryAsync(Category category);
    Task<string> UpdateCategoryAsync(Category category);
}
