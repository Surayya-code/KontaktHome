CREATE PROCEDURE [dbo].[spCheckUser]
	@Email nvarchar(70) ,
	@Password nvarchar(32)
AS
Begin
	if nullif(@Email,'') is null
	throw 50001, N'Email is empty',11

	if nullif(@Password,'') is null
	throw 50001, N'Password is empty',11

	SELECT Top(1) * From dbo.Users
	where Email=@Email and Password=@Password

End
