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

        var btnUpdateCategories = new DataGridViewButtonColumn()
        {
            Text = "Update",
            Name = "btnUpdateCategories",
            HeaderText = string.Empty,
            UseColumnTextForButtonValue = true,
            Width = 50,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        };

        dgvCategory.Columns.Add(btnUpdateCategories);

        dgvCategory.AllowUserToAddRows = false;
        dgvCategory.AllowUserToDeleteRows = false;
        dgvCategory.AllowUserToResizeColumns = false;
        dgvCategory.AllowUserToResizeRows = false;
        dgvCategory.AllowUserToOrderColumns = false;
        dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCategory.MultiSelect = false;
        dgvCategory.RowHeadersVisible = false;
        dgvCategory.ReadOnly = true;
        dgvCategory.BackgroundColor = Color.White;
        dgvCategory.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
        {
            BackColor = Color.FromArgb(58, 49, 69),
            SelectionBackColor = Color.FromArgb(58, 49, 69),
            ForeColor = Color.FromArgb(255, 255, 255),
        };
        dgvCategory.DefaultCellStyle = new DataGridViewCellStyle()
        {
            SelectionBackColor = Color.FromArgb(191, 176, 209),
            SelectionForeColor = Color.FromArgb(0, 0, 0)
        };
        dgvCategory.ColumnHeadersHeight = 30;
        dgvCategory.EnableHeadersVisualStyles = false;
        dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
