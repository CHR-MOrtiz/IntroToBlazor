CREATE PROCEDURE [dbo].[Developers_UpdateEmail]
	@Id INT,
	@email	VARCHAR(255)

AS
	IF EXISTS(SELECT 1 FROM dbo.Developers WHERE Id = @Id)
	BEGIN
		DECLARE @active BIT
		SELECT @active = (SELECT IsActive FROM dbo.Developers WHERE Id = @Id)

		IF(@active > 0 AND dbo.Validate_EmailPattern(@email) > 0)
		BEGIN
			UPDATE dbo.EmailAddress SET Email = @email WHERE DeveloperID = @Id
		END
	END
