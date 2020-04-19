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
select Id,nombre,tipo_licencia from conductor

exec registrarVehiculo '1','Mazda','2018','DFS298'

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