using BusinessLogic.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using Models;
using BusinessLogic.Converters;
using System.Data.SqlClient;

namespace BusinessLogic.BusinessLogic
{
    public class LawyerBL
    {
        LawyerDbAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public LawyerBL(LawyerDbAccess db, ConvertFromModel convertFromModel, ConvertFromUiModel convertFromUiModel)
        {
            this.db = db;
            this.convertFromModel = convertFromModel;
            this.convertFromUiModel = convertFromUiModel;
        }

        public async Task<List<UIModels.UiLawyer>> GetAllAsync()
        {
            try
            {
                List<Models.Lawyer> allLawyers = await db.GetAllAsync();
                List<UIModels.UiLawyer> uiLawyers = allLawyers.Select(convertFromModel.ConvertFromLawyerModel).ToList();
                return uiLawyers;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return new List<UIModels.UiLawyer>();
        }

        public async Task<UIModels.UiLawyer> GetOneAsync(int lawyerId)
        {
            try
            {
                Models.Lawyer laywerModel = await db.GetOneAsync(lawyerId);
                UIModels.UiLawyer uiLawyer = convertFromModel.ConvertFromLawyerModel(laywerModel);
                return uiLawyer;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync($"Case with id: {lawyerId} not found in db {e.Message}");
            }
            return new UiLawyer();
        }
       
    }
}
