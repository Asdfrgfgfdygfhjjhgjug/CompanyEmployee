using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompanyEmployee.Services.Contracts;
using CompanyEmployee.Services.Models;
using System.Net.Http;
using CompanyEmployee.Web.Models.Company;

namespace CompanyEmployee.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiClient client;

        public HomeController(IApiClient apiClient)
        {
            client = apiClient;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Companies> companies = null;
            var requestUrl = client.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Company"));
            companies = await client.GetAsync<List<Companies>>(requestUrl);

            return View(companies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var requestUrl = client.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Company/" + id));
            var details = await client.GetAsync<CompanyDetails>(requestUrl);
            return View(details);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var requestUrl = client.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Company/" + id));
            var details = await client.GetAsync<CompanyDetails>(requestUrl);
            return View(details);
        }

        //public async Task<IActionResult> Delete(int id)
        //{
        //    await this.companyService.Delete(id);
        //    return RedirectToAction(nameof(HomeController.Index), "Home");
        //}

        public ActionResult Create() 
            =>  this.View(new CreateCompany());
 
        [HttpPost]
        public async Task<IActionResult> Create(CreateCompany model)
        {
            var requestUrl = client.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Company"));
            var response = await client.PostAsync(requestUrl, model);
            return this.RedirectToAction(nameof(HomeController.Index), "Home");
        }

        //[HttpPost]
        //public async Task<IActionResult> Edit(CompanyRequestModel model)
        //{
        //    var user = await this.companyService.Exists(model.Id);
        //    if (user == true)
        //    {
        //        this.ModelState.AddModelError(string.Empty, "Company exists");
        //    }

        //    await this.companyService.Create(model);

        //    this.TempData.AddSuccessMessage("Company created successfully.");

        //    return this.RedirectToAction(
        //        nameof(HomeController.Index),
        //        "Home",
        //        routeValues: new { area = string.Empty });
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
