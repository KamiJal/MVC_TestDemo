﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using TestDemo.Utils;

namespace TestDemo.Controllers
{
    [Authorize(Roles = AppStrings.AppRoleNames.Admin)]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View("UserList");
        }
    }
}