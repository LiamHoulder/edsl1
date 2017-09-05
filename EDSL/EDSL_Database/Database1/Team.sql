CREATE TABLE [dbo].[Team]
(
	[Division] CHAR(10) NOT NULL PRIMARY KEY, 
    [leagueCode] NVARCHAR(50) NULL, 
    [clubCode] NVARCHAR(50) NULL, 
    [Club] NVARCHAR(50) NULL, 
    [teamName] NVARCHAR(50) NULL 
)
