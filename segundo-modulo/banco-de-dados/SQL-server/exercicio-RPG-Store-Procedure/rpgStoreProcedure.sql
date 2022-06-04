create database rpgStoreProcedure


use rpgStoreProcedure


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



create procedure inserirPersonagem
@nome varchar(30),
@tipoPersonagem varchar(15)
as
insert into personagens
values(@nome,@tipoPersonagem)


create procedure inserirItem
@nomeItem varchar(25)
as
insert into itens
values(@nomeItem)


create procedure inserirPersonagemItem
@idPersonagem int,
@idItem int
as
insert into personagem_item
values(@idPersonagem,@idItem)



/*EXERCICIO 01*/
create procedure personagemPorNomeCrescente
as
SELECT personagens.nome,itens.nomeItem FROM personagem_item
INNER JOIN personagens ON personagens.id = personagem_item.idPersonagem
INNER JOIN itens ON itens.id = personagem_item.idItem
ORDER by personagens.nome


/*EXERCÍCIO 02*/
create procedure personagemPorId
@id int
as
SELECT personagens.nome,itens.nomeItem FROM personagem_item
INNER JOIN personagens ON personagens.id = personagem_item.idPersonagem
INNER JOIN itens ON itens.id = personagem_item.idItem
where personagens.id=@id


/*EXERCÍCIO 03*/
create procedure itemPorId
@id int
as
SELECT itens.nomeItem,personagens.nome FROM personagem_item
INNER JOIN personagens ON personagens.id = personagem_item.idPersonagem
INNER JOIN itens ON itens.id = personagem_item.idItem
where itens.id=@id



exec personagemPorNomeCrescente

exec personagemPorId 2

exec itemPorId 2