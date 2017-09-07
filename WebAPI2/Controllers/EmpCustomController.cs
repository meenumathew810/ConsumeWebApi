using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    public class EmpCustomController : ApiController
    {

        //[HttpGet]
        //public HttpResponseMessage Get(int id)
        //{
        //    Employee employee = new Employee();
        //    using (var context = new BasicsEntities())
        //    {
        //        employee = context.Employees.Where(s => s.Id == id).FirstOrDefault();
        //    }
        //    if (employee == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound, id);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, employee);
        //}

        //[HttpGet]
        //public IHttpActionResult GetStudent(int id)
        //{
        //    Employee employee = new Employee();
        //    using (var context = new BasicsEntities())
        //    {
        //        employee = context.Employees.Where(s => s.Id == id).FirstOrDefault();
        //    }
        //    if (employee == null)
        //    {
        //        return new CustomResult("not found", Request, HttpStatusCode.NotFound);
        //    }
        //    return new CustomResult(employee.Name, Request, HttpStatusCode.Found);
        //}



    }

}
