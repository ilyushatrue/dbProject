/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[UserName]
      ,[NormalizedUserName]
      ,[Email]
      ,[NormalizedEmail]
      ,[EmailConfirmed]
      ,[PasswordHash]
      ,[SecurityStamp]
      ,[ConcurrencyStamp]
      ,[PhoneNumber]
      ,[PhoneNumberConfirmed]
      ,[TwoFactorEnabled]
      ,[LockoutEnd]
      ,[LockoutEnabled]
      ,[AccessFailedCount]
  FROM [dbProj].[dbo].[AspNetUsers]

  update [dbProj].[dbo].[AspNetUsers] set [EmailConfirmed] = 1