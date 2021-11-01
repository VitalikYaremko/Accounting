using Accounting.Data.Interfaces.Services;
using Accounting.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Accounting.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet, Route("~/api/employee")]
        public async Task<IHttpActionResult> GetAll()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        [HttpGet, Route("~/api/employee/{id}")]
        public async Task<IHttpActionResult> Get(Guid id)
        {
            var employee = await _employeeService.GetById(id);

            return Ok(employee);
        }

        [HttpPost, Route("~/api/employee")]
        public async Task<IHttpActionResult> CreateEmployee([FromBody] Employee employee)
        {
            var model = await _employeeService.Create(employee);

            return Ok(model);
        }

        [HttpPut, Route("~/api/employee")]
        public async Task<IHttpActionResult> UpdateEmployee(int id, [FromBody] string value)
        {
            return Ok();
        }

        [HttpDelete, Route("~/api/employee")]
        public async Task<IHttpActionResult> Delete(Guid id)
        {
            return Ok();
        }
    }
}