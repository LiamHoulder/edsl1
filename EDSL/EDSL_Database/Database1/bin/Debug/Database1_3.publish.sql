﻿/*
Deployment script for EDSL1Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "EDSL1Database"
:setvar DefaultFilePrefix "EDSL1Database"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
PRINT N'Starting rebuilding table [dbo].[Clubs]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Clubs] (
    [clubCode]        NVARCHAR (50)  NOT NULL,
    [clubName]        NVARCHAR (50)  NULL,
    [contactName]     NVARCHAR (200) NULL,
    [contactSurname]  NVARCHAR (50)  NULL,
    [Gender]          CHAR (10)      NULL,
    [AddressLine1]    NVARCHAR (50)  NULL,
    [Postcode]        INT            NULL,
    [State]           NVARCHAR (50)  NULL,
    [Suburb]          NVARCHAR (50)  NULL,
    [homePhone]       INT            NULL,
    [firstRegistered] INT            NULL,
    PRIMARY KEY CLUSTERED ([clubCode] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Clubs])
    BEGIN
        INSERT INTO [dbo].[tmp_ms_xx_Clubs] ([clubCode], [clubName], [contactName], [contactSurname], [Gender], [AddressLine1], [Postcode], [State], [Suburb], [homePhone], [firstRegistered])
        SELECT   [clubCode],
                 [clubName],
                 [contactName],
                 [contactSurname],
                 [Gender],
                 [AddressLine1],
                 [Postcode],
                 [State],
                 [Suburb],
                 [homePhone],
                 [firstRegistered]
        FROM     [dbo].[Clubs]
        ORDER BY [clubCode] ASC;
    END

DROP TABLE [dbo].[Clubs];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Clubs]', N'Clubs';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


GO

GO
PRINT N'Update complete.';


GO
