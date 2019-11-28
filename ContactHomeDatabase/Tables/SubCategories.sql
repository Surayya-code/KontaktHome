CREATE TABLE [dbo].[SubCategories]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL, 
	[CategoryId] int not null,
	CreateUserId int not null,
	CreateDate datetime not null default getdate(),
	DeleteDate datetime,
    CONSTRAINT [FK_SubCategories_Category] FOREIGN KEY (CategoryId) 
	REFERENCES [Categories]([Id]),
)
