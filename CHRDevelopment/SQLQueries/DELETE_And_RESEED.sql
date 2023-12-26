USE CHRDevelopmentDB

DELETE FROM [dbo].[EmailAddress]

DBCC CHECKIDENT ('[EmailAddress]', RESEED, 0);
GO


USE CHRDevelopmentDB

DELETE FROM [dbo].[Developers]

DBCC CHECKIDENT ('[Developers]', RESEED, 0);
GO