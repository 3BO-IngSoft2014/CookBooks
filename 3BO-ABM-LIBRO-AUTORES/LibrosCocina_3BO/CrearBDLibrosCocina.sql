/*drop schema sistema_cine;*/
create schema sistema_libros_cocina;


CREATE TABLE sistema_libros_cocina.Libros (

libro_id INT NOT NULL AUTO_INCREMENT ,

autor_id INT NULL ,

nombre VARCHAR(45) NULL ,

precio INT NULL , 

editorial VARCHAR(45) NULL ,

PRIMARY KEY (libro_id) );

CREATE TABLE sistema_libros_cocina.Autores (

autor_id INT NOT NULL AUTO_INCREMENT ,

libro_id INT NULL ,

nombre VARCHAR(45) NULL ,

PRIMARY KEY (autor_id) );

