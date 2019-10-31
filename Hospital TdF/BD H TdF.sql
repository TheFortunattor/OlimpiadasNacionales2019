drop database DBHosp;

create database DBHosp;
use DBHosp;


create table doctores(
    DNI int primary key,
    nombre varchar(30),
    apellido varchar (30),
    fecha_Nac int,
    telefono int,
    ocupado boolean
);

insert into doctores values
(43241614,"Alejo","Garcia Misztal",1985-08-24,1160469999,0),
(42424218, "Ignacio","Agustin dorado",1991-12-04, 3855393300,0),
(43361594, "David","Gabriel Frontera",1999-11-29,3854886789,0);

create table SectHab(
    ID int primary key auto_increment,
    sector varchar (30),
    habitacion int,
    ocupado boolean
);

insert into SectHab values
(1,"sector A",1,1),
(2,"sector B",2,1),
(3,"sector C",3,0),
(4,"sector D",4,0),
(5,"sector E",5,0),
(6,"sector F",6,0),
(7,"seCtor G",7,0),
(8,"sector H",8,0),
(9,"sector I",9,0),
(10,"sector J",10,0),
(11,"sector k",11,0);

create table pacientes(
    DNI int primary key,
    nombre varchar (30),
    apellido varchar (30),
    telefono int,
    tipo_de_sangre varchar(5),
    PH float,
    idHab int,
    DNIdoct int,
    constraint fkDNIdoct foreign key (DNIdoct) references doctores (DNI),
    constraint fkIdHab foreign key (idHab) references SectHab (ID) 
);

insert into pacientes values
(4534343,"Moca","Aoba",1155443355,"A+",7.3,1,43241614),
(42345678,"Yukina","Minato",1176874565,"B+",7.7,2,43241614),
(41435432,"Kokoro","Tsurumaki",1143565123,"AB-",8.0,3,43361594),
(40987487,"Algo","Apellidazo",1122222222,"0+",7.3,4,42424218);

create table alarma(
    ID int primary key auto_increment,
    fecha date,
    tiempo_act time,
    tiempo_resp time,
    urgencia boolean,
    fkidSec int,
    constraint fkidSec foreign key (fkidSec) references SectHab (ID)
);

insert into alarma values
(1,"2019-10-29","13:00","13:01",0,1),
("","2019-11-30","18:27","18:28",1,2),
("","2019-11-01","11:15","11:16",1,3);

create table usuarios(
    ID int primary key auto_increment,
    usuario varchar (30),
    contraseña varchar (30),
    nivel int
);

insert into usuarios values
(1,"Franco","F4nc0",1),
("","Admin","4dm1n",2),
("","logan","logan2.0",1);



