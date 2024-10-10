drop database if exists Libreria 
create database Libreria 
Use Libreria 

drop table if exists Libros 
create table Libros(
id INT IDENTITY PRIMARY KEY,
Titulo varchar(30) NOT NULL,
Autor varchar (30) NOT NULL,
Cantidad_Disponible INT NOT NULL,
);
INSERT INTO Libros(Titulo, Autor, Cantidad_Disponible)
Values ('Se�or de los anillos', 'J.R.R Tolkien', 5), 
('AOT', 'Hajime Isayama', 23),
('Dune', 'Frank Herbert', 42), 
('Metro 2033', 'Dmitri Glujovski', 33),
('Berserk','Kentaro Miura',19)
select* FROM Libros