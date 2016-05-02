create database tetrix;

use tetrix;

create table roles(
roleId smallint not null identity(1,1) primary key, 
roleName varchar(12) not null,
createdtime varchar(20) not null
);

create table records(
recordId smallint not null primary key identity(1,1),
roleId smallint not null,
recordtime varchar(20) not null,
score int not null,
levels int not null
);

create table games(
gameId smallint not null identity(1,1) primary key,
curCoords varchar(8) not null,
nextCoords varchar(8) not null,
state varchar(280) not null，
saveTime varchar(20) not null
);

create table storage(
stoId smallint not null identity(1,1) primary key ,
recordId smallint not null,
roleId smallint not null,
gameId smallint not null
);
