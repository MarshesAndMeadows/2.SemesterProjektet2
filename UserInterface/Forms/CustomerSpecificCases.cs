using BusinessLogic.BusinessLogic;
using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerSpecificCases : Form
    {
        Form previousForm;
        UiCase selectedCase;
        List<UiAppliedService> appliedServices;
        AppliedServiceBL bl;
        public CustomerSpecificCases(Form previousForm, UiCase selectedCase)
        {
            bl = new AppliedServiceBL();
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

        private async void TextboxFiller()
        {
            lblCaseName.Text = selectedCase.CaseName.ToString();
            lblCaseDescription.Text = selectedCase.CaseDescription.ToString();
            checkboxCasedClosed.Checked = selectedCase.CaseClosed;
            lblLawyerName.Text = $"{selectedCase.Employee.Firstname} {selectedCase.Employee.Lastname}";
            dtpStart.Value = selectedCase.StartDate;
            dtpEnd.Value = selectedCase.EstimatedEndDate;
            appliedServices = new List<UiAppliedService>();
            foreach (UiAppliedService service in selectedCase.AppliedServices)
            {
                appliedServices.Add(await bl.GetOneAsync(service.Id));
            }
            dgvAppServices.DataSource = appliedServices;
        }
    }
}