CREATE PROCEDURE [dbo].[spAddImage]
	@imageName nvarchar(200),
	@imageContent image,
	@CreateUserId int
AS
begin
	insert into dbo.[Files] ([Name],[ImageContent],[CreateUserId])
	values (@imageName,@imageContent,@CreateUserId)
end

