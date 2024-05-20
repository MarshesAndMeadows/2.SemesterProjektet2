using BusinessLogic;
using UIModels;
using Models;
using BusinessLogic.Converters;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic.BusinessLogic
{
    public class LawyerBL
    {
        LawyerDbAccess db;
        ConvertFromModel convertFromLawyerModel;
        ConvertFromUiModel convertFromUiModel;

        public LawyerBL()
        {
            db = new LawyerDbAccess();
            convertFromLawyerModel = new ConvertFromModel();
            convertFromUiModel = new ConvertFromUiModel();
        }

        public async Task<List<UIModels.UiLawyer>> GetAllAsync()
        {
            try
            {
                List<Models.Lawyer> allLawyers = await db.GetAllAsync();
                List<UIModels.UiLawyer> uiLawyers = allLawyers.Select(convertFromLawyerModel.ConvertFromLawyerModel).ToList();
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
                UIModels.UiLawyer uiLawyer = convertFromLawyerModel.ConvertFromLawyerModel(laywerModel);
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
