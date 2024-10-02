using SalesSystem.Services.Interfaces;

namespace SalesSystem.GUI
{
    public partial class Form1 : Form
    {
        private readonly IMeasurementService _measurementService;

        public Form1(IMeasurementService measurementService)
        {
            InitializeComponent();
            _measurementService = measurementService;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var measurements = await _measurementService.GetAllAsync();
        }
    }
}
