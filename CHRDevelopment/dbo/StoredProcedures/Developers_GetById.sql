CREATE PROCEDURE [dbo].[Developers_GetById]
	@Id INT
AS
	BEGIN
		SELECT Id, FirstName, LastName, Title, City FROM dbo.Developers
		WHERE Id =@Id;
	END
