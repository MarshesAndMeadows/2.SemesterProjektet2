using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;

namespace Controller
{
    public class LawyerOverviewController
    {
        private readonly ClientBL clientBL;
        private readonly CaseBL caseBL;

        public LawyerOverviewController()
        {
            caseBL = new CaseBL();
            clientBL = new ClientBL();
        }

        public async Task<List<UiCase>> GetAllCasesAsync()
        {
            return await caseBL.GetAllAsync();
        }

        public async Task<List<UiClient>> GetAllClientsAsync()
        {
            return await clientBL.GetAllAsync();
        }

        public async Task<UiCase> GetOneCaseAsync(int caseId)
        {
            return await caseBL.GetOneAsync(caseId);
        }

        public async Task<UiClient> GetOneClientAsync(int clientId)
        {
            return await clientBL.GetOneAsync(clientId);
        }
    }
}
