using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerSpecificCases : Form
    {
        Form previousForm;
        UiCase selectedCase;
        public CustomerSpecificCases(Form previousForm, UiCase uiCase)
        {

            this.selectedCase = uiCase;
            this.previousForm = previousForm;
            InitializeComponent();
        }
    }
}
