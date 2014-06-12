
/*drop schema sistema_cine;*/
create schema sistema_libros_cocina;

CREATE TABLE  sistema_libros_cocina.libros (
 lib_isbn INT( 5 ) NOT NULL ,
 lib_nombre VARCHAR( 45 ) NOT NULL ,
 lib_stock INT( 6 ) NOT NULL ,
 lib_editorial VARCHAR( 45 ) NOT NULL ,
 lib_edicion VARCHAR( 45 ) NOT NULL,
 lib_precio INT(4) NULL ,
PRIMARY KEY (lib_isbn)
);

CREATE TABLE  sistema_libros_cocina.usuario (
nombreUsuario VARCHAR( 45 ) NOT NULL ,
pass INT( 13 ) NOT NULL ,
nombre VARCHAR( 45 ) NOT NULL ,
apellido VARCHAR( 45 ) NOT NULL ,
direccion VARCHAR( 45 ) NOT NULL ,
email VARCHAR( 45 ) NOT NULL ,
telefono INT(4) NULL ,
PRIMARY KEY ( nombreUsuario)
);


CREATE TABLE  sistema_libros_cocina.autores (
 aut_id INT( 5 ) NOT NULL  AUTO_INCREMENT,
 aut_nombre VARCHAR( 30 ) NOT NULL ,
 aut_apellido VARCHAR( 30 ) NOT NULL ,
 lib_isbn_ID INT (5) NOT NULL ,
PRIMARY KEY (aut_id)
);


CREATE TABLE  sistema_libros_cocina.autores_libros (
 aut_lib_id INT( 5 ) NOT NULL AUTO_INCREMENT ,
 aut_id INT( 5 ) NOT NULL ,
 lib_isbn INT (5) NOT NULL ,
PRIMARY KEY (aut_lib_id)
);


CREATE TABLE  sistema_libros_cocina.dir_usuario (
dir_us INT( 5 ) NOT NULL AUTO_INCREMENT,
nombreUsuario VARCHAR( 45 ) NOT NULL ,
us_email VARCHAR( 45 ) NOT NULL ,
us_telefono1 VARCHAR( 45 ) NOT NULL,
us_telefono2 VARCHAR( 45 ) ,
dir_calle VARCHAR( 45 ) NOT NULL ,
dir_localidad VARCHAR( 45 ) NOT NULL ,
dir_provincia VARCHAR( 45 ) NOT NULL ,
dir_pais VARCHAR( 45 ) NOT NULL ,
PRIMARY KEY ( dir_us )
);


CREATE TABLE  sistema_libros_cocina.compra (
 comp_id INT( 5 ) NOT NULL AUTO_INCREMENT ,
 lib_isbn_ID INT( 13 ) NOT NULL ,
 nombreUsuario_ID INT( 13 ) NOT NULL , 
 comp_fecha DATE NOT NULL ,
PRIMARY KEY ( comp_id )
);

CREATE TABLE  sistema_libros_cocina.PreguntasYRespuestas (
 preg_id INT( 5 ) NOT NULL AUTO_INCREMENT,
 preg VARCHAR( 450 ) NOT NULL ,
 resp VARCHAR( 450 ) NOT NULL , 
 PRIMARY KEY (preg_id)
);




SET FOREIGN_KEY_CHECKS =0;
ALTER TABLE sistema_libros_cocina.autores ADD FOREIGN KEY (lib_isbn) REFERENCES libros (lib_isbn);
ALTER TABLE sistema_libros_cocina.autores_libros ADD FOREIGN KEY (aut_id) REFERENCES autores (aut_id); 
ALTER TABLE sistema_libros_cocina.autores_libros ADD FOREIGN KEY (lib_isbn_ID) REFERENCES libros(lib_isbn);
ALTER TABLE sistema_libros_cocina.compra ADD FOREIGN KEY (nombreUsuario_ID) REFERENCES usuario (nombreUsuario); 
ALTER TABLE sistema_libros_cocina.compra ADD FOREIGN KEY (lib_isbn_ID) REFERENCES libros(lib_isbn);
ALTER TABLE sistema_libros_cocina.dir_usuario ADD FOREIGN KEY (nombreUsuario) REFERENCES usuario (nombreUsuario);

