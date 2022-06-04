create database exercicio

use exercicio


create table personagens(
id int primary key identity (1,1),
nome varchar(30) not null,
tipoPersonagem varchar(15) not null)


create table itens(
id int primary key identity (1,1),
nomeItem varchar(25) not null)


create table personagem_item(
id int primary key identity (1,1),
idPersonagem int not null,
idItem int not null,

constraint fk_personagem_personagemItem
foreign key (idPersonagem) references personagens(id),

constraint fk_item_personagemItem
foreign key (idItem) references itens(id)
)


insert into personagens
values('Kleber','Mago')

insert into personagens
values ('Lion','Policial')

insert into personagens
values ('Gustavo','Guerreiro')


select * from personagens


insert into itens
values('Cajado')

insert into itens
values('Pistola')

insert into itens
values('Escudo')

insert into itens
values('Anel Mágico')


select * from personagens


select * from itens


select * from personagem_item


insert into personagem_item
values(3,3)

insert into personagem_item
values(3,2)

insert into personagem_item
values(2,2)


/*EXERCÍCIO 01*/
SELECT personagens.nome,itens.nomeItem FROM personagem_item
INNER JOIN personagens ON personagens.id = personagem_item.idPersonagem
INNER JOIN itens ON itens.id = personagem_item.idItem
ORDER by personagens.nome


/*EXERCÍCIO 02*/
SELECT personagens.nome,itens.nomeItem FROM personagem_item
INNER JOIN personagens ON personagens.id = personagem_item.idPersonagem
INNER JOIN itens ON itens.id = personagem_item.idItem
where personagens.id=1


/*EXERCÍCIO 03*/
SELECT itens.nomeItem,personagens.nome FROM personagem_item
INNER JOIN personagens ON personagens.id = personagem_item.idPersonagem
INNER JOIN itens ON itens.id = personagem_item.idItem
where itens.id=2