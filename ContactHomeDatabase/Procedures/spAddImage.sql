CREATE PROCEDURE [dbo].[spAddImage]
	@imageName nvarchar(200),
	@imageContent image,
	@createUserId int
AS
begin
insert into dbo.Files ([Name],[ImageContent],[CreateUserId])
              values  (@imageName,@imageContent,@createUserId)
end
	

