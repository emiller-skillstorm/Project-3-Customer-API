using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerTestAPI.Data;
using CustomerTestAPI.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerTestAPI.Api.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class CustomersController : ControllerBase
        {
            private readonly CustomerContext _context;

            public CustomersController(CustomerContext context)
            {
                _context = context;
            }

            // GET: api/Customers
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
            {
                return await _context.Customers.Include(c => c.Address).ThenInclude(a => a.Coord).ToListAsync();
            }

            // GET: api/Customers/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Customer>> GetCustomer(int id)
            {
                var Customer = await _context.Customers.FindAsync(id);

                if (Customer == null)
                {
                    return NotFound();
                }

                return Customer;
            }

            // GET: api/Customers/5
            [HttpGet("phone/{phone}")]
            public async Task<ActionResult<Customer>> GetCustomerByPhone(string phone)
            {
            
                var Customer = await _context.Customers.Where(c => c.Phone == phone).Include(c => c.Address).ThenInclude(a => a.Coord).ToListAsync();
                Console.WriteLine("Hello");
                if (Customer == null)
                {
                    return NotFound();
                }
                
                return Customer.FirstOrDefault();
            }


            // PUT: api/Customers/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutCustomer(int id, Customer Customer)
            {
                if (id != Customer.Id)
                {
                    return BadRequest();
                }
                var Address = Customer.Address;
                if(Address == null)
                {
                    return BadRequest();
                }

                _context.Entry(Customer).State = EntityState.Modified;
                _context.Entry(Address).State = EntityState.Modified;
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            return NoContent();
            }

            // POST: api/Customers
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<Customer>> PostCustomer(Customer Customer)
            {
                _context.Customers.Add(Customer);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCustomer", new { id = Customer.Id }, Customer);
            }

            // DELETE: api/Customers/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCustomer(int id)
            {
                var Customer = await _context.Customers.FindAsync(id);
                if (Customer == null)
                {
                    return NotFound();
                }

                _context.Customers.Remove(Customer);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool CustomerExists(int id)
            {
                return _context.Customers.Any(e => e.Id == id);
            }
        }
    }
