using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Data;

namespace SehirRehberi.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeesController : Controller
    {
            private DataContext _context;

            public EmployeesController(DataContext context)
            {
                _context = context;
            }

            
            [HttpGet]
            public async Task<ActionResult> GetEmployees()
            {
                var employees = await _context.Employees.ToListAsync();
                return Ok(employees);
            }

            [HttpGet("{id}")]
            public async Task<ActionResult> GetEmployee(int id)
            {
                var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
                return Ok(employee);
            }

            
            [HttpPost]
            public void Post([FromBody]string employee)
            {

            }

            
            [HttpPut("{id}")]
            public void Put(int id, [FromBody]string employee)
            {
            }

            
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }
