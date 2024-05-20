using BusinessLogic.Converters;
using BusinessLogic;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using UIModels;

namespace BusinessLogic.BusinessLogic
{
    public class ServiceBL : ICrud<UIModels.UiService>
    {
        ServiceDbAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;


        public ServiceBL()
        {
            db = new ServiceDbAccess();
            convertFromModel = new ConvertFromModel();
            convertFromUiModel = new ConvertFromUiModel();  
        }

        public async Task<bool> CreateAsync(UiService serviceUiEntity)
        {

            Models.Service serviceModel = convertFromUiModel.ConvertFromServiceUIModel(serviceUiEntity);
            try
            {
                await db.CreateAsync(serviceModel);
                return true;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int idToDelete)
        {
            try
            {
                if (await db.DeleteAsync(idToDelete))
                {
                    return true;
                }
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync($"Case with id: {idToDelete} not found in db {e.Message}");
            }
            return false;
        }

        public async Task<List<UiService>> GetAllAsync()
        {
            try
            {
                List<Models.Service> allServices = await db.GetAllAsync();
                List<UIModels.UiService> uiServices = allServices.Select(convertFromModel.ConvertFromServiceModel).ToList();
                return uiServices;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return new List<UIModels.UiService>();
        }

        public async Task<UiService> GetOneAsync(int id)
        {
            try
            {
                Models.Service serviceModel = await db.GetOneAsync(id);
                UIModels.UiService uiService = convertFromModel.ConvertFromServiceModel(serviceModel);
                return uiService;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync($"Case with id: {id} not found in db {e.Message}");
            }
            return new UiService();
        }

        public async Task<bool> UpdateAsync(UiService serviceToUpdate)
        {
            try
            {
                Models.Service serviceModel = convertFromUiModel.ConvertFromServiceUIModel(serviceToUpdate);
                await db.UpdateAsync(serviceModel.Id, serviceModel);
                return true;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (DbUpdateException e)
            {
                await Console.Out.WriteLineAsync($"Cannot save to db. {e.Message}");
            }
            return false;
        }
    }
}
