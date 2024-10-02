using SalesSystem.Repository.Entities;
using SalesSystem.Repository.Interfaces;
using SalesSystem.Services.Interfaces;

namespace SalesSystem.Services.Implementation;

public class CategoryService(ICategory categoryRepository) : ICategoryService
{
    private readonly ICategory _categoryRepository = categoryRepository;

    public async Task<IEnumerable<Category>> GetCategoriesAsync(string search = "") => await _categoryRepository.GetCategories(search);

    public async Task<string> CreateCategoryAsync(Category category) => await _categoryRepository.InsertCategory(category);

    public async Task<string> UpdateCategoryAsync(Category category) => await _categoryRepository.UpdateCategory(category);
}
