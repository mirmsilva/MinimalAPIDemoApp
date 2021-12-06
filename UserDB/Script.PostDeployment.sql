if not exists( select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Miriam', 'Silva'),
	('Lupe', 'Smith'),
	('Paola', 'Shmoe'),
	('Kayla', 'Joe');
end

--What this is saying: if you don't find any records do this query. This is a little bit faster than saying select* . And for every row in users return a 1.
--If no record exists in the user table then it will add our values. If one does exists it will just ignore them. It will only execute once since if it does run then you will have data in your table rendering this script uncessary in the future