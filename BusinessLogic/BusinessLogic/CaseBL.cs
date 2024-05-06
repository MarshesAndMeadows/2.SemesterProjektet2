using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Converters;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Models;
using UIModels;

namespace BusinessLogic.CRUD
{
    internal class CaseBL : ICrud<UIModels.UiCase>
    {
        CaseDbAccess db;
        ConvertFromModel convertFromCaseModel;
        ConvertFromUiModel convertFromUiModel;

        public CaseBL(CaseDbAccess db, ConvertFromModel convertFromCaseModel, ConvertFromUiModel convertFromUiModel)
        {
            this.db = db;
            this.convertFromCaseModel = convertFromCaseModel;
            this.convertFromUiModel = convertFromUiModel;
        }


        public async Task<bool> CreateAsync(UiCase caseUiEntity)
        {
            Models.Case caseModel = convertFromUiModel.ConvertFromCaseUIModel(caseUiEntity);
            try
            {
                await db.CreateAsync(caseModel);
                return true;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return false;
        }

        public async Task<UIModels.UiCase> GetOneAsync(int caseId)
        {
            try
            {
                Models.Case caseModel = await db.GetOneAsync(caseId);
                UIModels.UiCase uiCase = convertFromCaseModel.ConvertFromCaseModel(caseModel);
                return uiCase;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync($"Case with id: {caseId} not found in db {e.Message}");
            }
            return new UiCase();
        }

        /*
        Denne GeetAllCasesAsync metode er sat op så: 
        1. Cases hentes med db.GetAllAsync og gemmes i List<Models.Case> allCases 
        2. Dernæst udvælges(Select) hver Case i allCases og konverteres til en UiCaseModel med ConvertFromModel, som gemmes i en Liste af UiModels
        */
        public async Task<List<UIModels.UiCase>> GetAllAsync()
        {
            try
            {
                List<Models.Case> allCases = await db.GetAllAsync();
                List<UIModels.UiCase> uiCases = allCases.Select(convertFromCaseModel.ConvertFromCaseModel).ToList();
                return uiCases;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            }
            return new List<UIModels.UiCase>();
        }

        /*
        Denne Update metode er sat op så: 
        1. UiModel converteres til Model 
        2. dernæst kaldes UpdateAsync i DA med den den konverterede model som argument
        3.  return true hvois kalde er susselfuldt
        4. Ellers returners der false
        */
        public async Task<bool> UpdateAsync(UIModels.UiCase caseToUpdate)
        {
            try
            {
                Models.Case caseModel = convertFromUiModel.ConvertFromCaseUIModel(caseToUpdate);

                await db.UpdateAsync(caseModel);

                return true;
            }
            catch (SqlException e)
            {
                await Console.Out.WriteLineAsync($"Cannot connect to db. {e.Message}");
            } catch (DbUpdateException e)
            {
                await Console.Out.WriteLineAsync($"Cannot save to db. {e.Message}");
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
    }
}

