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
ime varchar (50) not null,
prezime varchar (50) not null,
datumrodenja datetime not null,
pozicija varchar (30),
brojdresa int,
klub varchar (50)
);

create table trener(
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
klub varchar (50),
nacionalnost varchar (40),
iskustvo int
);

create table utakmica (
sifra int not null primary key identity (1,1),
datum datetime not null, 
vrijeme time not null,
lokacija varchar (50) not null,
stadion varchar (50),
domaciklub varchar (50),
gostojuciklub varchar (50)
);

create table klub (
sifra int not null primary key identity (1,1),
naziv varchar (50)not null  ,
osnovan int ,
stadion varchar (50),
predsjednik varchar (50) not null,
drzava varchar (50),
liga varchar (50)
);