CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL,
	[Price] int NOT NULL,
	[Description] nvarchar(max) NOT NULL,
	[Image] varchar (200) not null, 
    [SubCategoryId] INT NOT NULL, 
    CONSTRAINT [FK_Products_SubCategories] FOREIGN KEY ([SubCategoryId]) REFERENCES [SubCategories]([Id])
)
