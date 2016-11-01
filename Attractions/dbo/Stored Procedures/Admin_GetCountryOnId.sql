CREATE PROCEDURE [dbo].[Admin_GetCountryOnId]
(
	@CountryId INT
)
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
	WHERE CountryId = @CountryId


END