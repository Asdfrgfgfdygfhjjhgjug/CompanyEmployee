using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompanyEmployee.Services.Contracts;
using CompanyEmployee.Services.Models;
using System.Net.Http;

namespace CompanyEmployee.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            IEnumerable<AllCompanyModel> companies = null;
            using (var client = new HttpClient())
            {
                var allCompanys = client.GetAsync("https://localhost:44352/api/Company");

            allCompanys.Wait();
            var result = allCompanys.Result;

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<AllCompanyModel>>();
                readTask.Wait();
                companies = readTask.Result;
            }
            else
            {
                companies = Enumerable.Empty<AllCompanyModel>();
                ModelState.AddModelError(string.Empty, "Server error");
            }

            //var allCompanys = await this.companyService.All();
        }
            return View(companies);
        }

        public IActionResult Details(int id)
        {
            CompanyServiceModel companyModel = null;
            using (var client = new HttpClient())
            {
                var details = client.GetAsync("https://localhost:44352/api/Company/" + id);

                details.Wait();
                var result = details.Result;
                result.Content.ReadAsAsync<CompanyServiceModel>();

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<CompanyServiceModel>();
                    readTask.Wait();
                    companyModel = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error");
                }
            }
            return View(companyModel);
        }

        //public async Task<IActionResult> Delete(int id)
        //{
        //    await this.companyService.Delete(id);
        //    return RedirectToAction(nameof(HomeController.Index), "Home");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(CompanyRequestModel model)
        //{
        //    var user = await this.companyService.Exists(model.Id);
        //    if (user == true)
        //    {
        //        this.ModelState.AddModelError(string.Empty, "Company exists");
        //    }

        //    await this.companyService.Create(model);

        //    this.TempData.AddSuccessMessage("Company created successfully.");

        //    return this.RedirectToAction(
        //        nameof(HomeController.Index), "Home");
        //}

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
