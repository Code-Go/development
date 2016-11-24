-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Admin_InsertCountry
(
	@CountryName Varchar(50)
	,@CountryShortName Varchar(50)
)
AS
BEGIN


INSERT INTO [dbo].[MasterCountry]
           ([CountryId]
		   ,[CountryName]
           ,[CountryShortName])
     VALUES
           ((SELECT ISNULL(Max(CountryId),1) FROM MasterCountry)
		   ,@CountryName
           ,@CountryShortName)

END
