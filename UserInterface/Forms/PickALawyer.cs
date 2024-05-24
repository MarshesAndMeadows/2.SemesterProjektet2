using BusinessLogic.BusinessLogic;
using Controller;
using UIModels;

namespace UserInterface.Forms
{
    public partial class PickALawyer : Form
    {
        public event EventHandler<LawyerSelectedEventArgs> LawyerSelected;
        private List<UiLawyer> allLawyers = new List<UiLawyer>();
        public UiLawyer chosenLawyer;
        Form previousForm;
        Controllers controller;

        public PickALawyer(Form previousForm)
        {           
            InitializeComponent();
            controller = new Controllers();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            allLawyers = await controller.GetAllLawyersAsync();
            dgvLawyers.DataSource = allLawyers;
        }


        private void LoadEducationsToDataGridViewEducations()
        {
            dgvSpecialEducation.DataSource = chosenLawyer.Educations;
        }

        private void dgvLawyers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvLawyers.SelectedRows[0];
            this.chosenLawyer = (UiLawyer)selectedRow.DataBoundItem;
            LoadEducationsToDataGridViewEducations();
            if (dgvLawyers.SelectedColumns == null)
            {
                btnSelect.Enabled = false;
            }
        }

        private async void btnSelect_Click(object sender, EventArgs e)
        {
            UiLawyer chosenLawyer = GetSelectedLawyer();
            bool isValidSelection = await controller.ValidateLawyerSelectionAsync(chosenLawyer);
            if (isValidSelection)
            {
                OnLawyerSelected(chosenLawyer);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid lawyer selection.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private UiLawyer GetSelectedLawyer()
        {
            DataGridViewRow selectedRow = dgvLawyers.SelectedRows[0];
            this.chosenLawyer = (UiLawyer)selectedRow.DataBoundItem;
            return this.chosenLawyer;
        }

        protected virtual void OnLawyerSelected(UiLawyer selectedLawyer)
        {
            LawyerSelected?.Invoke(this, new LawyerSelectedEventArgs(selectedLawyer));
            // ".Invoke" kalder de metoder som abonnere på 'LawyerSelected' 
        }
    }
}
