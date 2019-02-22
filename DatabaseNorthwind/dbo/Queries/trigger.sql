CREATE TRIGGER tr_ev  
ON Customers
after INSERT, UPDATE   
AS exec selsByOrlando

-- drop trigger tr_ev

insert into Customers (CustomerID, CompanyName) values ('11113', 'CompanyName1')


create table CharacterName(
	ID int Primary key Identity(1,1),
	Nume char(10),
	Inaltime int
)

create table Animatii(
	ID_char int,
	Imagine image,
	FOREIGN KEY (ID_char) REFERENCES CharacterName(ID)
)


create view CharacterNameAnim as
select CharacterName.Nume, Animatii.Imagine from CharacterName
join Animatii on Animatii.ID_char = CharacterName.ID


insert into CharacterNameAnim (Nume, Imagine)  values ('Gigel', null)

create trigger TRIGGER_Char on CharacterNameAnim
Instead of Insert as
begin
insert into CharacterName values ((select Nume from inserted), 10);

insert into Animatii values ((select count(CharacterName.Nume) from CharacterName), null);
end

drop trigger TRIGGER_Char

select * from Animatii
join CharacterName on CharacterName.ID = Animatii.ID_char