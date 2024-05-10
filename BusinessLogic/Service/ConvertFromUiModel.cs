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
                Id = caseUiEntity.Id,
                CaseName = caseUiEntity.CaseName,
                CaseDescription = caseUiEntity.CaseDescription,
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
                Id = clientUiEntity.Id,
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

        public Models.Lawyer ConvertFromLaywerUIModel(UIModels.UiLawyer lawyerUiEntity)
        {
            Models.Lawyer laywerModel = new Models.Lawyer
            {
                Id = lawyerUiEntity.Id,
                Firstname = lawyerUiEntity.Firstname,
                Lastname = lawyerUiEntity.Lastname,
                Sex = lawyerUiEntity.Sex,
                WorkPosition = lawyerUiEntity.WorkPosition,
                DateHired = lawyerUiEntity.DateHired,
                Email = lawyerUiEntity.Email,
                WorkPhone = lawyerUiEntity.WorkPhone                
            };
            return laywerModel;
        }

        public Models.Service ConvertFromServiceUIModel(UIModels.UiService serviceUiEntity)
        {
            Models.Service serviceModel = new Models.Service
            {
                Id = serviceUiEntity.Id,
                ServiceName = serviceUiEntity.ServiceName,
                Description = serviceUiEntity.Description,
                OneTimePayment = serviceUiEntity.OneTimePayment,
                StartPaymentDefault = serviceUiEntity.StartPaymentDefault,
                UnitCostDefault = serviceUiEntity.UnitCostDefault
                
            };
            return serviceModel;
        }

        public Models.AppliedService ConvertFromAppliedServiceUIModel(UIModels.UiAppliedService appliedServiceUiEntity)
        {
            Models.AppliedService appliedServiceModel = new Models.AppliedService
            {
                Id = appliedServiceUiEntity.Id,
                Note = appliedServiceUiEntity.Note,
                UnitCount = appliedServiceUiEntity.UnitCount,
                UnitCostActual = appliedServiceUiEntity.UnitCostActual,
                StartPaymentActual = appliedServiceUiEntity.StartPaymentActual,
                ServicePerformed = appliedServiceUiEntity.ServicePerformed
            };
            return appliedServiceModel;
        }
    }
}
