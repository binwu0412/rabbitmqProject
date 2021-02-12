using Microsoft.EntityFrameworkCore;
using RabbitmqMicroservices.Transfer.Data.Context;
using RabbitmqMicroservices.Transfer.Domain.Interfaces;
using RabbitmqMicroservices.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservices.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.Transfers;
        }
    }
}
