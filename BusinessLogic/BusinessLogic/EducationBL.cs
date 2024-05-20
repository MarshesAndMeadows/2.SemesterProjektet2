using BusinessLogic.Converters;
using BusinessLogic.CRUD;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic.BusinessLogic
{
    public class EducationBL : ICrud<UIModels.UiEducation>
    {
        EducationDbAccess db;
        ConvertFromModel convertFromModel;
        ConvertFromUiModel convertFromUiModel;

        public EducationBL()
        {
            db = new EducationDbAccess();
            convertFromModel = new ConvertFromModel();
            convertFromUiModel = new ConvertFromUiModel();
        }
        public async Task<bool> CreateAsync(UiEducation educationUiEntity)
        {
            Models.Education educationModel = convertFromUiModel.ConvertFromEducationUIModel(educationUiEntity);
            try
            {
                await db.CreateAsync(educationModel);
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
            return false;
            // Not implemented; reasoning being that one would not need to remove an education.
            // will add later, time permitting.
        }
        public async Task<List<UIModels.UiEducation>> GetAllAsync()
        {
            try
            {
                List<Models.Education> allEducations = await db.GetAllAsync();
                List<UIModels.UiEducation> uiEducation = allEducations.Select(convertFromModel.ConvertFromEducationModel).ToList();
                return uiEducation;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return new List<UIModels.UiEducation>();
        }
        public async Task<UIModels.UiEducation> GetOneAsync(int EducationId)
        {
            try
            {
                Models.Education educationModel = await db.GetOneAsync(EducationId);
                UIModels.UiEducation uiEducation = convertFromModel.ConvertFromEducationModel(educationModel);
                return uiEducation;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync($"Case with id: {EducationId} not found in db {e.Message}");
            }
            return new UiEducation();
        }
        public async Task<bool> UpdateAsync(UIModels.UiEducation educationToUpdate)
        {
            return false;
            // same as Delete, reasoning being that one would not need to update an existing education.
            // time permitting, will fix.
        }
    }
}