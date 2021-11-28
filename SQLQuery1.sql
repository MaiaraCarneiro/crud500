create database BDPersonagens
go
use BDPersonagens
go

create table Personagem
(
  IdContato   int           primary key   identity,
  Id        varchar(60)   not null,
  Nome      varchar(60)  not null,
)

