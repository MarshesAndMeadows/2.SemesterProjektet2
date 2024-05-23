using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Forms.Helper
{
    internal class HelpPage
    {       
        public void LoadHelperContent(Form formName)
        {
            HelpForm helpForm = new HelpForm(formName);
            helpForm.SetHelpContent(formName.Name);
            helpForm.Show();
        }
    }
}






