using SalesSystem.GUI.ViewModels;
using SalesSystem.Services.Interfaces;

namespace SalesSystem.GUI.Forms;

public partial class frmCatgory : Form
{
    private readonly IMeasurementService _measurementService;
    private readonly ICategoryService _categoryService;

    public frmCatgory(IMeasurementService measurementService, ICategoryService categoryService)
    {
        InitializeComponent();
        _measurementService = measurementService;
        _categoryService = categoryService;
    }

    private async void frmCatgory_Load(object sender, EventArgs e)
    {
        await ShowCategories(dgvCategory, string.Empty);
    }

    private async Task ShowCategories(DataGridView dgCategory, string search)
    {
        dgCategory.DataSource = await GetCategories(search);

        ShowOrHideClumn(dgCategory, "CategoryId");
        ShowOrHideClumn(dgCategory, "MeasurementId");
        ShowOrHideClumn(dgCategory, "Active");
    }

    private async Task<List<CategoryViewModel>> GetCategories(string search) => (await _categoryService.GetCategoriesAsync(search)).ToList().Select(items => new CategoryViewModel()
    {
        CategoryId = items.CategoryId,
        Name = items.Name,
        MeasurementId = items.MeasurementReference.MeasurementId,
        Measurement = items.MeasurementReference.Name,
        Active = items.Active,
        Available = items.Active ? "Yes" : "No"
    }).ToList();

    private void ShowOrHideClumn(DataGridView dgCategory, string columnToHide, string hideOrShow = "") => dgCategory.Columns[columnToHide].Visible = hideOrShow.Equals("show");
}
