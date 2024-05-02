using BusinessLogic.Converters;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using Models;
using DataAccess;
using System.Data.SqlClient;
// Michael
namespace BusinessLogic.CRUD
{
    public class CaseCRUDUpstream : ICaseCRUDUpstream
    {
        DataAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public CaseCRUDUpstream(DataAccess db, ConvertFromModel convertFromModel, ConvertFromUiModel convertFromUiModel)
        {
            this.db = db;
            this.convertFromModel = convertFromModel;
            this.convertFromUiModel = convertFromUiModel;
        }

        public async Task<bool> CreateCaseUpstreamAsync(Models.Case caseModel)
        {
            UIModels.UICase caseUiModel = convertFromModel.ConvertFromCaseModel(caseModel);

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
    }
}
