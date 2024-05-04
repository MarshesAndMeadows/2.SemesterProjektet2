using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Michael
namespace BusinessLogic.Converters
{
    public class ConvertFromModel
    {
        public UIModels.UiCase ConvertFromCaseModel(Models.Case caseEntity)
        {
            UIModels.UiCase caseUI = new UIModels.UiCase
            {
                CaseId = caseEntity.CaseId,
                CaseName = caseEntity.CaseName,
                EstimatedEndDate = caseEntity.EstimatedEndDate,
                StartDate = caseEntity.StartDate,
                CaseClosed = caseEntity.CaseClosed,
            };
            return caseUI;
        }
    }
}

