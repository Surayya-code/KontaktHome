CREATE TABLE [dbo].[AllProducts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[CategoryId] INT NOT NULL, 
	[SubCategoryId] INT NOT NULL, 
	[ProductsId] INT NOT NULL,
	[DeleteDate] datetime
     CONSTRAINT [FK_AllProducts_SubCategories] FOREIGN KEY ([SubCategoryId]) REFERENCES [SubCategories]([Id])
	 CONSTRAINT [FK_AllProducts_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
	 CONSTRAINT [FK_AllProducts_Products] FOREIGN KEY ([ProductsId]) REFERENCES [Products]([Id])


)
