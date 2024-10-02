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
        this.dgvCategory.DataSource = await _categoryService.GetCategoriesAsync();
    }
}
