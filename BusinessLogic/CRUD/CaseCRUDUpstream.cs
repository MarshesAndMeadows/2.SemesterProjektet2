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

        public async Task<UIModels.UICase> CreateCaseUpstreamAsync(Models.Case caseModel)
        {
            UIModels.UICase caseUiModel = convertFromModel.ConvertFromCaseModel(caseModel);

            var createdCase = await db.CreateAsync(caseModel);

            return createdCase;
        }
    }
}
