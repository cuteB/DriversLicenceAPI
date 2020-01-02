using Caliburn.Micro;
using DriversLicenceAPI.BusinessLogic;
using DriversLicenceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDriversLicenceUI.ViewModels
{
    class EditLicenceViewModel : Conductor<object>
    {
		private string _firstName;
		private string _middleName;
		private string _lastName;
		private string _licenceNumber;
		private int _licenceClass;
		private string _expiryDate;
		private string _streetAddress;
		private string _city;
		private string _province;
		private string _postalCode;
		private string _sex;
		private string _eyeColour;
		private string _hairColour;
		private string _dob;
		private int _height;
		private int _weight;

		private string default_firstName;
		private string default_middleName;
		private string default_lastName;
		private string default_licenceNumber;
		private int default_licenceClass;
		private string default_expiryDate;
		private string default_streetAddress;
		private string default_city;
		private string default_province;
		private string default_postalCode;
		private string default_sex;
		private string default_eyeColour;
		private string default_hairColour;
		private string default_dob;
		private int default_height;
		private int default_weight;

		private DriversLicence selectedDriversLicence;
		private BindableCollection<DriversLicence> _driversLicences;



		public EditLicenceViewModel()
		{
			DriversLicences = new BindableCollection<DriversLicence>();
			List<DriversLicence> data = DriversLicenceProcessor.LoadDriversLicences();
			foreach (var item in data)
			{
				DriversLicences.Add(item);
			}
		}


		public BindableCollection<DriversLicence> DriversLicences
		{
			get { return _driversLicences; }
			set { _driversLicences = value; }
		}



		public string FirstName
		{
			get { return _firstName; }
			set
			{
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
			}
		}


		public string MiddleName
		{
			get { return _middleName; }
			set
			{
				_middleName = value;
				NotifyOfPropertyChange(() => MiddleName);

			}
		}


		public string LastName
		{
			get { return _lastName; }
			set
			{
				_lastName = value;
				NotifyOfPropertyChange(() => LastName);
			}
		}


		public string LicenceNumber
		{
			get { return _licenceNumber; }
			set
			{
				_licenceNumber = value;
				NotifyOfPropertyChange(() => LicenceNumber);

			}
		}


		public int LicenceClass
		{
			get { return _licenceClass; }
			set
			{
				_licenceClass = value;
				NotifyOfPropertyChange(() => LicenceClass);

			}
		}


		public string ExpiryDate
		{
			get { return _expiryDate; }
			set
			{
				_expiryDate = value;
				NotifyOfPropertyChange(() => ExpiryDate);

			}
		}



		public string StreetAddress
		{
			get { return _streetAddress; }
			set
			{
				_streetAddress = value;
				NotifyOfPropertyChange(() => StreetAddress);

			}
		}


		public string City
		{
			get { return _city; }
			set
			{
				_city = value;
				NotifyOfPropertyChange(() => City);

			}
		}


		public string Province
		{
			get { return _province; }
			set
			{
				_province = value;
				NotifyOfPropertyChange(() => Province);

			}
		}


		public string PostalCode
		{
			get { return _postalCode; }
			set
			{
				_postalCode = value;
				NotifyOfPropertyChange(() => PostalCode);

			}
		}


		public string Sex
		{
			get { return _sex; }
			set
			{
				_sex = value;
				NotifyOfPropertyChange(() => Sex);

			}
		}


		public string EyeColour
		{
			get { return _eyeColour; }
			set
			{
				_eyeColour = value;
				NotifyOfPropertyChange(() => EyeColour);

			}
		}


		public string HairColour
		{
			get { return _hairColour; }
			set
			{
				_hairColour = value;
				NotifyOfPropertyChange(() => HairColour);

			}
		}


		public string Dob
		{
			get { return _dob; }
			set
			{
				_dob = value;
				NotifyOfPropertyChange(() => Dob);

			}
		}


		public int Height
		{
			get { return _height; }
			set
			{
				_height = value;
				NotifyOfPropertyChange(() => Height);

			}
		}


		public int Weight
		{
			get { return _weight; }
			set
			{
				_weight = value;
				NotifyOfPropertyChange(() => Weight);

			}
		}


		public DriversLicence SelectedDriversLicence
		{
			get { return selectedDriversLicence; }
			set { 
				selectedDriversLicence = value;

				// change 
				if (value != null)
				{
					_firstName = value.FirstName;
					_middleName = value.MiddleName;
					_lastName = value.LastName;
					_licenceNumber = value.LicenceNumber;
					_licenceClass = value.LicenceClass;
					_streetAddress = value.StreetAddress;
					_city = value.City;
					_province = value.Province;
					_postalCode = value.PostalCode;
					_sex = value.Sex;
					_eyeColour = value.EyeColour;
					_hairColour = value.HairColour;
					_height = value.Height;
					_weight = value.Weight;
					_dob = value.DobDay + "/" + value.DobMonth + "/" + value.DobYear;
					_expiryDate = value.ExpiryDay + "/" + value.ExpiryMonth + "/" + value.ExpiryYear;


					default_firstName = value.FirstName;
					default_middleName = value.MiddleName;
					default_lastName = value.LastName;
					default_licenceNumber = value.LicenceNumber;
					default_licenceClass = value.LicenceClass;
					default_streetAddress = value.StreetAddress;
					default_city = value.City;
					default_province = value.Province;
					default_postalCode = value.PostalCode;
					default_sex = value.Sex;
					default_eyeColour = value.EyeColour;
					default_hairColour = value.HairColour;
					default_height = value.Height;
					default_weight = value.Weight;
					default_dob = value.DobDay + "/" + value.DobMonth + "/" + value.DobYear;
					default_expiryDate = value.ExpiryDay + "/" + value.ExpiryMonth + "/" + value.ExpiryYear;

				}

				NotifyOfPropertyChange(() => SelectedDriversLicence);
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => MiddleName);
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => LicenceNumber);
				NotifyOfPropertyChange(() => LicenceClass);
				NotifyOfPropertyChange(() => ExpiryDate);
				NotifyOfPropertyChange(() => StreetAddress);
				NotifyOfPropertyChange(() => City);
				NotifyOfPropertyChange(() => Province);
				NotifyOfPropertyChange(() => Sex);
				NotifyOfPropertyChange(() => EyeColour);
				NotifyOfPropertyChange(() => HairColour);
				NotifyOfPropertyChange(() => Dob);
				NotifyOfPropertyChange(() => Height);
				NotifyOfPropertyChange(() => Weight);


			}
		}

		private void something()
		{
			Weight = 2;
		}


		public void SaveButton(string firstName, string middleName, string lastName, string licenceNumber, int licenceClass, string expiryDate, string streetAddress, string city,
	string province, string postalCode, string sex, string eyeColour, string hairColour, string dob, int height, int weight)
		{

			// get Id
			int id = SelectedDriversLicence.Id;

			// get expiryDate parts
			String[] dobParts = dob.Split('/');
			int dobDay = Int32.Parse(dobParts[0]);
			int dobMonth = Int32.Parse(dobParts[1]);
			int dobYear = Int32.Parse(dobParts[2]);

			// get DOB parts
			String[] expiryDateParts = expiryDate.Split('/');
			int expiryDay = Int32.Parse(expiryDateParts[0]);
			int expiryMonth = Int32.Parse(expiryDateParts[1]);
			int expiryYear = Int32.Parse(expiryDateParts[2]);

			DriversLicenceProcessor.UpdateDriversLicence(id, firstName, lastName, middleName, licenceNumber, licenceClass, streetAddress, city, province, postalCode, sex,
				eyeColour, hairColour, dobDay, dobMonth, dobYear, height, weight, expiryDay, expiryMonth, expiryYear);


			// reset
			FirstName = "";
			MiddleName = "";
			LastName = "";
			LicenceNumber = "";
			LicenceClass = 0;
			ExpiryDate = "";
			StreetAddress = "";
			City = "";
			Province = "";
			PostalCode = "";
			Sex = "";
			EyeColour = "";
			HairColour = "";
			Dob = "";
			Height = 0;
			Weight = 0;



		}

		public void ResetButton()
		{
			FirstName = default_firstName;
			MiddleName = default_middleName;
			LastName = default_lastName;
			LicenceNumber = default;
			LicenceClass = 0;
			ExpiryDate = "";
			StreetAddress = "";
			City = "";
			Province = "";
			PostalCode = "";
			Sex = "";
			EyeColour = "";
			HairColour = "";
			Dob = "";
			Height = 0;
			Weight = 0;
		}






	}
}
