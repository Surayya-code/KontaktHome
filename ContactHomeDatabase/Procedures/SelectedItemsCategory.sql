CREATE PROCEDURE [dbo].[spSelectedItemsCategory]
@selecteds varchar(max)
AS
begin
Select * from categories c
join string_split(@selecteds, ',') s  on c.Id=s.[value]
end


