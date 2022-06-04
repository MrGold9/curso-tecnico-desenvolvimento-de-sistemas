create database AtividadeDDL

use AtividadeDDL

create table Aluno(
matricula numeric(4) primary key,
nome varchar(20),
escola varchar(20)
)

create table Disciplina(
codigo char(5) primary key,
nome varchar(20),
registro char(5),
escola varchar(20)
)

create table Historico(
matricula numeric(4) primary key,
codigo char(5),
nota numeric(3)
)

create table Professor(
registro char(5) primary key,
nome varchar(20),
admissão integer
)


alter table Aluno
add telefone char (8)

alter table Aluno
drop column telefone

alter table Professor
add Formação varchar(15)

alter table Aluno
add email varchar(35)

alter table Disciplina
drop column registro

alter table Historico
add bimestre int

alter table Aluno
drop column escola

drop table Aluno
drop table Disciplina
drop table Historico
drop table Professor

drop database AtividadeDDL