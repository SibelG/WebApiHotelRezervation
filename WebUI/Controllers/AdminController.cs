﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();   
        }

        public PartialViewResult PreloaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavHeaderPartial() {

            return PartialView();
        }
        public PartialViewResult SideBarHeaderPartial()
        {

            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {

            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {

            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {

            return PartialView();
        }
    }
}
