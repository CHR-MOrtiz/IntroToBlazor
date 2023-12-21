CREATE PROCEDURE [dbo].[Developers_Insert]

	@FirstName nvarchar (50),
	@LastName nvarchar(50),
	@Title nvarchar(50),
	@City nvarchar(50)
AS
	BEGIN
		insert into dbo.Developers(FirstName, LastName, Title, City)
		values( @FirstName, @LastName, @Title, @City);
	END