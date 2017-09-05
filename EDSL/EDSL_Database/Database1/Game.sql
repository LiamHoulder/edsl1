CREATE TABLE [dbo].[Game]
(
	[gameCode] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [homeTeam] NVARCHAR(50) NULL, 
    [awayTeam] NVARCHAR(50) NULL, 
    [homeGoals] INT NULL, 
    [awayGoals] INT NULL, 
    [gameTime] INT NULL
)
