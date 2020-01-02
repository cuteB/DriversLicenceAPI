using DriversLicenceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DriversLicenceAPI.BusinessLogic;

namespace DriversLicenceAPI.Controllers
{
    public class DriversLicenceController : ApiController
    {
        List<DriversLicence> driversLicences = new List<DriversLicence>();


        public DriversLicenceController()
        {
        }

        // GET: api/DriversLicence
        public List<DriversLicence> Get()
        {
            return DriversLicenceProcessor.LoadDriversLicences();
        }

        // GET: api/DriversLicence/5
        public DriversLicence Get(int id)
        {
            // don't call database here do in class library
            driversLicences = Get();
            return driversLicences.Where(x => x.Id == id).FirstOrDefault();
        }
        
        // POST: api/DriversLicence
        [HttpPost]
        public void Post(DriversLicence model)
        {
            DriversLicenceProcessor.CreateDriversLicence(model.Id, model.FirstName, model.LastName, model.MiddleName, model.LicenceNumber,
                                        model.LicenceClass, model.StreetAddress, model.City, model.Province, model.PostalCode, model.Sex, model.EyeColour,
                                        model.HairColour, model.DobDay, model.DobMonth, model.DobYear, model.Height, model.Weight, model.ExpiryDay, model.ExpiryMonth,
                                        model.ExpiryYear);
           
        }

        // PUT: api/DriversLicence/5
        public void Put(int id, [FromBody]DriversLicence model)
        {
            DriversLicenceProcessor.UpdateDriversLicence(model.Id, model.FirstName, model.LastName, model.MiddleName, model.LicenceNumber,
                                        model.LicenceClass, model.StreetAddress, model.City, model.Province, model.PostalCode, model.Sex, model.EyeColour,
                                        model.HairColour, model.DobDay, model.DobMonth, model.DobYear, model.Height, model.Weight, model.ExpiryDay, model.ExpiryMonth,
                                        model.ExpiryYear);
        }

        // DELETE: api/DriversLicence/5
        public void Delete(int id)
        {
            DriversLicenceProcessor.DeleteDriversLicence(id);
        }
    }
}
