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
        DataAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public CaseBL(DataAccess db, ConvertFromModel convertFromModel, ConvertFromUiModel convertFromUiModel)
        {
            this.db = db;
            this.convertFromModel = convertFromModel;
            this.convertFromUiModel = convertFromUiModel;
        }


        public async Task<bool> CreateCaseAsync(UICase caseUiEntity)
        {
            Models.Case caseModel = convertFromUiModel.ConvertFromCaseUIModel(caseUiEntity);
            try
            {
                if (caseModel == null)
                {
                    return false;
                }
                else
                {
                    await db.CreateAsync(caseModel);
                    return true;
                }
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public async Task<UIModels.UICase> GetOneCaseAsync(int caseId)
        {
            try
            {
                Models.Case caseModel = await db.GetAsync<Models.Case>(caseId);

                UIModels.UICase uiCase = convertFromModel.ConvertFromCaseModel(caseModel);

                return uiCase;
            }
            catch (SqlException e)
            {
                return null;
            }
        }


        public async Task<List<UIModels.UICase>> GetAllCasesAsync()
        {
            try
            {
                List<Models.Case> allCases = await db.GetAllAsync<Models.Case>();

                List<UIModels.UICase> uiCases = allCases.Select(convertFromModel.ConvertFromCaseModel).ToList();

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

