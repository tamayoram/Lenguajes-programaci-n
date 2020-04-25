use master

create database transporte

use transporte

/******** Tablas conductor y vehículo *******/

/*Create*/

create table conductor(
Id  int primary key,
nombre varchar(255),
tipo_licencia varchar(255),
id_vehiculo int,
id_tipo_conductor int,
)

create table vehiculo(
id_vehiculo int primary key,
marca varchar(255),
modelo varchar(255),
matricula varchar(255),
)

alter table conductor
add constraint FKvehiculo_conductor foreign key(id_vehiculo) references vehiculo(id_vehiculo)

/*Procedimiento insertar*/

create proc registrarConductor
(
	@Id  int,
	@nombre varchar(255),
	@tipo_licencia varchar(255),
	@id_vehiculo int,
	@id_tipo_conductor int

)

as insert into conductor values(@Id,@nombre,@tipo_licencia,@id_vehiculo,@id_tipo_conductor)

create proc registrarVehiculo
(

	@id_vehiculo int,
	@marca varchar(255),
	@modelo varchar(255),
	@matricula varchar(255)

)

as insert into vehiculo values(@id_vehiculo,@marca,@modelo,@matricula)

select * from vehiculo
select * from conductor
select * from contrato
select * from ruta


select Id,nombre,tipo_licencia from conductor

exec registrarVehiculo '9','Mazda','2018','DFS298','18'

exec registrarConductor '1','Camilo','A','1','32'


/*Procedimient Update*/

create proc actualizarConductor
(
	@Id  int,
	@nombre varchar(255),
	@tipo_licencia varchar(255)
)

as update conductor set nombre=@nombre,tipo_licencia=@tipo_licencia where Id=@Id


create proc actualizarVehiculo
(

	@id_vehiculo int,
	@marca varchar(255),
	@modelo varchar(255),
	@matricula varchar(255)
	
)

as update vehiculo set marca=@marca,modelo=@modelo,matricula=@matricula where id_vehiculo=@id_vehiculo

/*Procedimient Delete*/

create proc eliminarConductor
(
	@Id  int
)

as delete from conductor where Id=@Id


create proc eliminarVehiculo
(

	@id_vehiculo int
		
)

as delete from vehiculo where id_vehiculo=@id_vehiculo



/*****************Tablas tipo conductor y tipo vehiculo ***********/

/*Create*/

create table tipoConductor(
Id  int primary key,
nombre varchar(255),
)

create table tipoVehiculo(
id_vehiculo int primary key,
nombre varchar(255),
)

/*Procedimiento insert*/

create proc registrarTipoConductor
(
	@Id  int,
	@nombre varchar(255)
)


as insert into tipoConductor values(@Id,@nombre)

create proc registrarTipoVehiculo
(

	@id_vehiculo int,
	@nombre varchar(255)
	
)

as insert into tipoVehiculo values(@id_vehiculo,@nombre)

/*Procedimiento Update*/

create proc actualizarTipoConductor
(
	@Id  int,
	@nombre varchar(255)
)

as update tipoConductor set nombre=@nombre where Id=@Id


create proc actualizarTipoVehiculo
(

	@id_vehiculo int,
	@nombre varchar(255)
	
)

as update tipoVehiculo set nombre=@nombre where id_vehiculo=@id_vehiculo


/*Procedimiento Delete*/

create proc eliminarTipoConductor
(
	@Id  int
)

as delete from tipoConductor where Id=@Id


create proc eliminarTipoVehiculo
(

	@id_vehiculo int
		
)

as delete from tipoVehiculo where id_vehiculo=@id_vehiculo

select * from tipoVehiculo
select * from tipoConductor

/***********Tablas contrato y ruta*************/

/*Create*/

create table contrato(
Id  int primary key,
id_conductor int not null,
id_vehiculo int not null,
)

create table ruta(
Id int primary key,
estacion varchar(255),
id_vehiculo int not null,
)

/*Procedimiento insert*/

create proc registrarContrato
(
	@Id  int,
	@id_conductor int,
	@id_vehiculo int
)

as insert into contrato values(@Id,@id_conductor,@id_vehiculo)

exec registrarContrato '1234','6','4'

create proc registrarRuta
(

	@Id int,
	@estacion varchar(255),
	@id_vehiculo int
	
)

as insert into ruta values(@Id,@estacion,@id_vehiculo)

/*Procedimiento Update*/

create proc actualizarContrato
(
	@Id  int,
	@id_conductor int,
	@id_vehiculo int
)

as update contrato set id_conductor=@id_conductor,id_vehiculo=@id_vehiculo where Id=@Id


create proc actualizarRuta
(

	@Id int,
	@estacion varchar(255),
	@id_vehiculo int
	
)

as update ruta set estacion=@estacion, @id_vehiculo=id_vehiculo where Id=@Id


/*Procedimiento Delete*/

create proc eliminarContrato
(
	@Id  int
)

as delete from contrato where Id=@Id


create proc eliminarRuta
(

	@Id int
		
)

as delete from ruta where Id=@Id

select * from contrato
select * from ruta

/******Relaciones entre las tablas******/

/*Id tipo de conductor en la tabla conductor*/

select * from conductor
delete from conductor

alter table conductor 
add id_tipo_conductor int not null

alter table conductor
alter column id_tipo_conductor int not null


alter table conductor
add constraint FKconductor_tipo foreign key(id_tipo_conductor) references tipoConductor(Id)  

/*Id tipo de vehiculo en la tabla vehiculo*/

select * from vehiculo
delete from vehiculo

alter table vehiculo 
add id_tipo_vehiculo int not null

alter table vehiculo
add constraint FKvehiculo_tipo foreign key(id_tipo_vehiculo) references tipoVehiculo(id_vehiculo) 

/*Id de conductor en contrato*/

alter table contrato
add constraint FKconductor_contrato foreign key(id_conductor) references conductor(Id)

/*Id de vehiculo en contrato*/

alter table contrato
add constraint FKvehiculo_contrato foreign key(id_vehiculo) references vehiculo(id_vehiculo) 

/*Id de vehiculo en ruta*/

alter table ruta
add constraint FKvehiculo_ruta foreign key(id_vehiculo) references vehiculo(id_vehiculo) 