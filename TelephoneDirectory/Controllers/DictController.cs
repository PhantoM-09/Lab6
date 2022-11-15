using Model;
using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelephoneDirectory.Controllers
{
    public class DictController : Controller
    {
        IPhoneDictionary repository;

        public DictController(IPhoneDictionary repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.PhoneRecords = repository.GetCollection();
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult AddSave(PhoneRecord phoneRecord)
        {
            repository.AddElement(phoneRecord);
            repository.SaveCollection();

            return Redirect("/Dict/Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            ViewBag.Id = id;

            PhoneRecord updatedPhoneRecord = repository.GetElement(id);
            ViewBag.LastName = updatedPhoneRecord.LastName;
            ViewBag.PhoneNumber = updatedPhoneRecord.PhoneNumber;

            return View(updatedPhoneRecord);
        }

        [HttpPost]
        public RedirectResult UpdateSave(PhoneRecord phoneRecord)
        {
            repository.UpdateElement(phoneRecord);
            repository.SaveCollection();

            return Redirect("/Dict/Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public RedirectResult DeleteSave(int id)
        {
            repository.DeleteElement(id);
            repository.SaveCollection();

            return Redirect("/Dict/Index");
        }
    }
}