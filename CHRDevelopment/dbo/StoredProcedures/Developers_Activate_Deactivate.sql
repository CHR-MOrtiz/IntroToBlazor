CREATE PROCEDURE [dbo].[Developers_Activate_Deactivate_]
	@Id INT
AS
	BEGIN
		DECLARE @active BIT
		SELECT @active = (SELECT IsActive FROM dbo.Developers WHERE Id = @Id)

		IF(@active > 0)
		UPDATE dbo.Developers SET IsActive = 0 WHERE Id = @Id
		ELSE
		UPDATE dbo.Developers SET IsActive = 1  WHERE Id = @Id
	END