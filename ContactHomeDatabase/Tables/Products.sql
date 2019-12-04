CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL,
	[Price] int NOT NULL,
	[Description] nvarchar(max) NOT NULL,
	[DeleteDate] datetime,
    [SubCategoryId] INT NOT NULL, 
	[FileId] int null
)
