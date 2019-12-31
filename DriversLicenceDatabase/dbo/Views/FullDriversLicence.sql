CREATE VIEW [dbo].[FullDriversLicence]
	AS 
	Select [dl].[Id], [dl].[FirstName], [dl].[LastName], [dl].[MiddleName], [dl].[LicenceNumber], [dl].[Class], [dl].[StreetAddress], [dl].[City], [dl].[Province], [dl].[PostalCode], [dl].[Sex], [dl].[EyeColour], [dl].[HairColour], [dl].[DobDay], [dl].[DobMonth], [dl].[DobYear], [dl].[Height], [dl].[Weight], [dl].[ExpiryDay], [dl].[ExpiryMonth], [dl].[ExpiryYear]
	FROM dbo.DriversLicencesTable dl


