CREATE PROCEDURE [dbo].[Developers_GetEmailByDeveloperId]
		@developerId INT
AS
	BEGIN
		SELECT Id, DeveloperID, Email FROM dbo.EmailAddress
		WHERE DeveloperID=@developerId;
	END
