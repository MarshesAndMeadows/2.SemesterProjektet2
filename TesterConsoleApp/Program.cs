using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Net.Sockets;
using UIModels;

/*
using (var dbContext = new SqlDbContext())
{
    // Create a new Lawyer
    var lawyer = new Lawyer
    {
        Firstname = "Per",
        Lastname = "Pallesen",
        Sex = 'M',
        WorkPosition = "Senior Lawyer",
        DateHired = DateTime.Now,
        Email = "john.doe@example.com",
        WorkPhone = "123-456-7890"
    };

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

    // Add the Education to the Lawyer's Educations collection
    lawyer.Educations.Add(education);

    // Add the Lawyer to the Lawyers DbSet
    dbContext.Lawyers.Add(lawyer);

    // Save changes to the database
    dbContext.SaveChanges();

    Console.WriteLine("Lawyer created and saved to the database successfully.");
}
*/


using (var dbContext = new SqlDbContext())
{
    // Retrieve the lawyer from the database
    var lawyer = dbContext.Lawyers
        .Include(l => l.Educations) // Include related educations
        .FirstOrDefault();

    if (lawyer != null)
    {
        // Display lawyer information
        Console.WriteLine($"Lawyer Id: {lawyer.Id}");
        Console.WriteLine($"Name: {lawyer.Firstname} {lawyer.Lastname}");
        Console.WriteLine($"Sex: {lawyer.Sex}");
        Console.WriteLine($"Work Position: {lawyer.WorkPosition}");
        Console.WriteLine($"Date Hired: {lawyer.DateHired}");
        Console.WriteLine($"Email: {lawyer.Email}");
        Console.WriteLine($"Work Phone: {lawyer.WorkPhone}");

        // Display lawyer's educations
        Console.WriteLine("Educations:");
        foreach (var education in lawyer.Educations)
        {
            Console.WriteLine($"- {education.EducationName}: {education.Description}");
        }
    }
    else
    {
        Console.WriteLine("No lawyer found in the database.");
    }
}

await caseDb.CreateAsync(firstCase);*/




// ------------------------------------------------
Console.WriteLine("Done");
Console.ReadLine();