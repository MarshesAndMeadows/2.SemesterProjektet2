using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class DummyData
    {
        // Instanser af alle lister:
        private List<UiCase> dummyUICases = new List<UiCase>();
        private List<UiClient> dummyUIClients = new List<UiClient>();
        private List<UiAppliedService> dummyUIAppliedServices = new List<UiAppliedService>();
        private List<UiService> dummyUIServices = new List<UiService>();
        private List<UiEmployee> dummyUIEmployees = new List<UiEmployee>();
        private List<UiLawyer> dummyUILawyers = new List<UiLawyer>();

        // Instanser af alle objekter.
        // Cases:
        private UiCase case1;
        private UiCase case2;
        private UiCase case3;
        private UiCase case4;
        private UiCase case5Closed;
        // Clients:
        private UiClient client1;
        private UiClient client2;
        private UiClient client3;
        private UiClient client4;
        private UiClient client5;
        // Secretarys & lawyers:
        private UiEmployee employee1;
        private UiEmployee employee2;
        private UiLawyer uiLawyer1;
        private UiLawyer uiLawyer2;
        private UiLawyer uiLawyer3;
        private UiLawyer uiLawyer4;
        private UiLawyer uiLawyer5;
        private UiLawyer uiLawyer6;
        // Speciale områder:
        private UiEducation uiEducation1;
        private UiEducation uiEducation2;
        private UiEducation uiEducation3;
        private UiEducation uiEducation4;
        private UiEducation uiEducation5;
        // AppliedServices:
        private UiAppliedService appliedService1;
        private UiAppliedService appliedService2;
        private UiAppliedService appliedService3;
        private UiAppliedService appliedService4;
        private UiAppliedService appliedService5;
        private UiAppliedService appliedService6;
        private UiAppliedService appliedService7;
        private UiAppliedService appliedService8;
        private UiAppliedService appliedService9;
        private UiAppliedService appliedService10;
        // Services:
        private UiService service1Special;
        private UiService service2;
        private UiService service3;
        private UiService service4Special;
        private UiService service5Special;

        public DummyData()
        {
            LoadData();
            AddToLists();
        }

        // ------------ Get metoder -------------
        // Cases:
        public UiCase GetUICaseAsync(int id)
        {
            foreach (UiCase tempCase in dummyUICases)
            {
                if (tempCase.Id == id)
                {
                    return tempCase;
                }
            }
            return new UiCase();
        }

        public List<UiCase> GetUICaseListAsync()
        {
            return dummyUICases;
        }

        // Clients:
        public UiClient GetUIClient(int id)
        {
            foreach (UiClient tempClient in dummyUIClients)
            {
                if (tempClient.Id == id)
                {
                    return tempClient;
                }
            }
            return new UiClient();
        }

        public List<UiClient> GetUIClientListAsync()
        {
            return dummyUIClients;
        }

        // Employees:
        public UiEmployee GetUIEmployeeAsync(int id)
        {
            foreach (UiEmployee tempEmployee in dummyUIEmployees)
            {
                if (tempEmployee.Id == id)
                {
                    return tempEmployee;
                }
            }
            return new UiEmployee();
        }

        public List<UiEmployee> GetUIEmployeeListAsync()
        {
            return dummyUIEmployees;
        }

        // Lawyers:
        public UiLawyer GetUILawyerAsync(int id)
        {
            foreach (UiLawyer tempLawyer in dummyUILawyers)
            {
                if (tempLawyer.Id == id)
                {
                    return tempLawyer;
                }
            }
            return new UiLawyer();
        }


        public List<UiEmployee> GetDummyUIEmployeeListAsync()
        {
            return dummyUIEmployees;
        }


        // AppliedServices:
        public UiAppliedService GetUIAppliedServiceAsync(int id)
        {
            foreach (UiAppliedService tempAppliedService in dummyUIAppliedServices)
            {
                if (tempAppliedService.Id == id)
                {
                    return tempAppliedService;
                }
            }
            return new UiAppliedService();
        }

        public List<UiAppliedService> GetUIAppliedServiceListAsync()
        {
            return dummyUIAppliedServices;
        }

        // Service
        public UiService GetUIServiceAsync(int id)
        {
            foreach (UiService tempService in dummyUIServices)
            {
                if (tempService.Id == id)
                {
                    return tempService;
                }
            }
            return new UiService();
        }

        public List<UiService> GetUIServiceListAsync()
        {
            return dummyUIServices;
        }

        // ------------------------------------ Hardcoded data ------------------------------------------
        private void LoadData()
        {
            // Cases:
            case1 = new UiCase { Id = 1, CaseName = "Udarbejdelse af kontrakt til salg af fast ejendom", CaseDescription = "Udarbejdelse af en juridisk bindende kontrakt mellem sælger og køber af en fast ejendom.", EstimatedEndDate = new DateTime(2024, 6, 30), StartDate = new DateTime(2024, 4, 15), CaseClosed = false, Client = client1, Employee = uiLawyer1, AppliedServices = new List<UiAppliedService> { appliedService1, appliedService2, appliedService3 } };
            case2 = new UiCase { Id = 2, CaseName = "Retssag vedrørende arbejdsret", CaseDescription = "Repræsentation af en klient i en retssag vedrørende arbejdsretlige spørgsmål.", EstimatedEndDate = new DateTime(2024, 7, 20), StartDate = new DateTime(2024, 5, 10), CaseClosed = false, Client = client1, Employee = uiLawyer2, AppliedServices = new List<UiAppliedService> { appliedService4, appliedService5 } };
            case3 = new UiCase { Id = 3, CaseName = "Testamentudarbejdelse og arvefordeling", CaseDescription = "Udarbejdelse af et juridisk gyldigt testamente og rådgivning om arvefordeling.", EstimatedEndDate = new DateTime(2024, 8, 15), StartDate = new DateTime(2024, 6, 1), CaseClosed = false, Client = client2, Employee = uiLawyer3, AppliedServices = new List<UiAppliedService> { appliedService6 } };
            case4 = new UiCase { Id = 4, CaseName = "Tvist om kontraktbrud", CaseDescription = "Løsning af en tvist mellem parterne vedrørende påstået kontraktbrud.", EstimatedEndDate = new DateTime(2024, 9, 30), StartDate = new DateTime(2024, 7, 20), CaseClosed = false, Client = client3, Employee = uiLawyer4 };
            case5Closed = new UiCase { Id = 5, CaseName = "Juridisk rådgivning om erhvervsret", CaseDescription = "Juridisk rådgivning til virksomheder om erhvervsretlige spørgsmål.", EstimatedEndDate = new DateTime(2022, 10, 15), StartDate = new DateTime(2020, 8, 1), CaseClosed = true, Client = client4, Employee = uiLawyer5, AppliedServices = new List<UiAppliedService> { appliedService7, appliedService8, appliedService9, appliedService10 } };

            // Clients:
            client1 = new UiClient { Id = 1, Firstname = "Anders", Lastname = "Jensen", Sex = 'M', Birthday = new DateTime(1990, 7, 15), Email = "anders.jensen@example.com", PhoneNumber = "12345678", Address = "Strandvej 1", Subscribed = true, Cases = new List<UiCase> { case1, case2 } };
            client2 = new UiClient { Id = 2, Firstname = "Maria", Lastname = "Nielsen", Sex = 'K', Birthday = new DateTime(1985, 4, 23), Email = "maria.nielsen@example.com", PhoneNumber = "87654321", Address = "Skovgade 5", Subscribed = false, Cases = new List<UiCase> { case3 } };
            client3 = new UiClient { Id = 3, Firstname = "Thomas", Lastname = "Pedersen", Sex = 'M', Birthday = new DateTime(1978, 12, 3), Email = "thomas.pedersen@example.com", PhoneNumber = "45678901", Address = "Parkvej 12", Subscribed = true, Cases = new List<UiCase> { case4 } };
            client4 = new UiClient { Id = 4, Firstname = "Line", Lastname = "Andersen", Sex = 'K', Birthday = new DateTime(1995, 10, 20), Email = "line.andersen@example.com", PhoneNumber = "23456789", Address = "Kirkestræde 8", Subscribed = false, Cases = new List<UiCase> { case5Closed } };
            client5 = new UiClient { Id = 5, Firstname = "Michael", Lastname = "Mikkelsen", Sex = 'M', Birthday = new DateTime(1982, 3, 8), Email = "michael.mikkelsen@example.com", PhoneNumber = "34567890", Address = "Bredgade 3", Subscribed = true };

            // Employee + Lawyers (Og 2 sekretære):
            employee1 = new UiEmployee { Id = 1, Firstname = "John", Lastname = "Smith", Sex = 'M', WorkPosition = "Secretary", DateHired = new DateTime(2019, 5, 10), Email = "john.smith@example.com", WorkPhone = "12345678" };
            employee2 = new UiEmployee { Id = 2, Firstname = "Emily", Lastname = "Brown", Sex = 'F', WorkPosition = "Secretary", DateHired = new DateTime(2020, 8, 20), Email = "emily.brown@example.com", WorkPhone = "23456789" };
            uiLawyer1 = new UiLawyer { Id = 3, Firstname = "William", Lastname = "Johnson", Sex = 'M', WorkPosition = "Lawyer", DateHired = new DateTime(2018, 3, 15), Email = "william.johnson@example.com", WorkPhone = "34567890" };
            uiLawyer2 = new UiLawyer { Id = 4, Firstname = "Olivia", Lastname = "Davis", Sex = 'F', WorkPosition = "Lawyer", DateHired = new DateTime(2021, 11, 5), Email = "olivia.davis@example.com", WorkPhone = "45678901", Educations = new List<UiEducation> { uiEducation1, uiEducation2 } };
            uiLawyer3 = new UiLawyer { Id = 5, Firstname = "James", Lastname = "Miller", Sex = 'M', WorkPosition = "Lawyer", DateHired = new DateTime(2022, 2, 25), Email = "james.miller@example.com", WorkPhone = "56789012", Educations = new List<UiEducation> { uiEducation1, uiEducation2, uiEducation3 } };
            uiLawyer4 = new UiLawyer { Id = 6, Firstname = "Sophia", Lastname = "Wilson", Sex = 'F', WorkPosition = "Lawyer", DateHired = new DateTime(2017, 9, 12), Email = "sophia.wilson@example.com", WorkPhone = "67890123", Educations = new List<UiEducation> { uiEducation4 } };
            uiLawyer5 = new UiLawyer { Id = 7, Firstname = "Daniel", Lastname = "Taylor", Sex = 'M', WorkPosition = "Lawyer", DateHired = new DateTime(2023, 6, 8), Email = "daniel.taylor@example.com", WorkPhone = "78901234", Educations = new List<UiEducation> { uiEducation4, uiEducation5 } };
            uiLawyer6 = new UiLawyer { Id = 8, Firstname = "Isabella", Lastname = "Martinez", Sex = 'F', WorkPosition = "Lawyer", DateHired = new DateTime(2016, 12, 30), Email = "isabella.martinez@example.com", WorkPhone = "89012345", Educations = new List<UiEducation> { uiEducation5 } };

            // Speciale områder:
            uiEducation1 = new UiEducation { Id = 1, EducationName = "Selvskabsret", Description = "Problemstillinger indenfor: Generel selskabsret, Selskabskonstruktion & -registrering, Bestyrelsesarbejde, Direktørkontrakter og Bonus- & incitamentprogrammer" };
            uiEducation2 = new UiEducation { Id = 2, EducationName = "Boligret", Description = "Problemstillinger indenfor: Køb / salg af privatbolig & erhvervsejendom, Refusionsopgørelse & anden dokumentation og Lejekontrakter" };
            uiEducation3 = new UiEducation { Id = 3, EducationName = "Aftaler & Kontrakter", Description = "Problemstillinger indenfor: Generel aftaleindgåelse, Samarbejdsaftaler, Salgs- & leveringsbetingelser og Købsaftaler & kontrakter" };
            uiEducation4 = new UiEducation { Id = 4, EducationName = "Erstatningsret & Forsikringforhold", Description = "Problemstillinger indenfor: Markedsførings- & erstatningsret, Forsikringsret, Personskadeerstatning og Rejse- & transporterstatning" };
            uiEducation5 = new UiEducation { Id = 5, EducationName = "Arbejds- & Ansættelseforhold", Description = "Problemstillinger indenfor: Ansættelseskontrakter, Arbejdsmiljø, Konkurrence- & kundeklausuler og Opsigelse/afskedigelse" };

            // Services:
            service1Special = new UiService { Id = 1, ServiceName = "Juridisk konsultation", Description = "En times konsultation med en advokat for at diskutere juridiske anliggender.", OneTimePayment = false, StartPaymentDefault = 0, UnitCostDefault = 1000.0 };
            service2 = new UiService { Id = 2, ServiceName = "Dokumentudarbejdelse", Description = "Udarbejdelse af juridiske dokumenter såsom kontrakter, aftaler og testamenter.", OneTimePayment = true, StartPaymentDefault = 20000.0, UnitCostDefault = 0 };
            service3 = new UiService { Id = 3, ServiceName = "Retshjælp", Description = "Hjælp og repræsentation i retssager såsom retssager og høringer.", OneTimePayment = false, StartPaymentDefault = 15000, UnitCostDefault = 0 };
            service4Special = new UiService { Id = 4, ServiceName = "Juridisk forskning", Description = "Indgående forskning i juridiske spørgsmål for at støtte sagsstrategier og argumenter.", OneTimePayment = false, StartPaymentDefault = 0, UnitCostDefault = 750.0 };
            service5Special = new UiService { Id = 5, ServiceName = "Mediation", Description = "Facilitering af forhandlinger mellem parterne for at nå gensidigt acceptable aftaler.", OneTimePayment = true, StartPaymentDefault = 5000.0, UnitCostDefault = 250.0 };

            // AppliedServices:
            appliedService1 = new UiAppliedService { Id = 1, Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 3, UnitCostActual = 900, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special };
            appliedService2 = new UiAppliedService { Id = 2, Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 5, UnitCostActual = 1000, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special };
            appliedService3 = new UiAppliedService { Id = 3, Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 10, UnitCostActual = 850, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special };
            appliedService4 = new UiAppliedService { Id = 4, Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 6, UnitCostActual = 1000, ServicePerformed = new DateTime(2024, 2, 28), Service = service1Special };
            appliedService5 = new UiAppliedService { Id = 5, Note = "Journalnotat?", StartPaymentActual = 20000, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service2 };
            appliedService6 = new UiAppliedService { Id = 6, Note = "Journalnotat?", StartPaymentActual = 19000, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service2 };
            appliedService7 = new UiAppliedService { Id = 7, Note = "Journalnotat?", StartPaymentActual = 15000, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service3 };
            appliedService8 = new UiAppliedService { Id = 8, Note = "Journalnotat?", StartPaymentActual = 13500, UnitCount = 0, UnitCostActual = 0, ServicePerformed = new DateTime(2024, 2, 28), Service = service3 };
            appliedService9 = new UiAppliedService { Id = 9, Note = "Journalnotat?", StartPaymentActual = 0, UnitCount = 12, UnitCostActual = 750, ServicePerformed = new DateTime(2024, 2, 28), Service = service4Special };
            appliedService10 = new UiAppliedService { Id = 10, Note = "Journalnotat?", StartPaymentActual = 5000, UnitCount = 7, UnitCostActual = 250, ServicePerformed = new DateTime(2024, 2, 28), Service = service5Special };

            // Services:
            service1Special = new UiService { Id = 1, ServiceName = "Juridisk konsultation", Description = "En times konsultation med en advokat for at diskutere juridiske anliggender.", OneTimePayment = false, StartPaymentDefault = 0, UnitCostDefault = 1000.0 };
            service2 = new UiService { Id = 2, ServiceName = "Dokumentudarbejdelse", Description = "Udarbejdelse af juridiske dokumenter såsom kontrakter, aftaler og testamenter.", OneTimePayment = true, StartPaymentDefault = 20000.0, UnitCostDefault = 0 };
            service3 = new UiService { Id = 3, ServiceName = "Retshjælp", Description = "Hjælp og repræsentation i retssager såsom retssager og høringer.", OneTimePayment = false, StartPaymentDefault = 15000, UnitCostDefault = 0 };
            service4Special = new UiService { Id = 4, ServiceName = "Juridisk forskning", Description = "Indgående forskning i juridiske spørgsmål for at støtte sagsstrategier og argumenter.", OneTimePayment = false, StartPaymentDefault = 0, UnitCostDefault = 750.0 };
            service5Special = new UiService { Id = 5, ServiceName = "Mediation", Description = "Facilitering af forhandlinger mellem parterne for at nå gensidigt acceptable aftaler.", OneTimePayment = true, StartPaymentDefault = 5000.0, UnitCostDefault = 250.0 };
        }

        private void AddToLists()
        {
            dummyUICases.AddRange(new List<UiCase> { case1, case2, case3, case4, case5Closed });
            dummyUIClients.AddRange(new List<UiClient> { client1, client2, client3, client4, client5 });
            dummyUIAppliedServices.AddRange(new List<UiAppliedService> { appliedService1, appliedService2, appliedService3, appliedService4, appliedService5, appliedService6, appliedService7, appliedService8, appliedService9, appliedService10 });
            dummyUIServices.AddRange(new List<UiService> { service1Special, service2, service3, service4Special, service5Special });
            dummyUIEmployees.AddRange(new List<UiEmployee> { employee1, employee2 });
            dummyUILawyers.AddRange(new List<UiLawyer> { uiLawyer1, uiLawyer2, uiLawyer3, uiLawyer4, uiLawyer5, uiLawyer6 });

        }




    }
}