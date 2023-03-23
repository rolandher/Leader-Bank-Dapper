﻿using leader.bank.domain.Commands;
using leader.bank.domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leader.bank.domain.usecases.Gateways
{
    public interface ICustomerUseCase
    {
        Task<List<Customer>> GetCustomersAsync();

        Task<Customer> GetCustomerByIdAsync(int id);

        Task<InsertNewCustomer> CreateCustomerAsync(Customer customer);

    }
}
