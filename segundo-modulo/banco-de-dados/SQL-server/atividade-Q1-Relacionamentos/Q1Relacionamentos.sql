create database Q1Relacionamentos

use Q1Relacionamentos


create table Proprietarios(
id int primary key identity(1,1),
nome varchar(30) not null
)



create table Veiculos(
placa varchar(7) primary key not null,
marca varchar(20) not null
)



create table Multas(
id int primary key identity(1,1),
infracao varchar(30),
idProprietario int not null,
placaVeiculo varchar(7) not null,

constraint fk_proprietario_proprietarioMulta
foreign key (idProprietario) references Proprietarios(id),

constraint fk_veiculo_veiculoMulta
foreign key (placaVeiculo) references Veiculos(placa)
)



insert into Proprietarios
(nome)
values('Cleiton Rasta')

insert into Proprietarios
(nome)
values('Chad Thundercock')

insert into Proprietarios
(nome)
values('Super Xandão')



insert into Veiculos
(placa, marca)
values('BOB7712', 'CHEVROLET')

insert into Veiculos
(placa, marca)
values('ABC5432', 'HONDA')

insert into Veiculos
(placa, marca)
values('SUS0110', 'BMW')

insert into Veiculos
(placa, marca)
values('USB4321', 'FORD')



insert into Multas
(infracao, idProprietario, placaVeiculo)
values('Estacionamento proibido', 1, 'SUS0110')

insert into Multas
(infracao, idProprietario, placaVeiculo)
values('Pneu careca', 1, 'USB4321')

insert into Multas
(infracao, idProprietario, placaVeiculo)
values('Dirigir alcoolizado', 2, 'BOB7712')

insert into Multas
(infracao, idProprietario, placaVeiculo)
values('Excesso de velocidade', 3, 'ABC5432')



select  Multas.infracao, Proprietarios.id, Proprietarios.nome, Veiculos.placa, Veiculos.marca from Multas
inner join Veiculos on Multas.placaVeiculo= Veiculos.placa
inner join Proprietarios on Multas.idProprietario= Proprietarios.id
where Proprietarios.id= 1


select  Multas.infracao, Proprietarios.id, Proprietarios.nome, Veiculos.placa, Veiculos.marca from Multas
inner join Veiculos on Multas.placaVeiculo= Veiculos.placa
inner join Proprietarios on Multas.idProprietario= Proprietarios.id
where Multas.placaVeiculo= 'BOB7712'


select  Multas.infracao, Proprietarios.id, Proprietarios.nome, Veiculos.placa, Veiculos.marca from Multas
inner join Veiculos on Multas.placaVeiculo= Veiculos.placa
inner join Proprietarios on Multas.idProprietario= Proprietarios.id
where Multas.infracao= 'Estacionamento proibido'



select * from Proprietarios
select * from Veiculos
select * from Multas