using DriversLicenceAPI.DataAccess;
using DriversLicenceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversLicenceAPI.BusinessLogic
{
    public static class DriversLicenceProcessor
    {
        public static int CreateDriversLicence(int id, string firstName, string lastName, string middleName, string licenceNumber, int licenceClass,
                string streetAddress, string city, string province, string postalCode, string sex, string eyeColour, string hairColour,
                int dobDay, int dobMonth, int dobYear, int height, int weight, int expiryDay, int expiryMonth, int expiryYear)
        {
            DriversLicence data = new DriversLicence
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName,
                LicenceNumber = licenceNumber,
                LicenceClass = licenceClass,
                StreetAddress = streetAddress,
                City = city,
                Province = province,
                PostalCode = postalCode,
                Sex = sex,
                EyeColour = eyeColour,
                HairColour = hairColour,
                DobDay = dobDay,
                DobMonth = dobMonth,
                DobYear = dobYear,
                Height = height,
                Weight = weight,
                ExpiryDay = expiryDay,
                ExpiryMonth = expiryMonth,
                ExpiryYear = expiryYear
            };

            string sql = @"insert into dbo.DriversLicencesTable (Id, FirstName, LastName, MiddleName, LicenceNumber, Class, StreetAddress, City, Province, PostalCode, 
                            Sex, EyeColour, HairColour, DobDay, DobMonth, DobYear, Height, Weight, ExpiryDay, ExpiryMonth, ExpiryYear)
                            values (@Id, @FirstName, @LastName, @MiddleName, @LicenceNumber, @LicenceClass, @StreetAddress, @City, @Province, @PostalCode, 
                            @Sex, @EyeColour, @HairColour, @DobDay, @DobMonth, @DobYear, @Height, @Weight, @ExpiryDay, @ExpiryMonth, @ExpiryYear);";

            return DriversLicenceDataAccess.SaveData(sql, data);
        }

        public static List<DriversLicence> LoadDriversLicences()
        {
            string sql = @"select Id, FirstName, LastName, MiddleName, LicenceNumber, Class, StreetAddress, City, Province, PostalCode, 
                            Sex, EyeColour, HairColour, DobDay, DobMonth, DobYear, Height, Weight, ExpiryDay, ExpiryMonth, ExpiryYear from dbo.DriversLicencesTable;";

            return DriversLicenceDataAccess.LoadData<DriversLicence>(sql);
        }

    }
}