﻿using BusinessLogic.BusinessLogic;
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
        public event EventHandler<LawyerSelectedEventArgs> LawyerSelected;
        private List<UiLawyer> allLawyers = new List<UiLawyer>();
        public UiLawyer chosenLawyer;
        Form previousForm;
        LawyerBL bl;

        public PickALawyer(Form previousForm)
        {
            // GetLaywerList metode fra BusinessLogic
            bl = new LawyerBL();
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            allLawyers = await bl.GetAllAsync();
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            UiLawyer chosenLawyer = GetSelectedLawyer();
            OnLawyerSelected(chosenLawyer);
            this.Close();
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
        }
    }
}
