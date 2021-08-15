using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        [HttpGet]
        public ToDoitem Get()
        {
            return new ToDoitem{
                id=1232546,
                name="Random"
                ,Iscomplet=false
            };
        }
    }
}