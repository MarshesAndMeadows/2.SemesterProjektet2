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
    public class CaseCRUDDownstream : ICaseCRUDDownstream
    {
        DataAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public CaseCRUDDownstream(DataAccess db, ConvertFromModel convertFromModel, ConvertFromUiModel convertFromUiModel)
        {
            this.db = db;
            this.convertFromModel = convertFromModel;
            this.convertFromUiModel = convertFromUiModel;
        }

        // Create
        public async Task<bool> CreateCaseDownstreamAsync(UICase caseUiEntity)
        {
            Models.Case caseModel = convertFromUiModel.ConvertFromCaseUIModel(caseUiEntity);

            try
            {
                if (caseModel == null) 
                {
                    return false;
                } else 
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

        // Read

        // Update

        // Delete
    }
}

