using BusinessLogic;
using BusinessLogic.BusinessLogic;
using Models;
using UIModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;


namespace Controller
{
    public class Controllers
    {

        private readonly ClientBL clientBL;
        private readonly BusinessLogic.Validation validator;
        private readonly LawyerBL lawyerBL;
        private readonly AppliedServiceBL appliedServiceBL;
        private readonly CaseBL caseBL;
        private readonly ServiceBL serviceBL;

        public Controllers()
        {
            clientBL = new ClientBL();
            validator = new BusinessLogic.Validation();
            lawyerBL = new LawyerBL();
            appliedServiceBL = new AppliedServiceBL();
            caseBL = new CaseBL();
            serviceBL = new ServiceBL();
        }

        // ------------- LawyerCreateClient -------------

        public async Task<bool> CreateClientAsync(UIModels.UiClient client)
        {
            return await clientBL.CreateAsync(client);
        }

        // ------------- Validation -------------

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

        public async Task<bool> ValidateSexAsync(string sex)
        {
            if (!string.IsNullOrEmpty(sex))
            {
                return await validator.ValidateUserInputAsync("sex", sex);
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

        // ------------- PickALawyer -------------
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
                return new List<UIModels.UiLawyer>();
            }
        }

        // ------------- LawyerSpecificCaseOverview -------------
             
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

        public async Task<bool> DeleteClientAsync(int clientId)
        {
            return await clientBL.DeleteAsync(clientId);
        }

        // -------- AppliedServicesBL ----------

        public async Task<bool> CreateAppliedServiceAsync(UiAppliedService appliedService)
        {
            return await appliedServiceBL.CreateAsync(appliedService);
        }

        public async Task<List<UiAppliedService>> GetAllAppliedServicesAsync()
        {
            return await appliedServiceBL.GetAllAsync();
        }

        public async Task<UiAppliedService> GetAppliedServiceAsync(int appliedServiceId)
        {
            return await appliedServiceBL.GetOneAsync(appliedServiceId);
        }

        public async Task<bool> UpdateAppliedServiceAsync(UiAppliedService appliedService)
        {
            return await appliedServiceBL.UpdateAsync(appliedService);
        }

        public async Task<bool> DeleteAppliedServiceAsync(int appliedServiceId)
        {
            return await appliedServiceBL.DeleteAsync(appliedServiceId);
        }

        // -------- CaseBL ---------------------
      
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

        public async Task<bool> DeleteCaseAsync(int caseId)
        {
            return await caseBL.DeleteAsync(caseId);
        }

        // ------- LawyerAddService -------
        public async Task<bool> ValidateServiceSelectionAsync(UiService selectedService)
        {
            if (selectedService != null)
            {
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

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

        public async Task<bool> CreateAppliedServiceToCaseAsync(UiAppliedService appliedService, UiCase relatedCase)
        {
            relatedCase.AppliedServices.Add(appliedService);
            return await caseBL.UpdateAsync(relatedCase);
        }
    }
}
