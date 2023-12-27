CREATE PROCEDURE [dbo].[Developers_Update]
	@Id INT,
	@FirstName NVARCHAR (50),
	@LastName NVARCHAR(50),
	@Title NVARCHAR(50),
	@City NVARCHAR(50)
AS
	BEGIN
		UPDATE dbo.Developers
		SET FirstName = @FirstName, LastName = @LastName, Title = @Title, City = @City
		WHERE Id = @Id;
	END
