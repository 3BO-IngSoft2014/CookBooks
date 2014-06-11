
create schema sistema_libros_cocina;



CREATE TABLE sistema_libros_cocina.libros_autores (
 idA INT( 5 ) NOT NULL AUTO_INCREMENT ,
 isbn INT( 13 ) NOT NULL ,
 nombreA VARCHAR(45) NOT NULL, 
 nombreL VARCHAR(45) NOT NULL,
 stock VARCHAR (45) NOT NULL, 
 vendidos VARCHAR(45) NOT NULL,
 PRIMARY KEY (  idA ,  isbn )
) ;



CREATE TABLE  sistema_libros_cocina.PreguntasYRespuestas (
 preg_id INT( 5 ) NOT NULL AUTO_INCREMENT,
 preg VARCHAR( 450 ) NOT NULL ,
 resp VARCHAR( 450 ) NOT NULL , 
 PRIMARY KEY (preg_id)
);



CREATE TABLE  sistema_libros_cocina.UsuariosLogueados (
 id INT( 5 ) NOT NULL AUTO_INCREMENT,
 nombre VARCHAR ( 30) NOT NULL ,
 pass int( 30 ) NOT NULL , 
 PRIMARY KEY (id)
);