using EPM_UI.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPM_UI.Controllers.UserInterface
{
    
    public class EntryPointInterface : Controller
    {
        public IActionResult LoggedIn()
        {
            return View("~/Views/UserInterfaces/CommonEntryInterface.cshtml");
        }
    }
}
