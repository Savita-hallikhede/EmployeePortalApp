using EmployeePortalApp.models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeePortalApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details(empData obj)
        {

            //Different ways to send data from Controller → View.

            //In ASP.NET Core MVC, you can pass data in multiple ways:

            //1.ViewBag
            /* ViewBag.FullName = FullName;
             ViewBag.Email = Email;
             ViewBag.Password = Password;
             ViewBag.ConfirmPassword = ConfirmPassword;*/



            //2.ViewData
            /* ViewData["FullName"] = FullName;
             ViewData["Email"] = Email;
             ViewData["Password"] = Password;
             ViewData["ConfirmPassword"] = ConfirmPassword;*/


            //3.List / Normal object
            /*List<string> employeeDetails = new List<string>();
            employeeDetails.Add(FullName);
            employeeDetails.Add(Email);
            employeeDetails.Add(Password);
            employeeDetails.Add(ConfirmPassword);
            return View(employeeDetails);*/


            //4.Strongly Typed Model(Best way): Model Binding.
            /*empData obj = new empData();
            obj.FullName = FullName;
            obj.Email = Email;
            obj.Password = Password;
            obj.ConfirmPassword = ConfirmPassword;
            return View(obj);*/

            return View(obj);

        }             
    }
}
