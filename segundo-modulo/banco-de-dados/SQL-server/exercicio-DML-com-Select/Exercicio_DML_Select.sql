create database Exercicio_DML_Select

use Exercicio_DML_Select

create table Alunos(
Id int primary key,
Nome varchar(50) not null,
NomeCurso varchar (20) not null,
Nota1 float,
Nota2 float,
Media float,
Situacao varchar(15)
)
values (1, 'Naruto', 'INFORM�TICA', 5, 10)
values (2, 'Dio', 'ADMINISTRA��O', 4.5, 3)
values (3, 'Irineu', 'INFORM�TICA', 2.5, 2)
values (4, 'Galv�o', 'ADMINISTRA��O', 9, 7)
values (5, 'Marx', 'INFORM�TICA', 6, 5)
where NomeCurso='INFORM�TICA' and Media< 6
where media>= 6

update Alunos set situacao= 'REVIS�O'
where media< 6
where media>=6 and media<=9
where Nome='Dio'
where NomeCurso='ADMINISTRA��O' and (Nota1> 8 or Nota2> 8)
order by Media desc
where Nota1< 5
order by Nota1
where NomeCurso='INFORM�TICA' and Media>= 9 and Media<= 10
where Situacao='REVIS�O' and Media=2
where NomeCurso='INFORM�TICA' and Nota1< 5 or Nota2< 5