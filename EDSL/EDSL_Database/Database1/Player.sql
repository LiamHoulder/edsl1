CREATE TABLE [dbo].[Player]
(
	[clubCode] INT NOT NULL , 
    [firstName] NVARCHAR(50) NULL, 
    [Surname] NVARCHAR(50) NULL, 
    [Gender] CHAR(10) NULL, 
    [addressLine1] NVARCHAR(50) NULL, 
    [postCode] INT NULL, 
    [State] NVARCHAR(50) NULL, 
    [Suburb] NVARCHAR(50) NULL, 
    [homePhone] INT NULL, 
    [Age] INT NULL, 
    [birthDate] INT NULL, 
    [firstRegistered] INT NULL, 
    [teamRank] CHAR(10) NULL, 
    CONSTRAINT [PK_Player] PRIMARY KEY ([clubCode])
)
