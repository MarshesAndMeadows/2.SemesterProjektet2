using DataAccess;
using Models;
using System.Net.Sockets;
using UIModels;

Console.WriteLine("Goodmorning!");

// Divs. instancer:
CaseDbAccess caseDb = new CaseDbAccess();
/*DummyData dd = new DummyData();*/
// ----------------------------------------------------

// Relationer til 'Lawyer
Education Education1 = new Education { EducationName = "Selvskabsret", Description = "Problemstillinger indenfor: Generel selskabsret, Selskabskonstruktion & -registrering, Bestyrelsesarbejde, Direktørkontrakter og Bonus- & incitamentprogrammer" };
Education Education2 = new Education { EducationName = "Boligret", Description = "Problemstillinger indenfor: Køb / salg af privatbolig & erhvervsejendom, Refusionsopgørelse & anden dokumentation og Lejekontrakter" };

// Testing af modeller:
Employee employee1 = new Employee { Firstname = "John", Lastname = "Smith", Sex = 'M', WorkPosition = "Secretary", DateHired = new DateTime(2019, 5, 10), Email = "john.smith@example.com", WorkPhone = "12345678" };
Lawyer Lawyer2 = new Lawyer { Firstname = "Olivia", Lastname = "Davis", Sex = 'F', WorkPosition = "Lawyer", DateHired = new DateTime(2021, 11, 5), Email = "olivia.davis@example.com", WorkPhone = "45678901", Educations = new List<Education> { Education1, Education2 } };

await caseDb.CreateEmployeeAsync(employee1);
await caseDb.CreateLawyerAsync(Lawyer2);

Employee employee2 = await caseDb.GetOneEmployeeAsync(2);
Lawyer Lawyer3 = await caseDb.GetOneLawyerAsync(2);









/*Client tempClient = new Client { 
    Firstname = "Bob", 
    Lastname = "Baseline", 
    Sex='m', 
    Birthday = new DateTime(1983, 9, 17), 
    Email = "BobbyB@gmail,com", 
    PhoneNumber = "11223344", 
    Address = "Vejle 7100, Strandvej 142", 
    Subscribed = false };

Lawyer tempLawyer = new Lawyer {
    Firstname="Tim",
    Lastname="Test",
    Sex='m',
    WorkPosition="Lawyer",
    Email="TimT@gmail.com",
    WorkPhone="88888888",
    DateHired=new DateTime(2012,3,1)};

Case firstCase = new Case {
    CaseName="Skatteret",
    CaseClosed=false,
    StartDate=new DateTime(2022,8,4),
    EstimatedEndDate=new DateTime(2022,11,23),
    Employee=tempLawyer,
    Client=tempClient,};


await caseDb.CreateAsync(firstCase);*/





// ------------------------------------------------
Console.WriteLine("Done");
Console.ReadLine();