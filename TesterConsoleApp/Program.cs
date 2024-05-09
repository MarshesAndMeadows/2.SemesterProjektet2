using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;

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

    // Create a new Education
    var education = new Education
    {
        EducationName = "Han er en fræk tømrer",
        Description = "Bachelor's degree in Law"
    };

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



