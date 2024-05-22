using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerSpecificCases : Form
    {
        Form previousForm;
        UiCase selectedCase;
        public CustomerSpecificCases(Form previousForm, UiCase selectedCase)
        {

            this.selectedCase = selectedCase;
            this.previousForm = previousForm;
            InitializeComponent();
            TextboxFiller();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void TextboxFiller()
        {
            lblCaseName.Text = selectedCase.CaseName.ToString();
            lblCaseDescription.Text = selectedCase.CaseDescription.ToString();
            checkboxCasedClosed.Checked = selectedCase.CaseClosed;
        }
    }
}
