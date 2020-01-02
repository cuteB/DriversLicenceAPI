using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDriversLicenceUI.Models;

namespace WPFDriversLicenceUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
		private string _firstName = "Fuben";
		private string _lastName;
		private PersonModel _selectedPerson;
		private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();

		public ShellViewModel()
		{
			People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" , Id = 1});
			People.Add(new PersonModel { FirstName = "aoeu", LastName = "etete", Id = 2 });
			People.Add(new PersonModel { FirstName = "Ben", LastName = "Fu", Id = 3});
		}


		public string FirstName
		{
			get { return _firstName; }
			set { 
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set { 
				_lastName = value;
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string FullName
		{
			get { return $"{ FirstName } { LastName }"; }
		}

		public BindableCollection<PersonModel> People
		{
			get { return _people; }
			set { _people = value; }
		}

		public PersonModel SelectedPerson
		{
			get { return _selectedPerson; }
			set { 
				_selectedPerson = value;
				NotifyOfPropertyChange(() => SelectedPerson);
			}
		}

		public bool CanClearText(string firstName, string lastName)
		{
			return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
		}

		public void ClearText(string firstName, string lastName)
		{
			FirstName = "";
			LastName = "";
		}

		public void LoadAllLicences()
		{
			ActivateItem(new AllLicencesViewModel());
		}

		public void LoadAddLicence()
		{
			ActivateItem(new AddLicenceViewModel());
		}

		public void LoadEditLicence() 
		{
			ActivateItem(new EditLicenceViewModel());
		}
	}
}
