using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Net.Sockets;
using UIModels;
using BusinessLogic;
using BusinessLogic.CRUD;

BusinessLogic.CRUD.CaseBL caseBL = new CaseBL();


UiCase caseTest = new UiCase();
caseTest = await caseBL.GetOneAsync(1);





// ------------------------------------------------
Console.WriteLine("Done");
Console.ReadLine();