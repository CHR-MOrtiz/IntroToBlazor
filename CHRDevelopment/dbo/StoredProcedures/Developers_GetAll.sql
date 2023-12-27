CREATE PROCEDURE [dbo].[Developers_GetAll]

AS
	BEGIN
		SELECT Id, FirstName, LastName, Title, City FROM dbo.Developers;
	END
