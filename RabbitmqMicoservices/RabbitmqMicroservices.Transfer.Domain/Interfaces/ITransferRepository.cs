using RabbitmqMicroservices.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservices.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        public IEnumerable<TransferLog> GetTransferLogs();
    }
}
