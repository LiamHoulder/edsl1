CREATE TABLE [dbo].[league]
(
	[administrator] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [email] NVARCHAR(50) NULL, 
    [leagueAddress] NVARCHAR(50) NULL, 
    [leagueName] NVARCHAR(50) NULL, 
    [phoneNumber] INT NULL, 
    [postalAddress] NVARCHAR(50) NULL, 
    [president] NVARCHAR(50) NULL, 
    [website] NVARCHAR(50) NULL
)
