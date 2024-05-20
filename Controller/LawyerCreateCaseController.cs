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

    public class LawyerCreateCaseController
    {
        private readonly CaseBL caseBL;
        private readonly ClientBL clientBL;
        private readonly LawyerBL lawyerBL;

        public LawyerCreateCaseController()
        {
            caseBL = new CaseBL();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();
        }

        public async Task<List<UiLawyer>> GetAllLawyersAsync()
        {
            return await lawyerBL.GetAllAsync();
        }

        public async Task<List<UiClient>> GetAllClientsAsync()
        {
            return await clientBL.GetAllAsync();
        }

        public async Task<bool> CreateCaseAsync(UiCase caseToCreate)
        {
            return await caseBL.CreateAsync(caseToCreate);
        }

        public async Task<UiClient> GetOneClientAsync(int clientId)
        {
            return await clientBL.GetOneAsync(clientId);
        }

        public async Task<UiLawyer> GetOneLawyerAsync(int lawyerId)
        {
            return await lawyerBL.GetOneAsync(lawyerId);
        }
    }
}


