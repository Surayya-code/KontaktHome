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
PRINT N'Creating [dbo].[VwFiles]...';


GO
CREATE VIEW [dbo].[VwFiles]
	AS SELECT [Id],[Name] FROM dbo.[Files]
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
  Values (N'Telefonlar və Saatlar',1),(N'Kompüter və Ofis avadanlığı',1),
  (N'TV, Audio ',1),(N'Məişət texnikası',1)
end
GO

GO
PRINT N'Update complete.';


GO
