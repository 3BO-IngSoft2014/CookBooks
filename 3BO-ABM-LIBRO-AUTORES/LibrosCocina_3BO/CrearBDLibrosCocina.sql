/*drop schema sistema_cine;*/
create schema sistema_libros_cocina;



CREATE TABLE  sistema_libros_cocina.Libros (
 lib_id INT( 5 ) NOT NULL AUTO_INCREMENT PRIMARY KEY ,
 lib_isbn INT( 13 ) NOT NULL ,
 lib_nombre VARCHAR( 45 ) NOT NULL ,
 lib_stock INT( 6 ) NOT NULL ,
 lib_ventas INT( 6 ) NOT NULL ,
 lib_editorial VARCHAR( 45 ) NOT NULL ,
 lib_edicion INT( 2 ) NOT NULL,
 lib_precio INT(4) NULL
);



CREATE TABLE  sistema_libros_cocina.Autores (
 aut_id INT( 5 ) NOT NULL AUTO_INCREMENT PRIMARY KEY ,
 aut_nombre VARCHAR( 30 ) NOT NULL,
 aut_apellido VARCHAR( 30 ) NOT NULL 
);


CREATE TABLE  sistema_libros_cocina.Clientes (
 cli_nu VARCHAR( 45 ) NOT NULL ,
 cli_nombre VARCHAR( 45 ) NOT NULL ,
 cli_apellido VARCHAR( 45 ) NOT NULL ,
PRIMARY KEY (  cli_nu )
);



CREATE TABLE  sistema_libros_cocina.Tel_clientes (
 tel_nu VARCHAR( 45 ) NOT NULL ,
 tel_particular INT( 45 ) NOT NULL ,
PRIMARY KEY (  tel_nu ,  tel_particular )
);


CREATE TABLE  sistema_libros_cocina.Dir_clientes (
 dir_nu VARCHAR( 45 ) NOT NULL ,
 dir_calle VARCHAR( 45 ) NOT NULL ,
 dir_nro INT( 6 ) NOT NULL ,
 dir_localidad VARCHAR( 45 ) NOT NULL ,
 dir_pcia VARCHAR( 45 ) NOT NULL ,
 dir_pais VARCHAR( 45 ) NOT NULL ,
PRIMARY KEY (  dir_nu ,  dir_calle  )
);










