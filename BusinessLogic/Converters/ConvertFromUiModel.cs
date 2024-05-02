using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Michael
namespace BusinessLogic.Converters
{
    internal class ConvertFromUiModel
    {
        public Models.Case ConvertFromUIModel(UIModels.UICase caseUiEntity)
        {
            Models.Case caseModel = new Models.Case
            {
                CaseId = caseUiEntity.CaseId,
                Name = caseUiEntity.Name,
                EstimatedEndDate = caseUiEntity.EstimatedEndDate,
                StartDate = caseUiEntity.StartDate,
                CaseClosed = caseUiEntity.CaseClosed,
                EmployeeId = caseUiEntity.EmployeeId,
            };
            return caseModel;
        }
    }
}
