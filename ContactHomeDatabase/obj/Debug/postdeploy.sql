if not exists ( select top (1) 0 from Roles)
begin
  insert into [dbo].[Roles]([Name],[CreateUserId])
  Values (N'Adminstrator',1),(N'User',1)
end


if not exists ( select top (1) 0 from Genders)
begin
  insert into [dbo].[Genders]([Name],[CreateUserId])
  Values (N'Kişi',1),(N'Qadın',1)
end


if not exists ( select top (1) 0 from Users)
begin
  insert into [dbo].[Users] ([Email],[Password],[Name],[Surname],[GenderId],[RoleId],[ActivationKey],[ActivateDate],[CreateUserId])
  Values (N'admin@mail.ru','7110EDA4D09E062AA5E4A390B0A572AC','Admin','Admin',1,1,REPLACE(NEWID(),'-',''), getdate(), 1),
          (N'user@mail.ru','7110EDA4D09E062AA5E4A390B0A572AC','Default User','Admin',1,2,REPLACE(NEWID(),'-',''), getdate(), 1)
end


if not exists ( select top (1) 0 from Categories)
begin
  insert into [dbo].[Categories]([Name],[CreateUserId])
  Values (N'Telefonlar və Saatlar',1),(N'Kompüter və Ofis avadanlığı',1),
  (N'TV, Audio ',1),(N'Məişət texnikası',1)
end
GO
