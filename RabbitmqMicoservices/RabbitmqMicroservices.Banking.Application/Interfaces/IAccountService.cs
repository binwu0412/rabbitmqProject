using RabbitmqMicroservices.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservices.Banking.Application.Services
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
