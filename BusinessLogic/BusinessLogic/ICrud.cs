using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUD
{
    /*        
       Hvorfor bruges <T>: Fordi det er et objekt vi modtager ex. UiModels.UiCase objekt

       Hvad er <T>: står for en generisk type af parameter(<T> er blot en syntax!) som skal ses som en placeholder for et objekt man endnu ikke kender til

       CreateAsync: metode returnere en bool og tager et objekt af typen T som arg (som er den UiModel man modtager)
       GetOneAsync: returnere en Task<T> som er det objekt med id der returneres fra databasen

       Fordele ved at bruge Interface<T>:
       SOLID:
       1. Single Responsible: Interface håndtere kun CRUD og intet andet
       2. Open Close: Hvis man vi ludvide med crud metoder til ex. DeleteAllAsync kan man blot oprette det i interface
       GRASP:
       1. Information Expert: Interface bliver information expert på HVORDAN classes SKAL implementer CRUD metoder
       2. High cohersion: CRUD metoderne i interfacet er relaterbare og giver derfor high cohersion        
     */


    internal interface ICrud<T>
    {       
        Task<bool> CreateAsync(T entity);
        Task<T> GetOneAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int idToDelete);        
    }
}
