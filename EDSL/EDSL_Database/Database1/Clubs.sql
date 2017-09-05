CREATE TABLE [dbo].[Clubs]
(
	[clubCode] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [clubName] NVARCHAR(50) NULL, 
    [contactName] NVARCHAR(200) NULL, 
    [contactSurname] NVARCHAR(50) NULL, 
    [Gender] CHAR(10) NULL, 
    [AddressLine1] NVARCHAR(50) NULL, 
    [Postcode] INT NULL, 
    [State] NVARCHAR(50) NULL, 
    [Suburb] NVARCHAR(50) NULL, 
    [homePhone] NVARCHAR(50) NULL, 
    [firstRegistered] INT NULL
)
