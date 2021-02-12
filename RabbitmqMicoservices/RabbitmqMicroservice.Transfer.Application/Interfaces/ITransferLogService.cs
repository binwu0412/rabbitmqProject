using RabbitmqMicroservices.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservice.Transfer.Application.Interfaces
{
    public interface ITransferLogService
    {

        IEnumerable<TransferLog> GetTransferLogs();
    }
}
