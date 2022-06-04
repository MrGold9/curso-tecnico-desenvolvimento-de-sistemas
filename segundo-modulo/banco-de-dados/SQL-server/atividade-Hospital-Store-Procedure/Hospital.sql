create database Hospital


use Hospital


create table Paciente(
codigo int primary key identity(1,1),
nome varchar(50),
endereco varchar(100),
telefone char(9),
bairro varchar(25),
cidade varchar(30)
)


create table Medicamento(
codigoMedicamento int primary key identity(1,1),
NomeComercial varchar(20),
NomeGenerico varchar(35),
Laboratorio varchar(40),
Observacoes varchar(200)
)


create table Paciente_Medicacao(
codigo_medicacao int primary key identity(1,1),
codigo_medicamento int,
codigo_paciente int,
data_ date,
hora time,
dosagem varchar(15),
observacoes varchar(200)

constraint fk_codigo_medicamento
foreign key (codigo_medicamento) references Medicamento(codigoMedicamento),
constraint fk_codigo_paciente
foreign key (codigo_paciente) references Paciente(codigo)
)



create procedure cadastrarPaciente
@nome varchar(50),
@endereco varchar(100),
@telefone char(9),
@bairro varchar(25),
@cidade varchar(30)
as
insert into Paciente (nome, endereco, telefone, bairro, cidade)
values(@nome,@endereco, @telefone, @bairro, @cidade)
select codigo, nome, endereco, telefone, bairro, cidade from Paciente
order by codigo desc


create procedure cadastrarMedicamento
@NomeComercial varchar(20),
@NomeGenerico varchar(35),
@Laboratorio varchar(40),
@Observacoes varchar(200)
as
insert into Medicamento (NomeComercial, NomeGenerico, Laboratorio, Observacoes)
values (@NomeComercial, @NomeGenerico, @Laboratorio, @Observacoes)
select codigoMedicamento, NomeComercial, NomeGenerico, Laboratorio, Observacoes 
from Medicamento
order by codigoMedicamento desc


create procedure cadastrarPaciente_Medicacao
@codigo_medicamento int,
@codigo_paciente int,
@data_ date,
@hora time,
@dosagem varchar(15),
@observacoes varchar(200)
as
insert into Paciente_Medicacao (codigo_medicamento, codigo_paciente, data_, hora, dosagem,
observacoes)
values (@codigo_medicamento, @codigo_paciente, @data_, @hora, @dosagem, @observacoes)
select codigo_medicamento, codigo_paciente, data_, hora, dosagem, observacoes
from Paciente_Medicacao
order by codigo_medicacao desc


create procedure mostrarMedicadosHoje
as
select Paciente.nome from Paciente
select Medicamento.NomeComercial from Medicamento
select Paciente_Medicacao.codigo_medicacao, Paciente_Medicacao.codigo_medicamento,
Paciente_Medicacao.codigo_paciente, Paciente_Medicacao.data_, Paciente_Medicacao.dosagem,
Paciente_Medicacao.hora, Paciente_Medicacao.observacoes from Paciente_Medicacao
inner join Paciente on Paciente_Medicacao.codigo_paciente = Paciente.codigo
inner join Medicamento on Paciente_Medicacao.codigo_medicamento = Medicamento.codigoMedicamento
where data_ = '2020-10-28'


create procedure mostrarMedicamentosPaciente
as
select Paciente_Medicacao.codigo_medicacao, Paciente_Medicacao.codigo_medicamento,
Paciente_Medicacao.codigo_paciente from Paciente_Medicacao
inner join Paciente on Paciente_Medicacao.codigo_paciente = Paciente.codigo
inner join Medicamento on Paciente_Medicacao.codigo_medicamento = Medicamento.codigoMedicamento
where codigo = 1


create procedure mostrarPacientesMedicados01
as
select Paciente_Medicacao.codigo_medicacao, Paciente_Medicacao.codigo_medicamento,
Paciente_Medicacao.codigo_paciente, Paciente_Medicacao.data_,
Paciente_Medicacao.dosagem from Paciente_Medicacao
inner join Paciente on Paciente_Medicacao.codigo_paciente = Paciente.codigo
inner join Medicamento on Paciente_Medicacao.codigo_medicamento = Medicamento.codigoMedicamento
where codigoMedicamento = 1 and data_ between '2020-09-01' and '2020-09-30'


create procedure mostrarDosagem
as
select Paciente_Medicacao.codigo_medicacao, Paciente_Medicacao.codigo_medicamento,
Paciente_Medicacao.codigo_paciente, Paciente_Medicacao.data_,
Paciente_Medicacao.dosagem from Paciente_Medicacao
inner join Paciente on Paciente_Medicacao.codigo_paciente = Paciente.codigo
inner join Medicamento on Paciente_Medicacao.codigo_medicamento = Medicamento.codigoMedicamento
where codigo_medicamento=1 and codigo=2 and data_= '2020-10-27'



exec cadastrarPaciente 'Ednaldo Pereira','Rua Adailton Noviço', 400289220, 'Tatuapé',
'São Paulo'

exec cadastrarPaciente 'Nando Moura', 'Rua Nova Granada', 988945325, 'Casa Verde', 
'Belo Horizonte'

exec cadastrarPaciente 'Bruno Alsque', 'Rua Catapimbas', 800840028, 'Liberdade',
'Salvador'

exec cadastrarPaciente 'Josias Machado', 'Rua Bacanudo', 638677690, 'Capão Redondo',
'Manaus'




exec cadastrarMedicamento 'Tylenol', 'Paracetamol', 'Instituto USP',
'Aliviar dores musculares'

exec cadastrarMedicamento 'Xanax', 'Alprazolam', 'Instituto IFBA',
'Contra insônia'

exec cadastrarMedicamento 'Soma', 'Carisoprodol', 'Instituto Butantã',
'Relaxante muscular esquelético'


exec cadastrarPaciente_Medicacao 1, 2, '2020-10-27', '13:05:15', '750mg', 'Tosses frequentes'

exec cadastrarPaciente_Medicacao 2, 1, '2020-10-28', '20:55:19', '2mg', 'Sono excessivo'

exec cadastrarPaciente_Medicacao 3, 3, '2020-09-15', '09:34:23', '350mg', 'Hipertensão muscular'

exec cadastrarPaciente_Medicacao 1, 5, '2020-09-08', '15:21:10', '750mg', 'Hipertensão muscular'


exec mostrarMedicadosHoje

exec mostrarMedicamentosPaciente

exec mostrarPacientesMedicados01

exec mostrarDosagem

