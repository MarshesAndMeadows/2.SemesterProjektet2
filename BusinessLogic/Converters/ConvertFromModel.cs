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
        public UIModels.UICase ConvertFromCaseEntity(Models.Case caseEntity)
        {
            UIModels.UICase caseUI = new UIModels.UICase
            {
                CaseId = caseEntity.CaseId,
                Name = caseEntity.Name,
                EstimatedEndDate = caseEntity.EstimatedEndDate,
                StartDate = caseEntity.StartDate,
                CaseClosed = caseEntity.CaseClosed,
                EmployeeId = caseEntity.EmployeeId
            };
            return caseUI;
        }
    }
}

