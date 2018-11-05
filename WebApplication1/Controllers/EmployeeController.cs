using CompanyEmployee.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HttpClient httpClient;

        private Uri BaseEndpoint { get; set; } = new Uri("https://localhost:44352/api/");

        public EmployeeController(/*Uri baseEndpoint*/)
        {
            httpClient = new HttpClient();

            //if (baseEndpoint == null)
            //{
            //    throw new ArgumentNullException("baseEndpoint");
            //}
            //BaseEndpoint = baseEndpoint;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var allCompanys = await this.employeeService.
        //    return View(allCompanys);
        //}

        //public IActionResult Edit(int id)
        //{
        //    var employee = this.employeeService.EmployeeById(id);

        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employee);
        //}

        //[HttpPost]
        //[ValidateModelState]
        //public IActionResult Edit(EmployeeDetailsModel employee)
        //{
        //    this.employeeService.Edit(employee);
        //    return RedirectToAction(nameof(HomeController.Index), "Home");
        //}

        //public IActionResult Edit(string id)
        //{
        //    var user = this.userService.UserById(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}

        //public async Task<IActionResult> Details(int id)
        //{
        //    var companyDetails = await this.employeeService.Details(id);
        //    return View(companyDetails);
        //}

        //public async Task<IActionResult> Delete(int id)
        //{
        //    await this.employeeService.Delete(id);
        //    return RedirectToAction(nameof(HomeController.Index), "Home");
        //}

        public IActionResult Create(int id)
            => this.View(new EmployeeRequestModel { CompanyId = id });

        [HttpPost]
        public IActionResult Create(EmployeeRequestModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,  "Employee"));
            var response = httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<EmployeeRequestModel>(model));

            return this.RedirectToAction("Create", "Employee", new {id = model.CompanyId});
        }
 
        //public async Task<List<UsersModel>> GetUsers()
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "User/GetAllUsers"));
        //    return await GetAsync<List<UsersModel>>(requestUrl);
        //}

        //public async Task<Message<EmployeeRequestModel>> Create(EmployeeRequestModel model)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "User/SaveUser"));
        //    return await PostAsync<EmployeeRequestModel>(requestUrl, model);
        //}

        private async Task<T> GetAsync<T>(Uri requestUrl)
        {
            addHeaders();
            var response = await httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }

        /// <summary>
        /// Common method for making POST calls
        /// </summary>
        private async Task<Message<T>> PostAsync<T>(Uri requestUrl, T content)
        {
            addHeaders();
            var response = await httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<T>(content));
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Message<T>>(data);
        }
        private async Task<Message<T1>> PostAsync<T1, T2>(Uri requestUrl, T2 content)
        {
            addHeaders();
            var response = await httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<T2>(content));
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Message<T1>>(data);
        }

        public Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            var endpoint = new Uri(BaseEndpoint, relativePath);

            var uriBuilder = new UriBuilder(endpoint);
            uriBuilder.Query = queryString;
            return uriBuilder.Uri;
        }

        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }

        private void addHeaders()
        {
            httpClient.DefaultRequestHeaders.Remove("userIP");
            httpClient.DefaultRequestHeaders.Add("userIP", "84.40.90.98");
        }
    }
}

