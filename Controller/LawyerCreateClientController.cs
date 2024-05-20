using BusinessLogic;
using BusinessLogic.BusinessLogic;
using UIModels;

namespace Controller
{
    public class LawyerCreateClientController
    {

        private readonly ClientBL clientBL;
        private readonly Validation validator;

        public LawyerCreateClientController()
        {
            clientBL = new ClientBL();
            validator = new Validation();
        }

        public async Task<List<UiClient>> GetAllClientsAsync()
        {
            return await clientBL.GetAllAsync();
        }

        public async Task<UiClient> GetOneClientAsync(int clientId)
        {
            return await clientBL.GetOneAsync(clientId);
        }

        public async Task<bool> ValidateUserInputAsync(string inputType, string inputValue)
        {
            return await validator.ValidateUserInputAsync(inputType, inputValue);
        }

        public async Task<bool> CreateClientAsync(UiClient clientToCreate)
        {
            return await clientBL.CreateAsync(clientToCreate);
        }

    }
}
