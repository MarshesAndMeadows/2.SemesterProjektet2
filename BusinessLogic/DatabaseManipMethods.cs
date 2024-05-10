﻿using BusinessLogic.BusinessLogic;
using BusinessLogic.Converters;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using Models;

namespace BusinessLogic
{
    public class DatabaseManipMethods
    {
        SqlDbContext sqlDbContext;
        UIModels.DummyData dummydb;
        ConvertFromUiModel converter;
        public DatabaseManipMethods()
        {
            sqlDbContext = new SqlDbContext();
            dummydb = new UIModels.DummyData();
            converter = new ConvertFromUiModel();
        }

        public async Task CreateAllDataAsync()
        {
            CreateClientsInDatabase(sqlDbContext);
            CreateEmployeesInDatabase(sqlDbContext);
            CreateLawyersInDatabase(sqlDbContext);
            CreateServicesInDatabase(sqlDbContext);
            //CreateAppliedServicesInDatabase(sqlDbContext);
            CreateCasesInDatabase(sqlDbContext);
        }

        public async Task ClearAllDataAsync()
        {
            await sqlDbContext.ClearAllDataAsync();
        }

        public void CreateClientsInDatabase(SqlDbContext dbContext)
        {
            List<UiClient> dummyUIClients = new List<UiClient>();
            dummyUIClients = dummydb.GetUIClientListAsync();

            foreach (UiClient client in dummyUIClients)
            {
                sqlDbContext.Clients.Add(converter.ConvertFromClientUIModel(client));
            }
            dbContext.SaveChanges();
        }

        public void CreateEmployeesInDatabase(SqlDbContext dbContext)
        {
            List<UiEmployee> dummyUIEmployees = new List<UiEmployee>();
            dummyUIEmployees = dummydb.GetUIEmployeeListAsync();

            foreach (UiEmployee employee in dummyUIEmployees)
            {
                sqlDbContext.Employees.Add(converter.ConvertFromEmployeeUIModel(employee));
            }
            dbContext.SaveChanges();
        }

        public void CreateLawyersInDatabase(SqlDbContext dbContext)
        {
            List<UiLawyer> dummyUILawyer = new List<UiLawyer>();
            dummyUILawyer = dummydb.GetUILawyersList();

            foreach (UiLawyer lawyer in dummyUILawyer)
            {
                sqlDbContext.Lawyers.Add(converter.ConvertFromLaywerUIModel(lawyer));
            }
            dbContext.SaveChanges();
        }
        public void CreateServicesInDatabase(SqlDbContext dbContext)
        {
            List<UiService> dummyUIService = new List<UiService>();
            dummyUIService = dummydb.GetUIServiceListAsync();

            foreach (UiService service in dummyUIService)
            {
                sqlDbContext.Services.Add(converter.ConvertFromServiceUIModel(service));
            }
            dbContext.SaveChanges();
        }

        public void CreateAppliedServicesInDatabase(SqlDbContext dbContext)
        {
            List<UiAppliedService> dummyUIAppliedServices = new List<UiAppliedService>();
            dummyUIAppliedServices = dummydb.GetUIAppliedServiceListAsync();

            foreach (UiAppliedService appliedService in dummyUIAppliedServices)
            {
                sqlDbContext.AppliedServices.Add(converter.ConvertFromAppliedServiceUIModel(appliedService));
            }
            dbContext.SaveChanges();
        }

        public void CreateCasesInDatabase(SqlDbContext dbContext)
        {
            List<UiCase> dummyUICases = new List<UiCase>();
            dummyUICases = dummydb.GetUICaseList();

            foreach (UiCase Case in dummyUICases)
            {
                sqlDbContext.Cases.Add(converter.ConvertFromCaseUIModel(Case));
            }
            dbContext.SaveChanges();
        }
    }
}
