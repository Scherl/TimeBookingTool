using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services.BusinessComponents
{
    public class CustomerBusinessComponent
    {
        private readonly ICustomerService _customerService;

        public CustomerBusinessComponent(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<List<Client>> GetAllActiveCustomers()
        {
            var customers =  await _customerService.GetAllActiveCustomers();
            return customers;
        }
    }
}
