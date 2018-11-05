using CompanyEmployee.API.Infrastructure.Extensions;
using CompanyEmployee.API.Infrastructure.Filters;
using CompanyEmployee.Services.Contracts;
using CompanyEmployee.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployee.API.Controllers
{
    public class EmployeeController : BaseApiController
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //    => this.OkOrNotFound(await this.employeeService.All());

        [HttpGet]
        [Route("{id:int:min(1)}")]
        public IActionResult Get(int id)
           => this.OkOrNotFound(this.employeeService.EmployeeById(id));

        [HttpGet]
        [Route("{id:int:min(1)}")]
        public async Task<IActionResult> GetEmployees (int id)
         => this.OkOrNotFound(await this.employeeService.EmployeesInCompany(id));

        [HttpDelete("{id:int:min(1)}")]
        public async Task<IActionResult> Delete(int id)
        {
            var employeeExist = await this.employeeService.Exists(id);
            if (!employeeExist)
            {
                return NotFound("Category does not exist.");
            }

            await this.employeeService.Delete(id);

            return Ok();
        }
 
        [HttpGet("{id:int:min(1)}")]
        public IActionResult Edit(int id)
        {
            this.employeeService.EmployeeById(id);
            return Ok();
        }

        [HttpPost]
        [ValidateModelState]
        public IActionResult Edit(EmployeeRequestModel model)
        {
            this.employeeService.Create(model);
            return Ok();
        }
    }
}
