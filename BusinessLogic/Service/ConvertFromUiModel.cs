
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
                CaseClosed = caseUiEntity.CaseClosed,
                Client = ConvertFromClientUIModel(caseUiEntity.Client),
                Employee = ConvertFromEmployeeUIModel(caseUiEntity.Employee)
            };
            return caseModel;
        }

        public Models.Client ConvertFromClientUIModel(UIModels.UiClient clientUiEntity)
        {
            Models.Client clientModel = new Models.Client
            {
                ID = clientUiEntity.Id,
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

        public Models.Employee ConvertFromEmployeeUIModel(UIModels.UiEmployee employeeUiEntity)
        {
            Models.Employee employeeModel = new Models.Employee
            {
                Id = employeeUiEntity.Id,
                Firstname = employeeUiEntity.Firstname,
                Lastname = employeeUiEntity.Lastname,
                Sex = employeeUiEntity.Sex,
                WorkPosition = employeeUiEntity.WorkPosition,
                DateHired = employeeUiEntity.DateHired,
                Email = employeeUiEntity.Email,
                WorkPhone = employeeUiEntity.WorkPhone
            };
            return employeeModel;
        }

        public Models.Education ConvertFromEducationUIModel(UIModels.UiEducation educationUiEntity)
        {
            Models.Education educationModel = new Models.Education
            {
                Id = educationUiEntity.Id,
                EducationName = educationUiEntity.EducationName,
                Description = educationUiEntity.Description
                
            };
            return educationModel;
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

        public Models.UnitType ConvertFromUnitTypeUIModel(UIModels.UiUnitType unitTypeUiEntity)
        {
            Models.UnitType unitTypeModel = new Models.UnitType
            {
                Id = unitTypeUiEntity.Id,
                Unit = unitTypeUiEntity.Unit
            };
            return unitTypeModel;
        }

        public Models.Zipcode ConvertFromZipcodeMOdel(Models.Zipcode zipCodeUiEntity)
        {
            Models.Zipcode zipCodeModel = new Models.Zipcode()
            {
                Postal = zipCodeUiEntity.Postal,
                City = zipCodeUiEntity.City
            };
            return zipCodeModel;
        }

    }
}
