using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetVSCode.Dtos.Exceptions;
using BackEndDotNetVSCode.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackEndDotNetVSCode.Controllers
{
    [Route("[controller]")]
    public class ApiControllerBase : ControllerBase
    {
        protected readonly ILogger _logger;

        public ApiControllerBase(ILogger logger)
        {
            _logger = logger;
        }

        protected ActionResult HandleException(Exception ex) 
        {
            if (ex is UserFriendlyException)
            {
                return BadRequest(new ResponseError (){Message = ex.Message});
            }
            _logger.LogError(ex, ex.Message);
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ResponseError() { Message = ex.Message, }
            );
        }
    }
}