using DriversLicenceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DriversLicenceAPI.BusinessLogic;

namespace DriversLicenceAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult RegisterLicence()
        {
            ViewBag.message = "Enter a Drivers Licence information";

            return View();
        }

        [HttpPost]
        public ActionResult RegisterLicence(DriversLicence model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = DriversLicenceProcessor.CreateDriversLicence(model.Id, model.FirstName, model.LastName, model.MiddleName, model.LicenceNumber,
                                        model.LicenceClass, model.StreetAddress, model.City, model.Province, model.PostalCode, model.Sex, model.EyeColour,
                                        model.HairColour, model.DobDay, model.DobMonth, model.DobYear, model.Height, model.Weight, model.ExpiryDay, model.ExpiryMonth,
                                        model.ExpiryYear);
                
            }

            return View();
        }

        public ActionResult ViewDriversLicences()
        {
            ViewBag.Message = "Licence List";
            var data = DriversLicenceProcessor.LoadDriversLicences();
            List<DriversLicence> Licences = new List<DriversLicence>();

            foreach (var row in data)
            {
                Licences.Add(new DriversLicence
                {
                    Id = row.Id,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    MiddleName = row.MiddleName,
                    LicenceNumber = row.LicenceNumber,
                    LicenceClass = row.LicenceClass,
                    StreetAddress = row.StreetAddress,
                    City = row.City,
                    Province = row.Province,
                    PostalCode = row.PostalCode,
                    Sex = row.Sex,
                    EyeColour = row.EyeColour,
                    HairColour = row.HairColour,
                    DobDay = row.DobDay,
                    DobMonth = row.DobMonth,
                    DobYear = row.DobYear,
                    Height = row.Height,
                    Weight = row.Weight,
                    ExpiryDay = row.ExpiryDay,
                    ExpiryMonth = row.ExpiryMonth,
                    ExpiryYear = row.ExpiryYear
                });
            }

            return View(Licences);

        }

    
    }
}
