using BusinessLogic;
using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace Controller
{
    public class LawyerSpecificCaseOverviewController
    {
        private readonly ClientBL _clientBL;
        private readonly CaseBL _caseBL;
        private readonly AppliedServiceBL _appliedServiceBL;
        private readonly Validation validator;

        public LawyerSpecificCaseOverviewController()
        {
            _clientBL = new ClientBL();
            _caseBL = new CaseBL();
            _appliedServiceBL = new AppliedServiceBL();
            validator = new Validation();
        }

        public async Task<bool> UpdateClientAsync(UiClient clientToUpdate)
        {
            return await _clientBL.UpdateAsync(clientToUpdate);
        }

        public async Task<bool> UpdateCaseAsync(UiCase caseToUpdate)
        {
            return await _caseBL.UpdateAsync(caseToUpdate);
        }

        public async Task<bool> ValidateUserInputAsync(string inputType, string inputValue)
        {
            return await validator.ValidateUserInputAsync(inputType, inputValue);
        }

        public async Task<List<UiAppliedService>> GetAppliedServicesAsync(List<UiAppliedService> services)
        {
            List<UiAppliedService> appliedServices = new List<UiAppliedService>();
            foreach (UiAppliedService service in services)
            {
                UiAppliedService tempService = await _appliedServiceBL.GetOneAsync(service.Id);
                appliedServices.Add(tempService);
            }
            return appliedServices;
        }
    }
}
