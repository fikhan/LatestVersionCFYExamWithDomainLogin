using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CFY_Exam.Controllers.Shared
{
    public class UserGroupController : Controller
    {
        public IActionResult GroupIndex()
        {
            return View();
        }
    }
}
