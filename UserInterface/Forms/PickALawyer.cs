using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UserInterface.Forms
{
    public partial class PickALawyer : Form
    {
        // Opret instans til BusinessLogic
        private List<UiLawyer> allLawyers = new List<UiLawyer>();
        private UiLawyer selectedLawyer;

        public PickALawyer()
        {
            // GetLaywerList metode fra BusinessLogic
            InitializeComponent();
            LoadLawyersToDataGridViewLawyer();
        }

        private void LoadLawyersToDataGridViewLawyer()
        {
            dgvLawyers.DataSource = allLawyers;
        }

        private void LoadEducationsToDataGridViewEducations()
        {
            dgvSpecialEducation.DataSource = selectedLawyer.Educations;
        }

        private void dgvLawyers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLawyers.SelectedRows.Count == 1)
            {   // Sikre at der er én markeret række. Derefter gemmes rækken og 'DataBoundItem' returner rækken som et objekt.
                DataGridViewRow selectedRow = dgvLawyers.SelectedRows[0];
                selectedLawyer = (UiLawyer)selectedRow.DataBoundItem;
                LoadEducationsToDataGridViewEducations();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Det valgte lawyer objekt til returnes til den tidligere form
            // Denne knap skal kun være aktiv hvis der en række fra 'dgvLaywers' som er markeret.
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
