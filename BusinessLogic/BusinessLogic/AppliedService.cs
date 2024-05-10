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
    public class AppliedService : ICrud<UIModels.UiAppliedService>
    {
        AppliedServiceDbAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public AppliedService(ClientDbAccess db, ConvertFromModel convertFromModel, ConvertFromUiModel convertFromUiModel)
        {
            this.db = new AppliedServiceDbAccess();
            this.convertFromModel = convertFromModel;
            this.convertFromUiModel = convertFromUiModel;
        }

        public async Task<bool> CreateAsync(UiAppliedService appliedUientity)
        {
            Models.AppliedService appliedServiceModel = convertFromUiModel.ConvertFromAppliedServiceUIModel(appliedUientity);
            try
            {
                await db.CreateAsync(appliedServiceModel);
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

        public async Task<List<UiAppliedService>> GetAllAsync()
        {
            try
            {
                List<Models.AppliedService> allAppliedServices = await db.GetAllAsync();
                List<UIModels.UiAppliedService> uiAppliedServices = allAppliedServices.Select(convertFromModel.ConvertFromAppliedServiceModel).ToList();
                return uiAppliedServices;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return new List<UIModels.UiAppliedService>();
        }
    

        public async Task<UiAppliedService> GetOneAsync(int id)
        {
        try
        {
            Models.AppliedService appliedServiceModel = await db.GetOneAsync(id);
            UIModels.UiAppliedService uiAppliedServices = convertFromModel.ConvertFromAppliedServiceModel(appliedServiceModel);
            return uiAppliedServices;
        }
        catch (SqlException e)
        {
            await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
        }
        catch (Exception e)
        {
            await Console.Out.WriteLineAsync($"Case with id: {id} not found in db {e.Message}");
        }
        return new UiAppliedService();
    }

        public async Task<bool> UpdateAsync(UiAppliedService appliedServiceToUpdate)
        {
            try
            {
                Models.AppliedService appliedServiceModel = convertFromUiModel.ConvertFromAppliedServiceUIModel(appliedServiceToUpdate);
                await db.UpdateAsync(appliedServiceToUpdate.Id, appliedServiceModel);
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
