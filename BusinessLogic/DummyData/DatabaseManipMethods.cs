using BusinessLogic.BusinessLogic;
using BusinessLogic.Converters;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.DummyData
{
    public class DatabaseManipMethods
    {
        SqlDbContext sqlDbContext;
        HardCodedData data;

        public DatabaseManipMethods()
        {
            sqlDbContext = new SqlDbContext();
            data = new HardCodedData();
        }

        public void CreateAllDataAsync()
        {
            CreateClientsInDatabase();
            CreateEmployeesInDatabase();
            CreateLawyersInDatabase();
            CreateServicesInDatabase();
            CreateEducationsInDatabase();
            CreateCasesInDatabase();
            CreateAppliedServicesInDatabase();

            sqlDbContext.SaveChanges();
        }

        // ---------------------------------------- Create metoder til dummy data ------------------------------
        public void CreateClientsInDatabase()
        {
            List<Client> dummyClients = new List<Client>();
            dummyClients = data.GetClientList();
            foreach (var client in dummyClients)
            {
                sqlDbContext.Clients.Add(client);
            }
        }

        public void CreateEmployeesInDatabase()
        {
            List<Employee> dummyEmployees = new List<Employee>();
            dummyEmployees = data.GetEmployeeList();

            foreach (Employee employee in dummyEmployees)
            {
                sqlDbContext.Employees.Add(employee);
            }
        }

        public void CreateLawyersInDatabase()
        {
            List<Lawyer> dummyLawyer = new List<Lawyer>();
            dummyLawyer = data.GetLawyersList();

            foreach (Lawyer lawyer in dummyLawyer)
            {
                sqlDbContext.Lawyers.Add(lawyer);
            }
        }

        public void CreateServicesInDatabase()
        {
            List<Service> dummyService = new List<Service>();
            dummyService = data.GetServiceList();

            foreach (Service service in dummyService)
            {
                sqlDbContext.Services.Add(service);
            }
        }

        public void CreateAppliedServicesInDatabase()
        {
            List<AppliedService> dummyAppliedServices = new List<AppliedService>();
            dummyAppliedServices = data.GetAppliedServiceList();

            foreach (AppliedService appliedService in dummyAppliedServices)
            {
                sqlDbContext.AppliedServices.Add(appliedService);
            }
        }

        public void CreateCasesInDatabase()
        {
            List<Case> dummyCases = new List<Case>();
            dummyCases = data.GetCaseList();

            foreach (Case Case in dummyCases)
            {
                sqlDbContext.Cases.Add(Case);
            }
        }

        public void CreateEducationsInDatabase()
        {
            List<Education> dummyEducations = new List<Education>();
            dummyEducations = data.GetEducationList();

            foreach (Education education in dummyEducations)
            {
                sqlDbContext.Educations.Add(education);
            }
        }


        // ------------------------------------------------------ Clear Database --------------------------------------
        public async Task ClearAllDataAsync()
        {
            await sqlDbContext.ClearAllDataAsync();
        }


    }
}
