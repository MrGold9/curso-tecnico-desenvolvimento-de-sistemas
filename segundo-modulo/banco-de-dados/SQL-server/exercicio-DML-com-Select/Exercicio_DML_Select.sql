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
)insert into Alunos (Id, Nome, NomeCurso, Nota1, Nota2)
values (1, 'Naruto', 'INFORMÁTICA', 5, 10)insert into Alunos (Id, Nome, NomeCurso, Nota1, Nota2)
values (2, 'Dio', 'ADMINISTRAÇÃO', 4.5, 3)insert into Alunos (Id, Nome, NomeCurso, Nota1, Nota2)
values (3, 'Irineu', 'INFORMÁTICA', 2.5, 2)insert into Alunos (Id, Nome, NomeCurso, Nota1, Nota2)
values (4, 'Galvão', 'ADMINISTRAÇÃO', 9, 7)insert into Alunos (Id, Nome, NomeCurso, Nota1, Nota2)
values (5, 'Marx', 'INFORMÁTICA', 6, 5)update Alunos set Media= (Nota1 + Nota2) / 2select Id, Nome, NomeCurso, Nota1, Nota2, Media, Situacao from Alunos
where NomeCurso='INFORMÁTICA' and Media< 6update Alunos set situacao= 'APROVADO'
where media>= 6

update Alunos set situacao= 'REVISÃO'
where media< 6select Id, Nome, NomeCurso, Nota1, Nota2, Media, Situacao from Alunos
where media>=6 and media<=9order by Nomeupdate Alunos set Nome= 'Dio Brando'
where Nome='Dio'select Id, Nome, NomeCurso, Nota1, Nota2, Media, Situacao from Alunos
where NomeCurso='ADMINISTRAÇÃO' and (Nota1> 8 or Nota2> 8)order by Nomeselect Id, Nome, NomeCurso, Nota1, Nota2, Media, Situacao from Alunos
order by Media descselect avg(Media) as 'Media geral dos alunos' from Alunosselect Id, Nome, NomeCurso, Nota1, Nota2, Media, Situacao from Alunos
where Nota1< 5
order by Nota1select sum(Media) as 'Soma das médias inferiores a 5' from Alunoswhere Media< 5select avg(Media) as 'Média aritmética de todas as médias acima de 7' from Alunoswhere Media> 7select count(Nome) as 'Alunos de informática com média entre 9 e 10' from Alunos
where NomeCurso='INFORMÁTICA' and Media>= 9 and Media<= 10select Nome as 'Alunos em revisão com média menor que 2' from Alunos
where Situacao='REVISÃO' and Media=2order by NomeCursoselect Nome as 'Alunos de informática que possuem a primeira e segunda nota menor que 5' from Alunos
where NomeCurso='INFORMÁTICA' and Nota1< 5 or Nota2< 5select * from Alunos