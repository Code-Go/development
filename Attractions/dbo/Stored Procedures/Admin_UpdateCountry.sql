CREATE PROCEDURE [dbo].[Admin_UpdateCountry] 
(
	@CountryId INT
	,@CountryName Varchar(250)
	,@CountryShortName Varchar(50)	
	,@CreatedBy Varchar(50)
	
)
AS
BEGIN
	IF(@CountryId = 0)
	BEGIN		
		
		INSERT INTO [dbo].[MasterCountry]
			   ([CountryName]
			   ,[CountryShortName]
			   ,[CreatedBy]
			   ,[CreatedDate]
			   )
		 VALUES
			   (@CountryName
			   ,@CountryShortName
			   ,@CreatedBy
			   ,GETDATE()
			   )
	END
	ELSE
	BEGIN		

		UPDATE [dbo].[MasterCountry]
		   SET [CountryName] = @CountryName
			  ,[CountryShortName] = @CountryShortName			  
			  ,[ModifiedBy] = @CreatedBy
			  ,[ModifiedDate] = GETDATE()
		 WHERE [CountryId] = @CountryId
	END
END