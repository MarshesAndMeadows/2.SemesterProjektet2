using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Forms.Helper
{
    internal class HelpFunctionality
    {

        public string LoadHelperContent(Form formName)
        {
            
            if (formName.Name.Equals("CustomerCase"))
            {
                return "This is just a test";
            } else if(formName.Name.Equals("CustomerOverview"))
            {
                return "";
            }
            else if (formName.Name.Equals("CustomerSpecificCases"))
            {
                return "";
            }
            else if (formName.Name.Equals("CustomerTools"))
            {
                return "";
            }            
            else if (formName.Name.Equals("LawyerAddService"))
            {
                return "";
            }
            else if (formName.Name.Equals("LawyerCreateCase"))
            {
                return "This is a testy";
            }
            else if (formName.Name.Equals("LawyerCreateClient"))
            {
                return "This is a testy";
            }
            else if (formName.Name.Equals("LaywerOverview"))
            {
                return "";
            }
            else if (formName.Name.Equals("LawyerSpecificCaseOverView"))
            {
                return "";
            }
            else if (formName.Name.Equals("LoginPage"))
            {
                return "";
            }
            else if (formName.Name.Equals("PickALawyer"))
            {
                return "";
            }
            else if (formName.Name.Equals("ServiceSeeChart"))
            {
                return "";
            }
            return "No formName received, whats name of the form?";

        }


/*
        public string DisplayHelpContent()
        {


        }
*/
    }
}
