using UIModels;
using BusinessLogic.CRUD;
using BusinessLogic.BusinessLogic;
using BusinessLogic;


namespace Controller
{
    public class LawyerAddServiceController
    {
        private readonly CaseBL _caseBL;
        private readonly ServiceBL _serviceBL;
        private readonly LawyerBL _lawyerBL;
        private readonly AppliedServiceBL _appliedServiceBL;
        private readonly Validation _validator; // Add a reference to the Validation class

        public LawyerAddServiceController()
        {
            _caseBL = new CaseBL();
            _serviceBL = new ServiceBL();
            _lawyerBL = new LawyerBL();
            _appliedServiceBL = new AppliedServiceBL();
            _validator = new Validation(); // Initialize the Validation class
        }

        public async Task<List<UiService>> LoadServiceCatalogAsync()
        {
            return await _serviceBL.GetAllAsync();
        }

        public async Task<List<UiLawyer>> LoadLawyerListAsync()
        {
            return await _lawyerBL.GetAllAsync();
        }

        public async Task AddServiceToCaseAsync(UiCase relatedCase, UiAppliedService appliedService)
        {
            // relatedCase.AppliedServices.Add(appliedService); <-------- SQL DataAccess
            // await _caseBL.CreateAsync(relatedCase);
        }

        public async Task<bool> ValidateUserInputAsync(string inputType, object input)
        {
            return await _validator.ValidateUserInputAsync(inputType, input);
        }
    }

}
}
