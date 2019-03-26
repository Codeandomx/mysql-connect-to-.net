-- create database dotnet

create table users(
	id_user int auto_increment,
    username varchar(50) not null,
    name varchar(50) not null,
    lastname varchar(50) not null,
    correo varchar(100) not null,
    pass varchar(50) not null,
    fecha_registro datetime default now(),
    fecha_actualizacion datetime default null,
    primary key(id_user)
) engine = innodb;