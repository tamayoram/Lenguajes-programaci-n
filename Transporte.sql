use master

create database transporte

use transporte

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

//procedimiento almacenado para insertar registros en conductor

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

select * from conductor
select * from vehiculo

exec registrarVehiculo '1','Mazda','2018','DFS298'

exec registrarConductor '1','Camilo','A','1','32'



