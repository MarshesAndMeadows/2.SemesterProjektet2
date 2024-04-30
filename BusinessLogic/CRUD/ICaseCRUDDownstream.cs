using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Michael
namespace BusinessLogic.CRUD
{
    internal interface ICaseCRUDDownstream
    {
        Task<Models.Case> CreateCaseDownstreamAsync(UIModels.UICase caseUiEntity);
    }
}
