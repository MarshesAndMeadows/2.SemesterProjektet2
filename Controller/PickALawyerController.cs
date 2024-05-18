using BusinessLogic.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace Controller
{
    public class PickALawyerController
    {
        private readonly LawyerBL lawyerBL;

        public PickALawyerController()
        {
            lawyerBL = new LawyerBL();
        }

        public async Task<List<UiLawyer>> GetAllLawyersAsync()
        {
            return await lawyerBL.GetAllAsync();
        }

        public UiLawyer GetOneLawyer(UiLawyer selectedLawyer)
        {
            return selectedLawyer;
        }
    }
}
