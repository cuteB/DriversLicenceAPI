using DriversLicenceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
            return driversLicences;
        }

        // GET: api/DriversLicence/5
        public DriversLicence Get(int id)
        {
            // don't call database here do in class library
            return driversLicences.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/DriversLicence
        public void Post(DriversLicence val)
        {
            driversLicences.Add(val);
        }

        // PUT: api/DriversLicence/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DriversLicence/5
        public void Delete(int id)
        {
            
        }
    }
}
