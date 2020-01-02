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
    class AddLicenceViewModel : Conductor<object>
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

		public string FirstName
		{
			get { return _firstName; }
			set { 
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
			}
		}


		public string MiddleName
		{
			get { return _middleName; }
			set { 
				_middleName = value; 
				NotifyOfPropertyChange(() => MiddleName);

			}
		}


		public string LastName
		{
			get { return _lastName; }
			set { 
				_lastName = value; 
				NotifyOfPropertyChange(() => LastName);
			}
		}


		public string LicenceNumber
		{
			get { return _licenceNumber; }
			set { 
				_licenceNumber = value;
				NotifyOfPropertyChange(() => LicenceNumber);

			}
		}


		public int LicenceClass
		{
			get { return _licenceClass; }
			set { 
				_licenceClass = value; 
				NotifyOfPropertyChange(() => LicenceClass);

			}
		}


		public string ExpiryDate
		{
			get { return _expiryDate; }
			set { 
				_expiryDate = value; 
				NotifyOfPropertyChange(() => ExpiryDate);

			}
		}



		public string StreetAddress
		{
			get { return _streetAddress; }
			set {
				_streetAddress = value;
				NotifyOfPropertyChange(() => StreetAddress);

			}
		}


		public string City
		{
			get { return _city; }
			set { 
				_city = value;
				NotifyOfPropertyChange(() => City);

			}
		}


		public string Province
		{
			get { return _province; }
			set { 
				_province = value; 
				NotifyOfPropertyChange(() => Province);

			}
		}


		public string PostalCode
		{
			get { return _postalCode; }
			set { 
				_postalCode = value;
				NotifyOfPropertyChange(() => PostalCode);

			}
		}


		public string Sex
		{
			get { return _sex; }
			set { 
				_sex = value; 
				NotifyOfPropertyChange(() => Sex);

			}
		}


		public string EyeColour
		{
			get { return _eyeColour; }
			set { 
				_eyeColour = value; 
				NotifyOfPropertyChange(() => EyeColour);

			}
		}


		public string HairColour
		{
			get { return _hairColour; }
			set { 
				_hairColour = value; 
				NotifyOfPropertyChange(() => HairColour);

			}
		}


		public string Dob
		{
			get { return _dob; }
			set { 
				_dob = value; 
				NotifyOfPropertyChange(() => Dob);

			}
		}


		public int Height
		{
			get { return _height; }
			set { 
				_height = value; 
				NotifyOfPropertyChange(() => Height);

			}
		}


		public int Weight
		{
			get { return _weight; }
			set { 
				_weight = value; 
				NotifyOfPropertyChange(() => Weight);

			}
		}

		public bool CanSaveButton(string firstName, string middleName, string lastName, string licenceNumber, int licenceClass, string expiryDate, string streetAddress, string city,
			string province, string postalCode, string sex, string eyeColour, string hairColour, string dob, int height, int weight)
		{
			return !String.IsNullOrWhiteSpace(firstName) &&
				!String.IsNullOrWhiteSpace(middleName) &&
				!String.IsNullOrWhiteSpace(lastName) &&
				!String.IsNullOrWhiteSpace(licenceNumber) &&
				licenceClass > 0 &&
				!String.IsNullOrWhiteSpace(expiryDate) &&
				!String.IsNullOrWhiteSpace(streetAddress) &&
				!String.IsNullOrWhiteSpace(city) &&
				!String.IsNullOrWhiteSpace(province) &&
				!String.IsNullOrWhiteSpace(postalCode) &&
				!String.IsNullOrWhiteSpace(sex) &&
				!String.IsNullOrWhiteSpace(eyeColour) &&
				!String.IsNullOrWhiteSpace(hairColour) &&
				!String.IsNullOrWhiteSpace(dob) &&
				height > 0 &&
				weight > 0;

		}


		public void SaveButton(string firstName, string middleName, string lastName, string licenceNumber, int licenceClass, string expiryDate, string streetAddress, string city, 
			string province, string postalCode, string sex, string eyeColour, string hairColour, string dob, int height, int weight)
		{

			// get Id
			int id = DriversLicenceProcessor.LoadDriversLicences().Count() + 1;

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

			DriversLicenceProcessor.CreateDriversLicence(id, firstName, lastName, middleName, licenceNumber, licenceClass, streetAddress, city, province, postalCode, sex,
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


		public void ClearButton(string firstName, string middleName, string lastName, string licenceNumber, int licenceClass, string expiryDate, string streetAddress, string city,
			string province, string postalCode, string sex, string eyeColour, string hairColour, string DOB, int height, int weight)
		{
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








	}
}
