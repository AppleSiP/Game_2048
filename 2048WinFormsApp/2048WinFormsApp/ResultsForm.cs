
namespace _2048WinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = ResultManager.GetAll(DataProvider.Results);
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.Score, result.Status);
            }
        }
    }
}
