if not exists (select 1 from dbo[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Klerison', 'Monteiro'),
	('Kleri', 'Monti'),
	('Kleris', 'Montis'),
	('Klerin', 'Montin');
end
