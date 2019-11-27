CREATE TABLE [dbo].[Genders]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Name] nvarchar(5) not null,
	CreateUserId int not null,
	CreateDate datetime not null default getdate(),
	DeleteDate datetime 
)
