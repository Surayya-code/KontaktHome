CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL,
	[Price] int NOT NULL,
	[Description] nvarchar(max) NOT NULL,
	[Image] IMAGE not null, 
	[DeleteDate] datetime,
    [SubCategoryId] INT NOT NULL, 
    CONSTRAINT [FK_Products_SubCategories] FOREIGN KEY ([SubCategoryId]) REFERENCES [SubCategories]([Id])
)
