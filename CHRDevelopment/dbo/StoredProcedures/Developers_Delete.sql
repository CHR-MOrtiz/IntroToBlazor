CREATE PROCEDURE [dbo].[Developers_Delete]
	@Id int
AS

	BEGIN
		--Alter table dbo.EmailAddress DROP CONSTRAINT FK_Developer;

		--delete from dbo.Developers
		--where Id =@Id AND IsActive = 0;

		DELETE d
		FROM dbo.Developers AS d
		INNER JOIN dbo.EmailAddress AS de ON d.Id=de.DeveloperID
		WHERE d.IsActive=0 AND d.Id=@Id;
	END