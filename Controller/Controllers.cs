﻿using BusinessLogic;
using BusinessLogic.BusinessLogic;
using Models;
using UIModels;
using System.Threading.Tasks;

namespace Controller
{
    public class Controllers
    {
        ClientBL clientBL;
        BusinessLogic.Validation validator;
        LawyerBL lawyerBL;
        AppliedServiceBL appliedServiceBL;
        CaseBL caseBL;
        ServiceBL serviceBL;
        LoanCalculator loanCalculator;

        public Controllers()
        {
            clientBL = new ClientBL();
            validator = new BusinessLogic.Validation();
            lawyerBL = new LawyerBL();
            appliedServiceBL = new AppliedServiceBL();
            caseBL = new CaseBL();
            serviceBL = new ServiceBL();
            loanCalculator = new LoanCalculator();
        }

        // --------------------- LawyerCreateClient ---------------------
        public async Task<bool> CreateClientAsync(UIModels.UiClient client)
        {
            return await clientBL.CreateAsync(client);
        }

        // --------------------- Validation ---------------------
        public async Task<bool> ValidateFirstNameAsync(string firstName)
        {
            if (!string.IsNullOrEmpty(firstName))
            {
                return await validator.ValidateUserInputAsync("name", firstName);
            }
            return false;
        }

        public async Task<bool> ValidateLastNameAsync(string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                return await validator.ValidateUserInputAsync("name", lastName);
            }
            return false;
        }

        public async Task<bool> ValidateEmailAsync(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                return await validator.ValidateUserInputAsync("email", email);
            }
            return false;
        }

        public async Task<bool> ValidatePhoneAsync(string phone)
        {
            if (!string.IsNullOrEmpty(phone))
            {
                return await validator.ValidateUserInputAsync("phone", phone);
            }
            return false;
        }

        public async Task<bool> ValidateAddressAsync(string address)
        {
            if (!string.IsNullOrEmpty(address))
            {
                return await validator.ValidateUserInputAsync("address", address);
            }
            return false;
        }

        public async Task<bool> ValidateDoubleAsync(string doubleValue)
        {
            return await validator.ValidateUserInputAsync("double", doubleValue);
        }

        public async Task<bool> ValidateIntAsync(string intValue)
        {
            return await validator.ValidateUserInputAsync("int", intValue);
        }

        public async Task<bool> ValidateDecimalAsync(string decimalValue)
        {
            return await validator.ValidateUserInputAsync("positiveDecimal", decimalValue);
        }

        public async Task<bool> ValidateSexAsync(string sex)
        {
            return await validator.ValidateUserInputAsync("sex", sex);
        }

        // --------------------- PickALawyer ---------------------
        public async Task<bool> ValidateLawyerSelectionAsync(UiLawyer selectedLawyer)
        {
            if (selectedLawyer != null)
            {
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }

        public async Task<List<UIModels.UiLawyer>> GetAllLawyersAsync()
        {
            try
            {
                return await lawyerBL.GetAllAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching lawyers: {ex.Message}");
                return new List<UiLawyer>();
            }
        }

        // --------------------- LawyerSpecificCaseOverview ---------------------

        public async Task<List<UiClient>> GetAllClientsAsync()
        {
            return await clientBL.GetAllAsync();
        }

        public async Task<UiClient> GetClientAsync(int clientId)
        {
            return await clientBL.GetOneAsync(clientId);
        }

        public async Task<bool> UpdateClientAsync(UiClient client)
        {
            return await clientBL.UpdateAsync(client);
        }

        // --------------------- CaseBL ---------------------

        public async Task<bool> CreateCaseAsync(UiCase caseEntity)
        {
            return await caseBL.CreateAsync(caseEntity);
        }

        public async Task<List<UiCase>> GetAllCasesAsync()
        {
            return await caseBL.GetAllAsync();
        }

        public async Task<UiCase> GetCaseAsync(int caseId)
        {
            return await caseBL.GetOneAsync(caseId);
        }

        public async Task<bool> UpdateCaseAsync(UiCase caseEntity)
        {
            return await caseBL.UpdateAsync(caseEntity);
        }

        // --------------------- LawyerAddService ---------------------

        public async Task<List<UiService>> GetAllServicesAsync()
        {
            try
            {
                return await serviceBL.GetAllAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching services: {ex.Message}");
                return new List<UiService>();
            }
        }

        // --------------------- LoanCalculator ---------------------
        public decimal CalculateMonthlyPayment(decimal loanAmount, decimal annualInterestRate, int loanTermYears)
        {
            return loanCalculator.CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);
        }

        public decimal CalculateYearlyPayment(decimal loanAmount, decimal annualInterestRate, int loanTermYears)
        {
            return loanCalculator.CalculateYearlyPayment(loanAmount, annualInterestRate, loanTermYears);
        }

        public decimal CalculateTotalInterestPaid(decimal loanAmount, decimal yearlyPayment, int loanTermYears)
        {
            return loanCalculator.CalculateTotalInterestPaid(loanAmount, yearlyPayment, loanTermYears);
        }

        public decimal CalculateYearlyInterestPaid(decimal totalInterestPaid, int loanTermYears)
        {
            return loanCalculator.CalculateYearlyInterestPaid(totalInterestPaid, loanTermYears);
        }

        // --------------------- LawyerSpecificCaseOverview ---------------------

        public async Task<bool> CreateAppliedServiceAsync(UiAppliedService appliedService, int relatedCaseId)
        {
            return await appliedServiceBL.CreateAsync(appliedService, relatedCaseId);
        }

        public async Task<UiAppliedService> GetAppliedServiceAsync(int serviceId)
        {
            return await appliedServiceBL.GetOneAsync(serviceId);
        }


    }
}
