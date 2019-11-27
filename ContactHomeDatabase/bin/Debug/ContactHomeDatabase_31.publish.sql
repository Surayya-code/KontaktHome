﻿/*
Deployment script for ContactHome

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ContactHome"
:setvar DefaultFilePrefix "ContactHome"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"

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
USE [$(DatabaseName)];


GO
/*
The column [dbo].[Categories].[CreateAdminId] is being dropped, data loss could occur.

The column [dbo].[Categories].[SubCategoryId] is being dropped, data loss could occur.

The column [dbo].[Categories].[CreateUserId] on table [dbo].[Categories] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[Categories])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping [dbo].[DF__Categorie__Creat__628FA481]...';


GO
ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [DF__Categorie__Creat__628FA481];


GO
PRINT N'Starting rebuilding table [dbo].[Categories]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Categories] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (150) NOT NULL,
    [CreateUserId] INT            NOT NULL,
    [CreateDate]   DATETIME       DEFAULT getdate() NOT NULL,
    [DeleteDate]   DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Categories])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Categories] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Categories] ([Id], [Name], [CreateDate], [DeleteDate])
        SELECT   [Id],
                 [Name],
                 [CreateDate],
                 [DeleteDate]
        FROM     [dbo].[Categories]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Categories] OFF;
    END

DROP TABLE [dbo].[Categories];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Categories]', N'Categories';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creating [dbo].[Files]...';


GO
CREATE TABLE [dbo].[Files] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (200) NOT NULL,
    [ImageContent] IMAGE          NOT NULL,
    [CreateUserId] INT            NOT NULL,
    [CreateDate]   DATETIME       NOT NULL,
    [DeleteDate]   DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Products]...';


GO
CREATE TABLE [dbo].[Products] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (150) NOT NULL,
    [Price]       INT            NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [Image]       VARCHAR (200)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Files]...';


GO
ALTER TABLE [dbo].[Files]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Refreshing [dbo].[spSelectedItemsCategory]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spSelectedItemsCategory]';


GO
if not exists ( select top (1) 0 from Roles)
begin
  insert into [dbo].[Roles]([Name],[CreateUserId])
  Values (N'Adminstrator',1),(N'User',1)
end


if not exists ( select top (1) 0 from Genders)
begin
  insert into [dbo].[Genders]([Name],[CreateUserId])
  Values (N'Kişi',1),(N'Qadın',1)
end


if not exists ( select top (1) 0 from Users)
begin
  insert into [dbo].[Users] ([Email],[Password],[Name],[Surname],[GenderId],[RoleId],[ActivationKey],[ActivateDate],[CreateUserId])
  Values (N'admin@mail.ru','7110EDA4D09E062AA5E4A390B0A572AC','Admin','Admin',1,1,REPLACE(NEWID(),'-',''), getdate(), 1),
          (N'user@mail.ru','7110EDA4D09E062AA5E4A390B0A572AC','Default User','Admin',1,2,REPLACE(NEWID(),'-',''), getdate(), 1)
end


if not exists ( select top (1) 0 from Categories)
begin
  insert into [dbo].[Categories]([Name],[CreateUserId])
  Values (N'Telefonlar və Saatlar',1),(N'Kompüter və Ofis avadanlığı',1),(N'TV, Audio ',1),(N'Məişət texnikası',1)
end
GO

GO
PRINT N'Update complete.';


GO