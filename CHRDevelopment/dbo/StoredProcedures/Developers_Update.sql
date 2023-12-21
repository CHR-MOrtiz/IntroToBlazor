CREATE PROCEDURE [dbo].[Developers_Update]
	@Id int,
	@FirstName nvarchar (50),
	@LastName nvarchar(50),
	@Title nvarchar(50),
	@City nvarchar(50)
AS
	BEGIN
		update dbo.Developers
		set FirstName = @FirstName, LastName = @LastName, Title = @Title, City = @City
		where Id = @Id;
	END
