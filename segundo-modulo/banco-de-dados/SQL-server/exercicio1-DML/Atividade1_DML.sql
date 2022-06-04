create database Atividade1_DML


use Atividade1_DML


create table Alunos(
id int primary key,
nome varchar(50) not null,
nomeCurso varchar(20) not null,
nota1 float not null,
nota2 float,
media float,
situacao float
)insert into Alunos
(id, nome, nomeCurso, nota1, nota2)
values (1, 'Jailson Mendes', 'Gastronomia', 5, 7)insert into Alunos
(id, nome, nomeCurso, nota1, nota2)
values (2, 'Itachi Uchiha', 'Design de Interiores', 10, 10)

insert into Alunos
(id, nome, nomeCurso, nota1, nota2)
values (3, 'Cleiton Rasta', 'Música', 5, 3.5)

insert into Alunos
(id, nome, nomeCurso, nota1, nota2)
values (4, 'Ednaldo Pereira', 'Administração', 9, 6)

insert into Alunos
(id, nome, nomeCurso, nota1, nota2)
values (5, 'Joseph Joestar', 'Moda', 6, 8)


update Alunos set media= (nota1 + nota2) / 2


alter table Alunos
alter column situacao varchar(10)

update Alunos set situacao= 'APROVADO'
where media> 6

update Alunos set situacao= 'REVISÃO'
where media<= 6

select * from Alunos