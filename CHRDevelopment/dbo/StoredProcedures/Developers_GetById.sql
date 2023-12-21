CREATE PROCEDURE [dbo].[Developers_GetById]
	@Id int
AS
	BEGIN
		select Id, FirstName, LastName, Title, City from dbo.Developers
		where Id =@Id;
	END
