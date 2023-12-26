CREATE PROCEDURE [dbo].[Developers_Delete]
	@Id int
AS

	BEGIN
		Alter table dbo.EmailAddress DROP CONSTRAINT FK_Developer;
		delete from dbo.Developers
		where Id =@Id;
	END