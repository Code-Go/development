CREATE TABLE [dbo].[MasterCountry] (
    [CountryId]        INT           NOT NULL,
    [CountryName]      VARCHAR (250) NULL,
    [CountryShortName] VARCHAR (50)  NULL,
    CONSTRAINT [PK_MaterCountry] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);

