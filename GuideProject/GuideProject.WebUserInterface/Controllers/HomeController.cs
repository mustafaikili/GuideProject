
using GuideProject.Business.Abstract;
using GuideProject.DataAccess.Concrete.EntityFramework;
using GuideProject.WebUserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuideProject.WebUserInterface.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;
        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel { Person = _personService.GetList() };
            return View(model);
        }
	}
}