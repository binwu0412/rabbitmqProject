using RabbitmqMicroservices.Banking.Application.Models;
using RabbitmqMicroservices.Banking.Domain.Commands;
using RabbitmqMicroservices.Banking.Domain.Interfaces;
using RabbitmqMicroservices.Banking.Domain.Models;
using RabbitmqMicroservices.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }


        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand
                (
                    accountTransfer.FromAccount, 
                    accountTransfer.ToAccount, 
                    accountTransfer.TransferAmount
                );

            _bus.SendCommand<CreateTransferCommand>(createTransferCommand);
        }
    }
}
