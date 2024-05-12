using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic.DummyData
{
    internal class HardCodedData
    {
        // Instanser af alle lister:
        private List<Case> dummyCases = new List<Case>();
        private List<Client> dummyClients = new List<Client>();
        private List<AppliedService> dummyAppliedServices = new List<AppliedService>();
        private List<Service> dummyServices = new List<Service>();
        private List<Employee> dummyEmployees = new List<Employee>();
        private List<Lawyer> dummyLawyers = new List<Lawyer>();
        private List<Education> dummyEducations = new List<Education>();
        // Instanser af alle objekter.
        // Cases:
        private Case case1;
        private Case case2;
        private Case case3;
        private Case case4;
        private Case case5Closed;
        // Clients:
        private Client client1;
        private Client client2;
        private Client client3;
        private Client client4;
        private Client client5;
        // Secretarys & lawyers:
        private Employee employee1;
        private Employee employee2;
        private Lawyer lawyer1;
        private Lawyer lawyer2;
        private Lawyer lawyer3;
        private Lawyer lawyer4;
        private Lawyer lawyer5;
        private Lawyer lawyer6;
        // Speciale områder:
        private Education education1;
        private Education education2;
        private Education education3;
        private Education education4;
        private Education education5;
        // AppliedServices:
        private AppliedService appliedService1;
        private AppliedService appliedService2;
        private AppliedService appliedService3;
        private AppliedService appliedService4;
        private AppliedService appliedService5;
        private AppliedService appliedService6;
        private AppliedService appliedService7;
        private AppliedService appliedService8;
        private AppliedService appliedService9;
        private AppliedService appliedService10;
        // Services:
        private Service service1Special;
        private Service service2;
        private Service service3;
        private Service service4Special;
        private Service service5Special;

        internal HardCodedData()
        {
            LoadData();
            AddToLists();
        }

        // ------------ Get metoder -------------
        // Cases:
        public List<Case> GetCaseList()
        {
            return dummyCases;
        }
        // Clients:
        public List<Client> GetClientList()
        {
            return dummyClients;
        }
        // Employees:
        public List<Employee> GetEmployeeList()
        {
            return dummyEmployees;
        }
        // Lawyers:
        public List<Lawyer> GetLawyersList()
        {
            return dummyLawyers;
        }
        // AppliedServices:
        public List<AppliedService> GetAppliedServiceList()
        {
            return dummyAppliedServices;
        }
        // Service
        public List<Service> GetServiceList()
        {
            return dummyServices;
        }
        // Educations
        public List<Education> GetEducationList()
        {
            return dummyEducations;
        }


        // -------------------------------------------------------------------------- Hardcoded data --------------------------------------------------------------------
        private void LoadData()
        {
            // Clients:
            client1 = new Client { Firstname = "Anders", Lastname = "Jensen", Sex = 'M', Birthday = new DateTime(1990, 7, 15), Email = "anders.jensen@example.com", PhoneNumber = "12345678", Address = "Strandvej 1", Subscribed = true, };
            client2 = new Client { Firstname = "Maria", Lastname = "Nielsen", Sex = 'K', Birthday = new DateTime(1985, 4, 23), Email = "maria.nielsen@example.com", PhoneNumber = "87654321", Address = "Skovgade 5", Subscribed = false, };
            client3 = new Client { Firstname = "Thomas", Lastname = "Pedersen", Sex = 'M', Birthday = new DateTime(1978, 12, 3), Email = "thomas.pedersen@example.com", PhoneNumber = "45678901", Address = "Parkvej 12", Subscribed = true, };
            client4 = new Client { Firstname = "Line", Lastname = "Andersen", Sex = 'K', Birthday = new DateTime(1995, 10, 20), Email = "line.andersen@example.com", PhoneNumber = "23456789", Address = "Kirkestræde 8", Subscribed = false, };
            client5 = new Client { Firstname = "Michael", Lastname = "Mikkelsen", Sex = 'M', Birthday = new DateTime(1982, 3, 8), Email = "michael.mikkelsen@example.com", PhoneNumber = "34567890", Address = "Bredgade 3", Subscribed = true };

            // Speciale områder:
            education1 = new Education { EducationName = "Selvskabsret", Description = "Problemstillinger indenfor: Generel selskabsret, Selskabskonstruktion & -registrering, Bestyrelsesarbejde, Direktørkontrakter og Bonus- & incitamentprogrammer" };
            education2 = new Education { EducationName = "Boligret", Description = "Problemstillinger indenfor: Køb / salg af privatbolig & erhvervsejendom, Refusionsopgørelse & anden dokumentation og Lejekontrakter" };
            education3 = new Education { EducationName = "Aftaler & Kontrakter", Description = "Problemstillinger indenfor: Generel aftaleindgåelse, Samarbejdsaftaler, Salgs- & leveringsbetingelser og Købsaftaler & kontrakter" };
            education4 = new Education { EducationName = "Erstatningsret & Forsikringforhold", Description = "Problemstillinger indenfor: Markedsførings- & erstatningsret, Forsikringsret, Personskadeerstatning og Rejse- & transporterstatning" };
            education5 = new Education { EducationName = "Arbejds- & Ansættelseforhold", Description = "Problemstillinger indenfor: Ansættelseskontrakter, Arbejdsmiljø, Konkurrence- & kundeklausuler og Opsigelse/afskedigelse" };

            // Employee + Lawyers (Og 2 sekretære):
            employee1 = new Employee { Firstname = "John", Lastname = "Smith", Sex = 'M', WorkPosition = "Secretary", DateHired = new DateTime(2019, 5, 10), Email = "john.smith@example.com", WorkPhone = "12345678" };
            employee2 = new Employee { Firstname = "Emily", Lastname = "Brown", Sex = 'F', WorkPosition = "Secretary", DateHired = new DateTime(2020, 8, 20), Email = "emily.brown@example.com", WorkPhone = "23456789" };
            lawyer1 = new Lawyer { Firstname = "William", Lastname = "Johnson", Sex = 'M', WorkPosition = "Lawyer", DateHired = new DateTime(2018, 3, 15), Email = "william.johnson@example.com", WorkPhone = "34567890" };
            lawyer2 = new Lawyer { Firstname = "Olivia", Lastname = "Davis", Sex = 'F', WorkPosition = "Lawyer", DateHired = new DateTime(2021, 11, 5), Email = "olivia.davis@example.com", WorkPhone = "45678901", Educations = new List<Education> { education1, education2 } };
            lawyer3 = new Lawyer { Firstname = "James", Lastname = "Miller", Sex = 'M', WorkPosition = "Lawyer", DateHired = new DateTime(2022, 2, 25), Email = "james.miller@example.com", WorkPhone = "56789012", Educations = new List<Education> { education1, education2, education3 } };
            lawyer4 = new Lawyer { Firstname = "Sophia", Lastname = "Wilson", Sex = 'F', WorkPosition = "Lawyer", DateHired = new DateTime(2017, 9, 12), Email = "sophia.wilson@example.com", WorkPhone = "67890123", Educations = new List<Education> { education4 } };
            lawyer5 = new Lawyer { Firstname = "Daniel", Lastname = "Taylor", Sex = 'M', WorkPosition = "Lawyer", DateHired = new DateTime(2023, 6, 8), Email = "daniel.taylor@example.com", WorkPhone = "78901234", Educations = new List<Education> { education4, education5 } };
            lawyer6 = new Lawyer { Firstname = "Isabella", Lastname = "Martinez", Sex = 'F', WorkPosition = "Lawyer", DateHired = new DateTime(2016, 12, 30), Email = "isabella.martinez@example.com", WorkPhone = "89012345", Educations = new List<Education> { education5 } };

            // Services:
            service1Special = new Service { ServiceName = "Juridisk konsultation", Description = "En times konsultation med en advokat for at diskutere juridiske anliggender.", OneTimePayment = false, StartPaymentDefault = 0, UnitCostDefault = 1000.0 };
            service2 = new Service { ServiceName = "Dokumentudarbejdelse", Description = "Udarbejdelse af juridiske dokumenter såsom kontrakter, aftaler og testamenter.", OneTimePayment = true, StartPaymentDefault = 20000.0, UnitCostDefault = 0 };
            service3 = new Service { ServiceName = "Retshjælp", Description = "Hjælp og repræsentation i retssager såsom retssager og høringer.", OneTimePayment = false, StartPaymentDefault = 15000, UnitCostDefault = 0 };
            service4Special = new Service { ServiceName = "Juridisk forskning", Description = "Indgående forskning i juridiske spørgsmål for at støtte sagsstrategier og argumenter.", OneTimePayment = false, StartPaymentDefault = 0, UnitCostDefault = 750.0 };
            service5Special = new Service { ServiceName = "Mediation", Description = "Facilitering af forhandlinger mellem parterne for at nå gensidigt acceptable aftaler.", OneTimePayment = true, StartPaymentDefault = 5000.0, UnitCostDefault = 250.0 };

            // AppliedServices:
            appliedService1 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 3, UnitCostActual = 900, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special, Lawyer = lawyer1 };
            appliedService2 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 5, UnitCostActual = 1000, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special, Lawyer = lawyer1 };
            appliedService3 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 10, UnitCostActual = 850, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special, Lawyer = lawyer1 };
            appliedService4 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 6, UnitCostActual = 1000, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special, Lawyer = lawyer2 };
            appliedService5 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 20000, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service2, Lawyer = lawyer2 };
            appliedService6 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 19000, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service2, Lawyer = lawyer3 };
            appliedService7 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 15000, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service3, Lawyer = lawyer3 };
            appliedService8 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 13500, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service3, Lawyer = lawyer4 };
            appliedService9 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 12, UnitCostActual = 750, ServicePerformed = new DateTime(2024, 2, 28), Service = service4Special, Lawyer = lawyer5 };
            appliedService10 = new AppliedService { Note = "Journalnotat?", StartPaymentActual = 5000, UnitCount = 7, UnitCostActual = 250, ServicePerformed = new DateTime(2024, 2, 28), Service = service5Special, Lawyer = lawyer6 };

            // Cases:
            case1 = new Case { CaseName = "Udarbejdelse af kontrakt til salg af fast ejendom", CaseDescription = "Udarbejdelse af en juridisk bindende kontrakt mellem sælger og køber af en fast ejendom.", EstimatedEndDate = new DateTime(2024, 6, 30), StartDate = new DateTime(2024, 4, 15), CaseClosed = false, Client = client1, Employee = lawyer1, AppliedServices = new List<AppliedService> { appliedService1, appliedService2, appliedService3 } };
            case2 = new Case { CaseName = "Retssag vedrørende arbejdsret", CaseDescription = "Repræsentation af en klient i en retssag vedrørende arbejdsretlige spørgsmål.", EstimatedEndDate = new DateTime(2024, 7, 20), StartDate = new DateTime(2024, 5, 10), CaseClosed = false, Client = client1, Employee = lawyer2, AppliedServices = new List<AppliedService> { appliedService4, appliedService5 } };
            case3 = new Case { CaseName = "Testamentudarbejdelse og arvefordeling", CaseDescription = "Udarbejdelse af et juridisk gyldigt testamente og rådgivning om arvefordeling.", EstimatedEndDate = new DateTime(2024, 8, 15), StartDate = new DateTime(2024, 6, 1), CaseClosed = false, Client = client2, Employee = lawyer3, AppliedServices = new List<AppliedService> { appliedService6 } };
            case4 = new Case { CaseName = "Tvist om kontraktbrud", CaseDescription = "Løsning af en tvist mellem parterne vedrørende påstået kontraktbrud.", EstimatedEndDate = new DateTime(2024, 9, 30), StartDate = new DateTime(2024, 7, 20), CaseClosed = false, Client = client3, Employee = lawyer4 };
            case5Closed = new Case { CaseName = "Juridisk rådgivning om erhvervsret", CaseDescription = "Juridisk rådgivning til virksomheder om erhvervsretlige spørgsmål.", EstimatedEndDate = new DateTime(2022, 10, 15), StartDate = new DateTime(2020, 8, 1), CaseClosed = true, Client = client4, Employee = lawyer5, AppliedServices = new List<AppliedService> { appliedService7, appliedService8, appliedService9, appliedService10 } };
        }

        private void AddToLists()
        {
            dummyCases.AddRange(new List<Case> { case1, case2, case3, case4, case5Closed });
            dummyClients.AddRange(new List<Client> { client1, client2, client3, client4, client5 });
            dummyAppliedServices.AddRange(new List<AppliedService> { appliedService1, appliedService2, appliedService3, appliedService4, appliedService5, appliedService6, appliedService7, appliedService8, appliedService9, appliedService10 });
            dummyServices.AddRange(new List<Service> { service1Special, service2, service3, service4Special, service5Special });
            dummyEmployees.AddRange(new List<Employee> { employee1, employee2, lawyer2, lawyer3, lawyer4, lawyer5, lawyer6, lawyer1 });
            dummyLawyers.AddRange(new List<Lawyer> { lawyer1, lawyer2, lawyer3, lawyer4, lawyer5, lawyer6 });
            dummyEducations.AddRange(new List<Education> { education1, education2, education3, education4, education5, });

        }


    }
}
