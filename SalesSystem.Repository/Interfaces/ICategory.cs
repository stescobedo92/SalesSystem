using SalesSystem.Repository.Entities;

namespace SalesSystem.Repository.Interfaces;

public interface ICategory
{
    Task<IEnumerable<Category>> GetCategories(string search = "");
    Task<string> InsertCategory(Category category);
    Task<string> UpdateCategory(Category category);
}
