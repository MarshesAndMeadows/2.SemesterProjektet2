using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using Models;

namespace UserInterface.Forms.Helper
{
    public partial class HelpForm : Form
    {
        Form previousForm;

        public HelpForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12);
            this.Size = new Size(1400, 651);
            tableLayoutPanel1.Size = new Size(1353, 464);       
            richTextBox1.AutoSize = false;
        }

        public void SetHelpContent(string formName)
        {
            switch (formName)
            {
                case "LoginPage":
                    LoginPage();
                    break;
                case "LawyerCreateClient":
                    LawyerCreateClient();
                    break;
                case "LawyerSpecificCaseOverview":
                    LawyerSpecificCaseOverview();
                    break;
                case "LawyerAddService":
                    LawyerAddService();
                    break;
                case "LawyerOverview":
                    LawyerOverview();
                    break;
                case "LawyerCreateCase":
                    LawyerCreateCase();
                    break;
                default:
                    break;
            }
        }

        private void LawyerCreateCase()
        {
            richTextBox1.Text =
                       "Case name: Give the case a name \n" +
                              "Lawyer: Click button 'Click here' to add lawyer to handle the case\n" +
                              "Client: Which client the case primarily concernes with\n" +
                              "Description: Short description about the case\n" +
                              "Start date: Case start date\n" +
                              "End date: Case expected end date\n\n" +
                              "Client overview:\n" +
                              "Select client to add to case, or search after client\n\n" +
                              "To create case click 'Create'";

            MakeBold("Case name:");
            MakeBold("Lawyer:");
            MakeBold("Client:");
            MakeBold("Description:");
            MakeBold("Start date:");
            MakeBold("End date:");
            MakeBold("'Create'");
            MakeBold("Client overview:");

            var tempVideoFile5 = Path.GetTempFileName() + ".mp4";
            File.WriteAllBytes(tempVideoFile5, Properties.Resources.LawyerCreateCase);

            axWindowsMediaPlayer1.URL = tempVideoFile5;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void LawyerOverview()
        {
            richTextBox1.Text =
                        "Navigation bar left: \n" +
                               "Create Case: click to create a new case\n" +
                               "Create Client: click to add new client\n" +
                               "Select: When cell marked in gridview click 'Select' to view information \n\n" +
                               "Datagrid view:\n" +
                               "To search for a specific case, use search bar\n" +
                               "The overview shows cases default\n" +
                               "To switch between cases and clients, use drop-down menu on the left\n\n" +
                               "Return to Login page click 'Log out'";

            MakeBold("Navigation bar left:");
            MakeBold("Create Case:");
            MakeBold("Create Client:");
            MakeBold("Select:");
            MakeBold("Datagrid view");
            MakeBold("'Log out'");

            var tempVideoFile4 = Path.GetTempFileName() + ".mp4";
            File.WriteAllBytes(tempVideoFile4, Properties.Resources.LawyerOverview);

            axWindowsMediaPlayer1.URL = tempVideoFile4;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void LawyerAddService()
        {
            richTextBox1.Text =
                "Selected Service: Service type performed by lawyer\n" +
                       "Services Performed: Date service is performed\n" +
                       "Lawyer on service: Which lawyer is performing the service \n" +
                       "Unit cost: If service is hourly based \n" +
                       "Starting fee: Indicates what price service starts at\n" +
                       "Unit Count: Total hours of service\n" +
                       "Cost per unit: Hourly price for service:\n" +
                       "Note: Lawyer can add notes regarding the service performed\n\n" +
                       "To save and add the service\n" +
                       "Click 'Save'\n";

            MakeBold("Selected Service:");
            MakeBold("Services Performed:");
            MakeBold("Lawyer on service:");
            MakeBold("Unit cost:");
            MakeBold("Starting fee:");
            MakeBold("Cost per unit:");
            MakeBold("Unit Count:");
            MakeBold("Note:");
            MakeBold("'Save'");

            var tempVideoFile6 = Path.GetTempFileName() + ".mp4";
            File.WriteAllBytes(tempVideoFile6, Properties.Resources.LawyerAddService);

            axWindowsMediaPlayer1.URL = tempVideoFile6;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void LawyerSpecificCaseOverview()
        {
            richTextBox1.Text =
                       "Case: Udarbejdelse af kontrakt til salg af fast ejendom\n" +
                              "Lawyer: This is the Lawyer handeling the case \n" +
                              "Start date: This is the start date of the case \n" +
                              "Esitmated end date: This is the expected end date for the case \n" +
                              "Case closed: This indicates whetever case is closed or open\n" +
                              "To edit the case click 'Edit Case'\n\n" +
                              "Client info:\n" +
                              "Client name: Client firstname\n" +
                              "Lastname: Client lastname\n" +
                              "Birthdate: Client birthday\n" +
                              "Phone number: Client phone\n" +
                              "Address: Client address\n" +
                              "Zipcode: Client comune code\n" +
                              "Subscription: Whetever client is a subscriber or not\n" +
                              "To edit client click 'Edit Client'\n\n" +
                              "Services\n" +
                              "Overview of the services connected to the case \n" +
                              "To create client click 'Create client'\n\n" +
                               "To add a new service click 'Add new service'\n";

            MakeBold("Case: Udarbejdelse af kontrakt til salg af fast ejendom");
            MakeBold("Client info:");
            MakeBold("Services");
            MakeBold("'Edit Client'");
            MakeBold("'Create client'");
            MakeBold("'Edit Case'");
            MakeBold("'Add new service'");

            var tempVideoFile3 = Path.GetTempFileName() + ".mp4";
            File.WriteAllBytes(tempVideoFile3, Properties.Resources.LawyerSpecificCaseOverview);

            axWindowsMediaPlayer1.URL = tempVideoFile3;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void LawyerCreateClient()
        {
            richTextBox1.Text =
                     "First name: Insert client firstname.\n" +
                             "Last name: Insert client lastneme.\n" +
                             "Sex: Indicate client sex by inserting 'F' female or 'M' male\n" +
                             "Birthday: Choose client birthday, and Year\n" +
                             "Email: Insert client email\n" +
                             "Phone: Insert client phone\n" +
                             "Address: Insert client official address\n\n\n" +
                             "Subscribed: Select if client is subscriber or not\n\n\n" +
                             "If validation is OK 'Create client' button is shown\n\n" +
                             "To create client click 'Create client'";

            MakeBold("First name:");
            MakeBold("Last name:");
            MakeBold("Sex:");
            MakeBold("Birthday:");
            MakeBold("Email:");
            MakeBold("Phone:");
            MakeBold("Address:");
            MakeBold("Subscribed:");
            MakeBold("If validation is OK");
            MakeBold("To create client click");

            var tempVideoFile2 = Path.GetTempFileName() + ".mp4";
            File.WriteAllBytes(tempVideoFile2, Properties.Resources.LawyerCreateClient);

            axWindowsMediaPlayer1.URL = tempVideoFile2;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void LoginPage()
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10);
            richTextBox1.Text =
                        "Requirements Overall:\n" +
                        "Visual Studio 2022\n" +
                        "Microsoft SQL Server 2022\n" +
                        "Windows Media Player\n\n" +

                        "To setup help function:\n" +
                        "Install Windows Media Player in Windows 11:\n" +
                        "Start -> Indstillinger -> System -> \n" +
                        "Valgfrie Funktioner -> Windows Media Player\n\n" +
                        "A restart of computer might by necessary\n\n" +

                        "To setup database:\n" +
                        "Navigate to: DataAccess -> SqlDbContext.cs\n" +
                        "Insert your connection string in the method: OnConfiguring.\n" +
                        "Syntax connection string:\n" +
                        "\"Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;\"\n\n" +

                        "Now i Visual studio go to:\n" +
                        "View -> Other Windows -> Package Manager Console\n" +
                        "Insert following command:\n" +
                        "1. \"Add-Migration <name>\"\n" +
                        "2. \"Update-Database\"\n\n" +

                        "To populate database with data:\n" +
                        "Click: Reset Databasen\n\n\n" +
                        "From the development team, enjoy our App";

            MakeBold("Requirements Overall:");
            MakeBold("To setup help function:");
            MakeBold("To setup database:");
            MakeBold("To populate database with data:");

            var tempVideoFile1 = Path.GetTempFileName() + ".mp4";
            File.WriteAllBytes(tempVideoFile1, Properties.Resources.LoginPage);

            axWindowsMediaPlayer1.URL = tempVideoFile1;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void MakeBold(string text)
        {
            int start = richTextBox1.Find(text);
            if (start != -1)
            {
                int length = text.Length;
                richTextBox1.Select(start, length);
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
        
    }
}
