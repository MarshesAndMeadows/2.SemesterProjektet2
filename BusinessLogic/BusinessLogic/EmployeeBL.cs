using BusinessLogic.Converters;
using BusinessLogic;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using UIModels;

namespace BusinessLogic.BusinessLogic
{
    public class EmployeeBL : ICrud<UIModels.UiEmployee>
    {
        EmployeeDbAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public EmployeeBL()
        {
            db = new EmployeeDbAccess();
            convertFromModel = new ConvertFromModel();
            convertFromUiModel = new ConvertFromUiModel();
        }

        public async Task<bool> CreateAsync(UiEmployee employeeUiEntity)
        {
            Models.Employee employeeModel = convertFromUiModel.ConvertFromEmployeeUIModel(employeeUiEntity);
            try
            {
                await db.CreateAsync(employeeModel);
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

        public async Task<List<UIModels.UiEmployee>> GetAllAsync()
        {
            try
            {
                List<Models.Employee> allEmployees = await db.GetAllAsync();
                List<UIModels.UiEmployee> uiEmployees = allEmployees.Select(convertFromModel.ConvertFromEmployeeModel).ToList();
                return uiEmployees;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return new List<UIModels.UiEmployee>();
        }

        public async Task<UIModels.UiEmployee> GetOneAsync(int clientId)
        {
            try
            {
                Models.Employee employeeModel = await db.GetOneAsync(clientId);
                UIModels.UiEmployee uiEmployee = convertFromModel.ConvertFromEmployeeModel(employeeModel);
                return uiEmployee;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync($"Case with id: {clientId} not found in db {e.Message}");
            }
            return new UiEmployee();
        }

        public async Task<bool> UpdateAsync(UIModels.UiEmployee employeeToUpdate)
        {
            try
            {
                Models.Employee employeeModel = convertFromUiModel.ConvertFromEmployeeUIModel(employeeToUpdate);
                await db.UpdateAsync(employeeModel.Id, employeeModel);
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
