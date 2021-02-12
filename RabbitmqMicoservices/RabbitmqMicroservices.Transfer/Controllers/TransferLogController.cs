using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitmqMicroservice.Transfer.Application.Interfaces;
using RabbitmqMicroservices.Transfer.Domain.Models;

namespace RabbitmqMicroservices.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferLogController : ControllerBase
    {
        private readonly ITransferLogService _transferLogService;

        public TransferLogController(ITransferLogService transferLogService)
        {
            _transferLogService = transferLogService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_transferLogService.GetTransferLogs());
        }
    }
}
