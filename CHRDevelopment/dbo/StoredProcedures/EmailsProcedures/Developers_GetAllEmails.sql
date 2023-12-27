CREATE PROCEDURE [dbo].[Developers_GetAllEmails]
AS
	BEGIN
	SELECT Id, DeveloperID, Email FROM [dbo].[EmailAddress]
	END