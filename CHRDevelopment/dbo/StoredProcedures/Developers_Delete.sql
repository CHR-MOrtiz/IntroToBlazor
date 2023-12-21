CREATE PROCEDURE [dbo].[Developers_Delete]
	@Id int
AS
	BEGIN
		delete from dbo.Developers
		where Id =@Id;
	END