using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic.CRUD
{
    public class CaseCRUDUpstream : ICaseCRUDUpstream
    {
        public Task<UICase> CreateCaseUpstreamAsync(Case caseModel)
        {
            throw new NotImplementedException();
        }
    }
}
