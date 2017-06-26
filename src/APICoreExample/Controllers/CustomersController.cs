using APICoreExample.Models;
using Microsoft.AspNetCore.Mvc;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace APICoreExample.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        TestDBContext _db = new TestDBContext();
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _db.Customer.ToAsyncEnumerable().ToList();

            return Ok(result);
        }

        [Route("{id:int}")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            //return Ok(await _db.Customer.FindAsync(id));
            return Ok(await _db.Customer.FirstOrDefaultAsync(c => c.Id.Equals(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Customer customer)
        {
            await _db.Customer.AddAsync(customer);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
