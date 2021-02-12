using Microsoft.EntityFrameworkCore;
using RabbitmqMicroservices.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservices.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options) 
        {
        
        }

        public DbSet<TransferLog> Transfers { get; set; }
    }
}
