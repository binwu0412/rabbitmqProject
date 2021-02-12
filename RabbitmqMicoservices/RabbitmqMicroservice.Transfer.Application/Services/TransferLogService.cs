using RabbitmqMicroservice.Transfer.Application.Interfaces;
using RabbitmqMicroservices.Transfer.Domain.Interfaces;
using RabbitmqMicroservices.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservice.Transfer.Application.Services
{
    public class TransferLogService : ITransferLogService
    {
        private readonly ITransferRepository _transferRepository;

        public TransferLogService(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
