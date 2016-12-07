CREATE PROCEDURE Admin_GetNearestLocations
	
AS
BEGIN
	
SELECT [AttractionsId]
      ,[AttractionName]
      ,[AddressOne]
      ,[AddressTwo]
      ,[CityId]
      ,[CategoryId]
      ,[Longitude]
      ,[Latitude]
      ,[PlaceId]
      ,[RankId]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
      ,[GoogleSearchText]
      ,[GoogleWebSite]
      ,[GoogleICon]
      ,[GoogleInternational_phone_number]
      ,[Googleadr_address]
      ,[GoogleName]
      ,[GoogleRating]
      ,[GoogleUser_ratings_total]
  FROM [dbo].[Attractions]
  WHERE PlaceId IS NULL
  OR PlaceId = ''
  OR Longitude IS NULL
  OR Longitude = ''
  OR Latitude IS NULL
  OR Latitude = ''


END
GO
