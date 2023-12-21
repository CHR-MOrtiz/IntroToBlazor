if not exists (select 1 from dbo.developers)
BEGIN
	insert into dbo.Developers(FirstName, LastName, Title, City)
		values
		('Matt', 'Weiss', 'Lead Developer', 'Souix Fall'),
		('Dennis', 'Winkley', 'Senior Developer', 'Souix Fall'),
		('Cassidy', 'Weiss', 'Senior Developer', 'Souix Fall'),
		('Ron', 'Vander Wal', 'Senior Developer', 'Souix Fall'),
		('Ryan', 'Quasney', ' DevOps', 'Rapid City'),
		('Gian', 'Villaronte', 'Junior Developer', 'Calabarzon'),
		('Mateo', 'Ortiz', 'Developer', 'Orlando');
END