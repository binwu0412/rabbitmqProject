using RabbitmqMicroservices.Banking.Data.Context;
using RabbitmqMicroservices.Banking.Domain.Interfaces;
using RabbitmqMicroservices.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservices.Banking.Data.Reppository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
