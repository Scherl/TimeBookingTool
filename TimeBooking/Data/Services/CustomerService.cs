﻿using Microsoft.EntityFrameworkCore;
using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class CustomerService : ICustomerService
    {
        public readonly zeiterfassungContext Context;

        public CustomerService(zeiterfassungContext zeiterfassungContext)
        {
            Context = zeiterfassungContext;
        }

        public async Task<List<Client>> GetAllActiveCustomers()
        {
            var list = Context.Clients.Where(x =>
                x.IsActive == true);
            var test = await list.ToListAsync();
            return test;
        }
    }
}
