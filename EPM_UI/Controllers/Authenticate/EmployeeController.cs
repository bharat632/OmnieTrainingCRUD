using EPM.Core.UserManagement;
using EPM.Repository.UserManagementAuthenticate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPM_UI.Controllers.Authenticate
{
    public class EmployeeController : Controller
    {
        private readonly IAuthenticate authentication;

        public EmployeeController(IAuthenticate connectionAuthenticate)
        {
            authentication = connectionAuthenticate;
        }
        public IActionResult EmpForm()
        {
            return View("~/Views/Forms/EmployeeForm.cshtml");
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeRepository model)
        {
            var response = authentication.CreateEmployees(model);
            return View("~/Views/Forms/LoginUser.cshtml");
        }

        public IActionResult ShoWEmployees(EmployeeRepository model)
        {
            var response = authentication.CreateEmployees(model);
            return View("~/Views/Forms/LoginUser.cshtml");
        }


    }
}
