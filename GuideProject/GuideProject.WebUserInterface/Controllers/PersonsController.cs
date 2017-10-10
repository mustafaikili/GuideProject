using GuideProject.Business.Abstract;
using GuideProject.DataAccess.Concrete.EntityFramework;
using GuideProject.Model.Entities;
using GuideProject.WebUserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuideProject.WebUserInterface.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonService _personService;
        public PersonsController(IPersonService personService)
        {
            _personService = personService;

        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(PersonViewModel model)
        {
            Persons person = model.Person;
            try
            {
                _personService.Add(person);
            }
            catch (Exception)
            {
            }
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public ActionResult PersonUpdate(int? PersonID)
        {
            PersonViewModel person = new PersonViewModel();
            if (PersonID != null)
                person.Person = _personService.GetByID(PersonID);
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PersonUpdate(PersonViewModel model)
        {
            if (model != null)
            {
                try
                {
                    _personService.Update(model.Person);
                }
                catch (Exception)
                {
                }
            }
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public ActionResult PersonDelete(int ID)
        {
            PersonViewModel personViewModel = new PersonViewModel { Person = _personService.GetByID(ID)};
            return View(personViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken,ActionName("PersonDelete")]
        public ActionResult PersonDeleted(int ID)
        {
            if(ModelState.IsValid)
            {
                _personService.Delete(_personService.GetByID(ID));
            }
            return Redirect("/Home/Index");
        }
    }
}