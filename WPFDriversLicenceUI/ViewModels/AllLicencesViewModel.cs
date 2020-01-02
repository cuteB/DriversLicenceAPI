using Caliburn.Micro;
using DriversLicenceAPI.BusinessLogic;
using DriversLicenceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDriversLicenceUI.Models;

namespace WPFDriversLicenceUI.ViewModels
{
    class AllLicencesViewModel
    {
        public BindableCollection<DriversLicence> DriversLicences { get; set; }

        public AllLicencesViewModel()
        {
            DriversLicences = new BindableCollection<DriversLicence>();
            List<DriversLicence> data = DriversLicenceProcessor.LoadDriversLicences();
            foreach (var item in data)
            {
                DriversLicences.Add(item);
            }

        }


    }
}
