CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Email] nvarchar(70) not null,
	[Password] nvarchar(32) not null,
	[Name] nvarchar (50)not null,
	Surname nvarchar (100)not null,
	GenderId int not null ,
	RoleId int not null default 2,
	ActivationKey varchar(32),
	ActivateDate datetime,
	CreateUserId int not null,
	CreateDate datetime not null default getdate(),
	DeleteDate datetime, 
    CONSTRAINT [FK_Users_Genders] FOREIGN KEY ([GenderId]) REFERENCES [Genders]([Id]), 
    CONSTRAINT [FK_Users_Roles] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([Id]) 
)
