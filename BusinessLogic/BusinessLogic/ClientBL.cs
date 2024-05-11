using BusinessLogic.Converters;
using BusinessLogic.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Data.SqlClient;


namespace BusinessLogic.BusinessLogic
{
    public class ClientBL : ICrud<UIModels.UiClient>
    {
        ClientDbAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public ClientBL()
        {
            db = new ClientDbAccess();
            convertFromModel = new ConvertFromModel();
            convertFromUiModel = new ConvertFromUiModel();
        }

        public async Task<bool> CreateAsync(UiClient clientUiEntity)
        {
            Models.Client clientModel = convertFromUiModel.ConvertFromClientUIModel(clientUiEntity);
            try
            {
                await db.CreateAsync(clientModel);
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

        public async Task<List<UIModels.UiClient>> GetAllAsync()
        {
            try
            {
                List<Models.Client> allClients = await db.GetAllAsync();
                List<UIModels.UiClient> uiClients = allClients.Select(convertFromModel.ConvertFromClientModel).ToList();
                return uiClients;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return new List<UIModels.UiClient>();
        }
          
        public async Task<UIModels.UiClient> GetOneAsync(int clientId)
        {
            try
            {
                Models.Client clientModel = await db.GetOneAsync(clientId);
                UIModels.UiClient uiClient = convertFromModel.ConvertFromClientModel(clientModel);
                return uiClient;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync($"Case with id: {clientId} not found in db {e.Message}");
            }
            return new UiClient();
        }

        public async Task<bool> UpdateAsync(UIModels.UiClient clientToUpdate)
        {
            try
            {
                Models.Client clientModel = convertFromUiModel.ConvertFromClientUIModel(clientToUpdate);
                await db.UpdateAsync(clientModel.ID, clientModel);
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
