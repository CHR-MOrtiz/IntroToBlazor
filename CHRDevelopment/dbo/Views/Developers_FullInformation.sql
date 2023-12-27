CREATE VIEW [dbo].[Developers_FullInformation]
	AS
	SELECT d.Id, d.FirstName, d.LastName, d.Title, d.City, em.Email FROM [Developers] AS d
	JOIN [EmailAddress] AS em ON em.DeveloperID = d.Id;

	GO
