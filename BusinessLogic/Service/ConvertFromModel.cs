using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Converters
{
    public class ConvertFromModel
    {
        public UIModels.UiCase ConvertFromCaseModel(Models.Case caseEntity)
        {
            UIModels.UiCase caseUIModel = new UIModels.UiCase
            {
                Id = caseEntity.Id, 
                CaseName = caseEntity.CaseName,
                CaseDescription = caseEntity.CaseDescription,
                EstimatedEndDate = caseEntity.EstimatedEndDate,
                StartDate = caseEntity.StartDate,
                CaseClosed = caseEntity.CaseClosed
            };
            return caseUIModel;
        }

        public UIModels.UiClient ConvertFromClientModel(Models.Client clientEntity)
        {
            UIModels.UiClient clientUIModel = new UIModels.UiClient
            {
                Id = clientEntity.Id,
                Firstname = clientEntity.Firstname,
                Lastname = clientEntity.Lastname,
                Sex = clientEntity.Sex,
                Birthday = clientEntity.Birthday,
                Email = clientEntity.Email,
                PhoneNumber = clientEntity.PhoneNumber,
                Address = clientEntity.Address,
                Subscribed = clientEntity.Subscribed
            };
            return clientUIModel;
        }

        public UIModels.UiLawyer ConvertFromLawyerModel(Models.Lawyer laywerEntity)
        {
            UIModels.UiLawyer laywerUIModel = new UIModels.UiLawyer
            {
                Id = laywerEntity.Id,
                Firstname = laywerEntity.Firstname,
                Lastname = laywerEntity.Lastname,
                Sex = laywerEntity.Sex,
                WorkPosition = laywerEntity.WorkPosition,
                DateHired = laywerEntity.DateHired,
                Email = laywerEntity.Email,
                WorkPhone = laywerEntity.WorkPhone                
            };
            return laywerUIModel;
        }
    }
}

