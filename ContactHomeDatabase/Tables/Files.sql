CREATE TABLE [dbo].[Files]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Name] nvarchar(200) not null,
	[ImageContent] image not null,
	CreateUserId int not null,
	CreateDate datetime not null default getdate(),
	
)
