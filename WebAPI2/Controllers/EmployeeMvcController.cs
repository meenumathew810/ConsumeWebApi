using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    public class EmployeeMvcController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            BasicsEntities DbContext = new BasicsEntities(); 
            List<Employee> employee = DbContext.Employees.OrderBy(c => c.Name).ToList();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53689/api/");
            IEnumerable<Employee> emp = null;
            var responseTask = client.GetAsync("Employee");
            responseTask.Wait();
            var result = responseTask.Result;
            var readTask = result.Content.ReadAsAsync<IList<Employee>>();
            readTask.Wait();
            emp = readTask.Result;
            return View(emp);

            //IEnumerable<Employee> emp = null;

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:53689/api/");
            //    //HTTP GET
            //    var responseTask = client.GetAsync("GetEmployee");
            //    responseTask.Wait();

            //    var result = responseTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<IList<Employee>>();
            //        readTask.Wait();
            //        emp = readTask.Result;
            //    }
            //    else //web api sent error response 
            //    {
            //        //log response status here..

            //        emp = Enumerable.Empty<Employee>();

            //        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            //    }
            //}
            //return View(emp);
        }
    }
}