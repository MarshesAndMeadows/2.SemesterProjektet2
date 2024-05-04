using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Michael
namespace BusinessLogic.CRUD
{
    internal interface ICase
    {
        Task<bool> CreateCaseAsync(UIModels.UiCase caseUiEntity);
        Task<UIModels.UiCase> GetOneCaseAsync(int caseId);
        Task<List<UIModels.UiCase>> GetAllCasesAsync();
        Task<bool> UpdateCaseAsync(UIModels.UiCase caseToUpdate);
        Task<bool> DeleteCaseAsync(int caseToDelete);
    }
}
