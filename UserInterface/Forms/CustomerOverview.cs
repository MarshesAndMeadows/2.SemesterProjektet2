﻿using BusinessLogic.BusinessLogic;
using Controller;
using UIModels;
using BusinessLogic;
namespace UserInterface.Forms
{
    public partial class CustomerOverview : Form
    {
        Form previousForm;    
        UiCase selectedCase;
        UiClient currentClient;
        Controllers controller;

        public CustomerOverview(UiClient currentClient, Form previousForm)
        {
            InitializeComponent();          
            this.currentClient = currentClient;
            this.previousForm = previousForm;      
            selectedCase = new UiCase();
            controller = new Controllers();
            InitializeDataAsync();
        }
        async void InitializeDataAsync()
        {
            List<UiCase> userCases = await controller.GetAllCasesAsync();
            dgvCases.DataSource = userCases;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            CustomerSpecificCases specificCaseOverview = new CustomerSpecificCases(this, selectedCase);
            this.Hide();
            specificCaseOverview.Show();
        }

        private void dgvCases_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvCases.SelectedRows[0];
            selectedCase = (UiCase)selectedRow.DataBoundItem;
        }
    }
}
