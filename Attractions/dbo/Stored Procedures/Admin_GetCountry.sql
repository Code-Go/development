CREATE PROCEDURE [dbo].[Admin_GetCountry] 
AS
BEGIN
	SELECT [CountryId]
			,[CountryName]
			,[CountryShortName]
			,[CreatedBy]
			,[CreatedDate]
			,[ModifiedBy]
			,[ModifiedDate]
	FROM [dbo].[MasterCountry]
END