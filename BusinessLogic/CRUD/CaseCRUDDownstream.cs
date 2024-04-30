using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Converters;
using DataAccess;
using Models;
using UIModels;

// Michael - dette er CRUD for Case når der kaldes downstream(fra UI ned i db)
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

        
        public async Task<Models.Case> CreateCaseDownstreamAsync(UICase caseUiEntity)
        {
            var caseModel = convertFromUiModel.ConvertFromUIModel(caseUiEntity);

            var createdCase = await db.CreateAsync(caseModel);

            return createdCase;
        }
    }

}