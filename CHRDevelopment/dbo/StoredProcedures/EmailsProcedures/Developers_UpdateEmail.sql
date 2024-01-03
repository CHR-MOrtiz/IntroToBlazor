CREATE PROCEDURE [dbo].[Developers_UpdateEmail]
	@developerId INT,
	@email	VARCHAR(255)

AS
	IF EXISTS(SELECT 1 FROM dbo.Developers WHERE Id = @developerId)
	BEGIN
		DECLARE @active BIT, @Id int

		SELECT @active = (SELECT IsActive FROM dbo.Developers WHERE Id = @developerId)
		SELECT @Id = (SELECT Id FROM dbo.EmailAddress WHERE DeveloperID = @developerId)

		IF(@active > 0 AND dbo.Validate_EmailPattern(@email) > 0)
		BEGIN
			UPDATE dbo.EmailAddress SET Email = TRIM(@email) WHERE Id = @Id
		END
		ELSE
		RETURN 0;
	END
