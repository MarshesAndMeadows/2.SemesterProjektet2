using BusinessLogic;
using BusinessLogic.DummyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace Controller
{
    public class LoginController
    {
        private readonly BusinessLogic.DatabaseManipMethods dbManip;

        public LoginController()
        {
            dbManip = new BusinessLogic.DatabaseManipMethods();
        }

        public async Task<bool> ResetDatabaseAsync()
        {
            await dbManip.ClearAllDataAsync();
            await dbManip.CreateAllDataAsync();
            return true;
        }
    }
}
