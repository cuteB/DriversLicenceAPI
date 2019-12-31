CREATE TABLE [dbo].[DriversLicencesTable]
(
	[Id] INT NOT NULL PRIMARY KEY , 
    [FirstName] NVARCHAR(50) NOT NULL , 
    [LastName] NVARCHAR(50) NOT NULL , 
    [MiddleName] NVARCHAR(50) NULL, 
    [LicenceNumber] NVARCHAR(50) NULL, 
    [Class] INT NULL, 
    [StreetAddress] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Province] NVARCHAR(50) NULL, 
    [PostalCode] NVARCHAR(50) NULL, 
    [Sex] NVARCHAR(50) NULL, 
    [EyeColour] NVARCHAR(50) NULL, 
    [HairColour] NVARCHAR(50) NULL, 
    [DobDay] INT NULL, 
    [DobMonth] INT NULL, 
    [DobYear] INT NULL, 
    [Height] INT NULL, 
    [Weight] INT NULL, 
    [ExpiryDay] INT NULL, 
    [ExpiryMonth] INT NULL, 
    [ExpiryYear] INT NULL
)
