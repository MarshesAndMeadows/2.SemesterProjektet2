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

        }

        public void SetHelpContent(string formName)
        {
            // Label 1-2 må ikke benyttes det er hardcoded overskrift og beskrielse
            switch (formName)
            {
                case "LoginPage":
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
                    break;

                case "LawyerCreateClient":                  
                    richTextBox1.Text = "First name: Insert client firstname.\n" +
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
                    break;

                case "CustomerOverview":
                    label1.Text = "This is the Customer Overview form.";

                    break;

                default:
                    label1.Text = "No formName received, what's the name of the form?";
                    break;
            }
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
