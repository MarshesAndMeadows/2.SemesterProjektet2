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
                CaseClosed = caseEntity.CaseClosed,
                Client = ConvertFromClientModel(caseEntity.Client),
                Employee = ConvertFromEmployeeModel(caseEntity.Employee),
                AppliedServices = caseEntity.AppliedServices.Select(ConvertFromAppliedServiceModel).ToList(),
            };
            return caseUIModel;
        }

        public UIModels.UiClient ConvertFromClientModel(Models.Client clientEntity)
        {
            UIModels.UiClient clientUIModel = new UIModels.UiClient
            {
                Id = clientEntity.ID,
                Firstname = clientEntity.Firstname,
                Lastname = clientEntity.Lastname,
                Sex = clientEntity.Sex,
                Birthday = clientEntity.Birthday,
                Email = clientEntity.Email,
                PhoneNumber = clientEntity.PhoneNumber,
                Address = clientEntity.Address,
                Subscribed = clientEntity.Subscribed,
                //Cases = clientEntity.Cases.Select(ConvertFromCaseModel).ToList(), ----------- udkommenteret fordi den skaber et uendeligt loop
            };
            return clientUIModel;
        }

        public UIModels.UiEmployee ConvertFromEmployeeModel(Models.Employee employeeEntity)
        {
            UIModels.UiEmployee employeeUIModel = new UIModels.UiEmployee
            {
                Id = employeeEntity.Id,
                Firstname = employeeEntity.Firstname,
                Lastname = employeeEntity.Lastname,
                Sex = employeeEntity.Sex,
                WorkPosition = employeeEntity.WorkPosition,
                DateHired = employeeEntity.DateHired,
                Email = employeeEntity.Email,
                WorkPhone = employeeEntity.WorkPhone
            };
            return employeeUIModel;
        }

        public UIModels.UiEducation ConvertFromEducationModel(Models.Education educationEntity)
        {
            UIModels.UiEducation educationUIModel = new UIModels.UiEducation
            {
                Id = educationEntity.Id,
                EducationName = educationEntity.EducationName,
                Description = educationEntity.Description
            };
            return educationUIModel;
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
                WorkPhone = laywerEntity.WorkPhone,
                Educations = laywerEntity.Educations.Select(ConvertFromEducationModel).ToList(),            
            };
            return laywerUIModel;
        }

        public UIModels.UiService ConvertFromServiceModel(Models.Service serviceEntity)
        {
            UIModels.UiService serviceUIModel = new UIModels.UiService
            {
                Id = serviceEntity.Id,
                ServiceName = serviceEntity.ServiceName,
                Description = serviceEntity.Description,
                OneTimePayment = serviceEntity.OneTimePayment,
                StartPaymentDefault = serviceEntity.StartPaymentDefault,
                UnitCostDefault = serviceEntity.UnitCostDefault                
            };
            return serviceUIModel;
        }

        public UIModels.UiAppliedService ConvertFromAppliedServiceModel(Models.AppliedService appliedServiceEntity)
        {
            UIModels.UiAppliedService appliedServiceUIModel = new UIModels.UiAppliedService
            {
                Id = appliedServiceEntity.Id,
                Note = appliedServiceEntity.Note,
                UnitCount = appliedServiceEntity.UnitCount,
                StartPaymentActual = appliedServiceEntity.StartPaymentActual,
                UnitCostActual = appliedServiceEntity.UnitCostActual,
                ServicePerformed = appliedServiceEntity.ServicePerformed,
                Service = ConvertFromServiceModel(appliedServiceEntity.Service),
                Lawyer = ConvertFromLawyerModel(appliedServiceEntity.Lawyer)
            };
            return appliedServiceUIModel;
        }

        public UIModels.UiUnitType ConvertFromUnitTypeUIModel(UIModels.UiUnitType unitTypeEntity)
        {
            UIModels.UiUnitType unitTypeUIModel = new UIModels.UiUnitType
            {
                Id = unitTypeEntity.Id,
                Unit = unitTypeEntity.Unit
            };
            return unitTypeUIModel;
        }

        public UIModels.UiZipcode ConvertFromZipcodeMOdel(UIModels.UiZipcode zipCodeEntity)
        {
            UIModels.UiZipcode uiZipcode = new UIModels.UiZipcode()
            {
                Postal = zipCodeEntity.Postal,
                City = zipCodeEntity.City
            };
            return uiZipcode;
        }
    }
}

