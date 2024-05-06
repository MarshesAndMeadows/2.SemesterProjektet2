using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Converters
{
    public class ConvertFromUiModel
    {
        public Models.Case ConvertFromCaseUIModel(UIModels.UiCase caseUiEntity)
        {
            Models.Case caseModel = new Models.Case
            {
                CaseId = caseUiEntity.CaseId,
                CaseName = caseUiEntity.CaseName,
                EstimatedEndDate = caseUiEntity.EstimatedEndDate,
                StartDate = caseUiEntity.StartDate,
                CaseClosed = caseUiEntity.CaseClosed               
            };
            return caseModel;
        }

        public Models.Client ConvertFromClientUIModel(UIModels.UiClient clientUiEntity)
        {
            Models.Client clientModel = new Models.Client
            {
                ClientId = clientUiEntity.ClientId,
                Firstname = clientUiEntity.Firstname,
                Lastname = clientUiEntity.Lastname,
                Sex = clientUiEntity.Sex,
                Birthday = clientUiEntity.Birthday,
                Email = clientUiEntity.Email,
                PhoneNumber = clientUiEntity.PhoneNumber,
                Address = clientUiEntity.Address,
                Subscribed = clientUiEntity.Subscribed
            };
            return clientModel;
        }
    }
}
