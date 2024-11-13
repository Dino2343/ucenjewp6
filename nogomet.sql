use master;
go 
drop database if exists nogomet;
go

create database nogomet;
go

use nogomet; 
go

create table igrac(
sifra int not null primary key identity (1,1),
ime ime varchar (50) not null,
prezime varchar (50) not null,
datumrodenja datetime not null,
pozicija varchar (30),
brojdresa int,
klub varchar (50)
);

create table trener(
sifra int 
ime ime varchar (50) not null,
prezime varchar (50) not null,
klub varchar (50),
nacionalnost varchar (40),
iskustvo int
);

create table utakmica 