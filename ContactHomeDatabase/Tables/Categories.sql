CREATE TABLE [dbo].[Categories]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL,
	CreateUserId int not null,
	CreateDate datetime not null default getdate(),
	DeleteDate datetime, 
    CONSTRAINT [FK_Categories_Users] FOREIGN KEY ([CreateUserId]) REFERENCES [Users]([Id]) 
)
