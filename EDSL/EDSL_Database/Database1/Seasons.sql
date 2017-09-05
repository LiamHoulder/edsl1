CREATE TABLE [dbo].[Seasons]
(
	[seasonYear] INT NOT NULL PRIMARY KEY, 
    [startDate] INT NULL, 
    [numRounds] INT NULL, 
    [nonPlayWeeks] NVARCHAR(50) NULL, 
    [endDate] INT NULL
)
