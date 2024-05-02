using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Converters;
using DataAccess;
using Models;
using UIModels;

// Michael
namespace BusinessLogic.CRUD
{
    public class CaseBL : ICase
    {
        CaseDbAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public CaseBL(CaseDbAccess db, ConvertFromModel convertFromModel, ConvertFromUiModel convertFromUiModel)
        {
            this.db = db;
            this.convertFromModel = convertFromModel;
            this.convertFromUiModel = convertFromUiModel;
        }


        public async Task<bool> CreateCaseAsync(UiCase caseUiEntity)
        {
            Models.Case caseModel = convertFromUiModel.ConvertFromCaseUIModel(caseUiEntity);
            try
            {               
                await db.CreateAsync(caseModel);
                return true;
                
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public async Task<UIModels.UiCase> GetOneCaseAsync(int caseId)
        {
            try
            {
                Models.Case caseModel = await db.GetOneAsync(caseId);
                UIModels.UiCase uiCase = convertFromModel.ConvertFromCaseModel(caseModel);
                return uiCase;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        // Cases hentes med db.GetAllAsync og gemmes i List<Models.Case> allCases 
        // Dernæst udvælges hver Case i allCases og konverteres til en UiCaseModel med ConvertFromCaseModel
        // De konverterede likste med UiCases returneres til sidst
        public async Task<List<UIModels.UiCase>> GetAllCasesAsync()
        {
            try
            {
                List<Models.Case> allCases = await db.GetAllAsync();
                List<UIModels.UiCase> uiCases = allCases.Select(convertFromModel.ConvertFromCaseModel).ToList();
                return uiCases;
            }
            catch (SqlException e)
            {                
                return null; 
            }
        }

        // Update

        // Delete
    }
}

