create database InserirAtualizarDeletar

use InserirAtualizarDeletar

create table veiculos(
placa varchar(7) primary key not null,
marca varchar(20) not null,
modelo varchar(20) not null,
cor varchar(20) not null,
opcionais varchar(100) null,
ano int not null,
valorCompra float not null
)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('DAB7135', 'CHEVROLET', 'ONIX', 'Vermelho', 'Possui teto solar', 2003, 41.999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('DAB6661', 'CHEVROLET', 'CAMARO', 'Amarelo', 'Listras pretas', 2000, 35.999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('DAB9021', 'CHEVROLET', 'CRUZE', 'Preto', 'Contém spoiler', 2010, 25.999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('PDP0800', 'VOLKS', 'FOX', 'Azul', 'Câmbio automático', 2005, 21.999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('ASS6945', 'VOLKS', 'GOL', 'Vinho', 'Câmbio manual', 1999, 19.999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('MNO1234', 'VOLKS', 'ATLAS', 'Laranja', 'Possui rádio embutido', 2014, 49.999)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('RPG5563', 'FORD', 'FOCUS', 'Prata', 'Possui conexão bluetooth', 2013, 45.555)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('ABC7213', 'FORD', 'FUSION', 'Verde', 'Utilização de combustível econômica', 2010, 32.599)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('DNA4902', 'FORD', 'ESCAPE', 'Gelo', 'Possui motor híbrido', 2009, 24.885)

insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra)
 values ('FAT3200', 'FIAT', 'PANDA', 'Rosa', 'Wi-fi integrado', 2008, 49.999)


 alter table veiculos
 add valorVenda float

 alter table veiculos
 add valoresReais float

update veiculos set valorVenda=(valorCompra*1.4)


delete from veiculos
where placa = 'ABC7213'


 alter table veiculos
 add cidadeRegistro varchar(30) 


 update veiculos set cidadeRegistro='Diadema'
 where placa='ASS6945'

 update veiculos set cidadeRegistro='Campinas'
 where placa='DAB6661'

update veiculos set cidadeRegistro='São Paulo'
where placa='DAB7135'

update veiculos set cidadeRegistro='Londrina'
where placa='DAB9021'

update veiculos set cidadeRegistro='Porto Seguro'
where placa='DNA4902'

update veiculos set cidadeRegistro='Mariporã'
where placa='FAT3200'

update veiculos set cidadeRegistro='Florianópolis'
where placa='MNO1234'

update veiculos set cidadeRegistro='Curitiba'
where placa='PDP0800'

update veiculos set cidadeRegistro='Santos'
where placa='RPG5563'


update veiculos set valorVenda=valorVenda - (valorVenda * 0.1)
where ano>= 2000 and ano<= 2005


update veiculos set valorVenda=valorVenda - (valorVenda * 0.05)
where ano> 2013


update veiculos set valorVenda=valorVenda + (valorVenda * 0.03)
where marca= 'FORD'


update veiculos set valorVenda=valorVenda - (valorVenda * 0.05)
where modelo= 'PALIO'


alter table veiculos
drop column opcionais

 select * from veiculos