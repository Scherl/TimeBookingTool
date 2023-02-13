using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IMitarbeiterService
    {
       public Task<Mitarbeiter> GetMitarbeiterByNameAsync(string name);

    }
}
