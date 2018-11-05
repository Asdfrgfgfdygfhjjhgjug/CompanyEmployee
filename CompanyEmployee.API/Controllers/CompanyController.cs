namespace CompanyEmployee.API.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Routing;

    using CompanyEmployee.Services.Models;
    using CompanyEmployee.Services.Contracts;
    using CompanyEmployee.API.Infrastructure.Filters;
    using CompanyEmployee.API.Infrastructure.Extensions;
    
    public class CompanyController : BaseApiController
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => this.OkOrNotFound(await this.companyService.All());

        [HttpGet]
        [Route("{id:int:min(1)}")]
        public async Task<IActionResult> Get(int id)
           => this.OkOrNotFound(await this.companyService.Details(id));

        [HttpDelete("{id:int:min(1)}")]
        public async Task<IActionResult> Delete(int id)
        {
            var categoryExists = await this.companyService.Exists(id);
            if (!categoryExists)
            {
                return NotFound("Category does not exist.");
            }

            await this.companyService.Delete(id);

            return Ok();
        }

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Post([FromBody]CompanyRequestModel model)
        {
            var categoryNameExists = await this.companyService.Exists(model.Name);
            if (categoryNameExists)
            {
                this.ModelState.AddModelError(nameof(CompanyRequestModel.Name), "Company name already exists.");
                return BadRequest(this.ModelState);
            }

            var id = await this.companyService.Create(model);

            return this.Ok(id);
        }

        [HttpPut("{id:int:min(1)}")]
        [ValidateModelState]
        public async Task<IActionResult> Put(int id, [FromBody]CompanyRequestModel model)
        {
            var categoryExists = await this.companyService.Exists(id);
            if (!categoryExists)
            {
                return NotFound("Company does not exist");
            }

            var categoryNameExists = await this.companyService.Exists(id, model.Name);
            if (categoryNameExists)
            {
                this.ModelState.AddModelError(nameof(CompanyRequestModel.Name), "Company name already exists");
                return BadRequest(this.ModelState);
            }

            await this.companyService.Update(id, model);

            return Ok();
        }
    }
}
