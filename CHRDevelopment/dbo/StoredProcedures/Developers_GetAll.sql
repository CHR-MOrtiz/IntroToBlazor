CREATE PROCEDURE [dbo].[Developer_GetAll]

AS
	BEGIN
		select Id, FirstName, LastName, Title, City from dbo.Developers;
	END
