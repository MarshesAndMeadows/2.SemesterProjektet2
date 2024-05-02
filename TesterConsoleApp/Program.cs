using DataAccess;
using Models;

Console.WriteLine("Goodmorning!");

Client tempClient = new Client { 
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


CaseDbAccess caseDb = new CaseDbAccess();

await caseDb.CreateAsync(firstCase);

Console.WriteLine("Done");
Console.ReadLine();