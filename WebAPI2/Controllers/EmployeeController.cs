using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetEmployee()
        {
            BasicsEntities Db = new BasicsEntities();
            List<Employee> EmpList = new List<Employee>();
            EmpList = Db.Employees.ToList();
            return Ok(EmpList);
        }

        [HttpPost]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            BasicsEntities Db = new BasicsEntities();
            Db.Employees.Add(new Employee()
            {
                Name = employee.Name,
                Email = employee.Email,
                Phone = employee.Phone
            });
            Db.SaveChanges();
            return Ok("Post successfull!!");
        }
        [HttpPut]
        public IHttpActionResult PutEmployee(Employee employee)
        {
            BasicsEntities Db = new BasicsEntities();

            var EmpList = Db.Employees.Where(e => e.Id == employee.Id).FirstOrDefault();
            EmpList.Name = employee.Name;
            EmpList.Email = employee.Email;
            EmpList.Phone = employee.Phone;
            Db.SaveChanges();
            return Ok("Put successfull!!");
        }
        [HttpPost]
        public IHttpActionResult DeleteEmployee(int Id)
        {
            BasicsEntities Db = new BasicsEntities();
            var del = (from Item in Db.Employees where Item.Id == Id select Item).FirstOrDefault();
            Db.Employees.Remove(del);
            //var EmpList = Db.Employees.Where(e => e.Id == Id).FirstOrDefault();
            //Db.Entry(employee).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
            return Ok("Delete successfull!!");
        }
    }
}

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
//        return NotFound();
//    }
//    return Ok(employee);
//}