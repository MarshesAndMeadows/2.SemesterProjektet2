using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Michael
namespace BusinessLogic.Converters
{
    public class ConvertFromUiModel
    {
        public Models.Case ConvertFromCaseUIModel(UIModels.UiCase caseUiEntity)
        {
            Models.Case caseModel = new Models.Case
            {
                CaseId = caseUiEntity.CaseId,
                CaseName = caseUiEntity.CaseName,
                EstimatedEndDate = caseUiEntity.EstimatedEndDate,
                StartDate = caseUiEntity.StartDate,
                CaseClosed = caseUiEntity.CaseClosed,
                //EmployeeId = caseUiEntity.EmployeeId,
            };
            return caseModel;
        }
    }
}
