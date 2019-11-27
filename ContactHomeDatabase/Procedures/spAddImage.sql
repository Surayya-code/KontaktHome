CREATE PROCEDURE [dbo].[spAddImage]
	@Name nvarchar(150),
	@Price int,
	@Description nvarchar,
	@image varchar (200),
	@SubCategoryId int
AS
begin
	insert into dbo.[Products] ([Name],[Price],[Description],[Image],[SubCategoryId])
	values (@Name,@Price,@Description,@image,@SubCategoryId)
end

