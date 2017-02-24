using APICoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICoreExample.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController:Controller
    {
        TestDBContext _db = new TestDBContext();
        public async Task<IActionResult> Get()
        {
            var result = await _db.Customer.ToAsyncEnumerable().ToList();

            return Ok(result);
        }
    }
}
