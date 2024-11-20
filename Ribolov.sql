@ -0,0 +1,53 @@
create database ribolov;
go
use database ribolov;
go
create table ribe(
 sifra int not null primary key identity (1,1),
 naziv varchar(50) not null,
 tip varchar (50) not null,
 cijena decimal (10,2),
 velicina decimal (5,2),
 mjesto varchar (50)
 );

 create table sportski_ribolov(
 sifra int not null primary key identity (1,1),
 tehnika varchar (50) not null,
 vrsta_ribe varchar (50) not null,
 lokacija varchar (50) not null,
 );

 create table rekreativni_ribolov(
 sifra int not null primary key identity (1,1),
 vrsta_ribe varchar (50) not null,
 oprema varchar (40),
 minimalna_mjera decimal (5,2) not null,
 lokacija varchar(50)
 );

 create table ribolov(
 sifra int not null primary key identity (1,1),
 disciplina varchar(50),
 riba varchar (50),
 tehnika varchar (50),
 lokacija varchar (50),
 datum date
 );

 insert into sportski_ribolov(tehnika,vrsta_ribe,lokacija) values
 ('Lov na plovak', 'šaran', 'Jezero Plitvi�ka'),
 ('Lov na plovak', 'Pastrva', 'Rijeka Cetina'),
 ('Lov na dnu', 'Grge�', 'Rijeka Kupa'),
 ('Lov na dnu', 'Losos', 'Rijeka Sava'),
 ('Lov na plovak', 'Trlja', 'Sredozemno more'),
 ('Lov na dnu', 'Zubatac', 'Jadransko more'),
 ('Lov na plovak', 'Tuna', 'Jadransko more'),
 ('Lov na dnu', 'Osli�', 'Jadransko more');

 insert into ribolov (disciplina,riba,tehnika,lokacija,datum) values 
 ('Rekreativni', '�aran', 'Lov na plovak', 'Jezero Plitvi�ka', '2024-05-10'),
 ('Sportski', 'Pastrva', 'Lov na mu�icu', 'Rijeka Cetina', '2024-06-12'),
 ('Rekreativni', 'Grge�', 'Lov na dnu', 'Rijeka Kupa', '2024-07-01'),
 ('Sportski', 'Losos', 'Lov na vobler', 'Rijeka Sava', '2024-08-15'),
 ('Rekreativni', 'Trlja', 'Lov na plovak', 'Sredozemno more', '2024-06-05');