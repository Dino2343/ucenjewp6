
create database ribolov;
go

use ribolov;
go

create table ribe(
    sifra int not null primary key identity(1,1),
    naziv varchar(50) not null,
    tip varchar(50) not null,
    cijena decimal(10,2),
    velicina decimal(5,2),
    mjesto varchar(50)
);

create table sportski_ribolov(
    sifra int not null primary key identity(1,1),
    tehnika varchar(50) not null,
    vrsta_ribe varchar(50) not null,
    lokacija varchar(50) not null
	riba int not null references ribe (sifra)

);

create table rekreativni_ribolov(
    sifra int not null primary key identity(1,1),
    vrsta_ribe varchar(50) not null,
    oprema varchar(40),
    minimalna_mjera decimal(5,2) not null,
    lokacija varchar(50)
	riba int not null references ribe (sifra)
);

create table ribolov(
    sifra int not null primary key identity(1,1),
    disciplina varchar(50),
    riba int not null references ribe (sifra),
    tehnika varchar(50),
    lokacija varchar(50),
    datum date

);

 insert into sportski_ribolov(tehnika,vrsta_ribe,lokacija) values
 ('Lov na plovak', 'šaran', 'Jezero Plitvićka'),
 ('Lov na plovak', 'Pastrva', 'Rijeka Cetina'),
 ('Lov na dnu', 'Grgeč', 'Rijeka Kupa'),
 ('Lov na dnu', 'Losos', 'Rijeka Sava'),
 ('Lov na plovak', 'Trlja', 'Sredozemno more'),
 ('Lov na dnu', 'Zubatac', 'Jadransko more'),
 ('Lov na plovak', 'Tuna', 'Jadransko more'),
 ('Lov na dnu', 'Oslić', 'Jadransko more');

 insert into ribolov (disciplina, riba, tehnika, lokacija, datum) values
('Rekreativni', 1, 'Lov na plovak', 'Jezero Plitvička', '2024-05-10'),   
('Sportski', 2, 'Lov na mućicu', 'Rijeka Cetina', '2024-06-12'),         
('Rekreativni', 3, 'Lov na dnu', 'Rijeka Kupa', '2024-07-01'),           
('Sportski', 4, 'Lov na vobler', 'Rijeka Sava', '2024-08-15'),            
('Rekreativni', 5, 'Lov na plovak', 'Sredozemno more', '2024-06-05');     

insert into ribe (naziv, tip, cijena, velicina, mjesto) values
('šaran', 'slatkovodna', 50.00, 20.00, 'Jezero Plitvička'),
('Pastrva', 'slatkovodna', 120.00, 15.00, 'Rijeka Cetina'),
('Grgeč', 'slatkovodna', 30.00, 15.00, 'Rijeka Kupa'),
('Losos', 'slatkovodna', 200.00, 25.00, 'Rijeka Sava'),
('Trlja', 'morska', 90.00, 10.00, 'Sredozemno more'),
('Zubatac', 'morska', 150.00, 25.00, 'Jadransko more'),
('Tuna', 'morska', 250.00, 50.00, 'Jadransko more'),
('Oslić', 'morska', 75.00, 12.00, 'Jadransko more');