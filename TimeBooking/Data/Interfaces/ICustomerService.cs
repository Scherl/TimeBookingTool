using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Client>> GetAllActiveCustomers();
    }
}
