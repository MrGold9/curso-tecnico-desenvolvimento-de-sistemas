create database Atividade_Q2


use Atividade_Q2


create table veiculos(
placa varchar(7) primary key not null,
marca varchar(20) not null,
modelo varchar(20) not null,
cor varchar(20) not null,
opcionais varchar(100) null,
ano int not null,
valorCompra float not null,
valorVenda float not null
)
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('DAB7135', 'CHEVROLET', 'ONIX', 'Vermelho', 'Possui teto solar', 2003, 41000, 57999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('DAB6661', 'CHEVROLET', 'CAMARO', 'Amarelo', 'Listras pretas', 2000, 72000, 89999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('DAB9021', 'CHEVROLET', 'CRUZE', 'Preto', 'Contém spoiler', 2011, 51000, 69999 )

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('PDP0800', 'VOLKS', 'FOX', 'Azul', 'Câmbio automático', 2005, 85000, 91999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('ASS6945', 'VOLKS', 'GOL', 'Vinho', 'Câmbio manual', 1998, 75000, 81999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('MNO1234', 'VOLKS', 'ATLAS', 'Laranja', 'Possui rádio embutido', 2018, 49999, 79999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('RPG5563', 'FORD', 'FOCUS', 'Prata', 'Possui conexão bluetooth', 1999, 45555, 49999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('ABC7213', 'FORD', 'FUSION', 'Verde', 'Utilização de combustível econômica', 2017, 82000, 99999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('DNA4902', 'FORD', 'ESCAPE', 'Gelo', 'Possui motor híbrido', 2009, 53000, 61999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda)
 values ('FAT3200', 'FIAT', 'PANDA', 'Rosa', 'Wi-fi integrado', 2008, 49000, 59999)


 select * from veiculos


select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
order by modelo

select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
order by valorVenda desc

select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
order by ano

select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
where placa like 'DAB%'

select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
where marca='CHEVROLET'


select count(placa) as 'Quantidade de veículos' from veiculos


select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
where ano<2010


select count(placa) as 'Veículos entre 2011 e 2016' from veiculos
where ano> 2011 and ano<2016


select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
where valorCompra>50000 and valorCompra<65000

select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
where opcionais!=''

select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
where marca='VOLKS' and valorVenda>30000 and ano>= 2013 and ano<= 2017

select placa, marca, modelo, cor, opcionais, ano, valorCompra, valorVenda from veiculos
where marca='FORD' and ano=2011 and opcionais!=''
order by modelo



select * from veiculos