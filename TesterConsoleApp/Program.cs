using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Net.Sockets;
using UIModels;
using BusinessLogic;
using BusinessLogic.CRUD;
using System.Runtime.InteropServices;
using BusinessLogic.BusinessLogic;

BusinessLogic.CRUD.CaseBL caseBL = new CaseBL();
BusinessLogic.BusinessLogic.ClientBL clientBL = new ClientBL();
BusinessLogic.BusinessLogic.EmployeeBL employeeBL = new EmployeeBL();
BusinessLogic.BusinessLogic.LawyerBL lawyerBL = new LawyerBL();
BusinessLogic.BusinessLogic.EducationBL educationBL = new EducationBL();
BusinessLogic.BusinessLogic.ServiceBL serviceBL = new ServiceBL();
BusinessLogic.BusinessLogic.AppliedServiceBL appliedServiceBL = new AppliedServiceBL();


// --------------------------------- Test af alle 'GetOne' metoder ------------------------------------------------
UiCase caseTest = new UiCase();
caseTest = await caseBL.GetOneAsync(1);

UiClient clientTest = new UiClient();
clientTest = await clientBL.GetOneAsync(1);

UiEmployee employeeTest = new UiEmployee();
employeeTest = await employeeBL.GetOneAsync(1);

UiLawyer lawyerTest = new UiLawyer();
lawyerTest = await lawyerBL.GetOneAsync(3);

UiEducation education = new UiEducation();
education = await educationBL.GetOneAsync(1);

UiService service = new UiService();
service = await serviceBL.GetOneAsync(1);

UiAppliedService appliedService = new UiAppliedService();
appliedService = await appliedServiceBL.GetOneAsync(1);


// ------------------------------ Test af alle 'GetList' metoder ----------------------------------------------------------

List<UiCase> caselist = new List<UiCase>();
caselist = await caseBL.GetAllAsync();

List<UiClient> clientlist = new List<UiClient>();
clientlist = await clientBL.GetAllAsync();

List<UiEmployee> employeelist = new List<UiEmployee>();
employeelist = await employeeBL.GetAllAsync();

List<UiLawyer> lawyerlist = new List<UiLawyer>();
lawyerlist = await lawyerBL.GetAllAsync();

List<UiEducation> educationlist = new List<UiEducation>();
educationlist = await educationBL.GetAllAsync();

List<UiService> servicelist = new List<UiService>();
servicelist = await serviceBL.GetAllAsync();

List<UiAppliedService> appliedServicelist = new List<UiAppliedService>();
appliedServicelist = await appliedServiceBL.GetAllAsync();




// ------------------------------------------------
Console.WriteLine("Done");
Console.ReadLine();