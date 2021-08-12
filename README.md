# Avaliacao.API

As tecnologias utilizadas no projeto foram: 
ASP NET CORE 3.1 com Entity Framework e SQL Server.

Seguir as instruções a abaixo:

1º - Execute o script a abaixo no servidor de banco de dados SQL SERVER;
2º - No arquivo appsettings.json troque o nome do servidor;
3º - Execute aplicação;
4º - Ralize testes usando swagger;

-- Script de Criação do banco e suas tabelas.

Create database AVALIACAO
Go

Use AVALIACAO
Go

	Create Table StatusAccommodation
   (
	 Id uniqueidentifier primary key,  
     Description varchar(20) not null	 	 
	)
Go

	Create Table Accommodation
   (
	 Id uniqueidentifier primary key,  
     StatusId uniqueidentifier references StatusAccommodation(Id) not null,
	 Description varchar(20) not null      	 
	)
Go

	Create Table StatusHealth
  (
	Id uniqueidentifier primary key,
	Description varchar(20) not null
   )
   
Go

   Create Table Adress
  (
    Id uniqueidentifier primary key,
    AdressName varchar(120) not null,
    Number varchar(20) not null,
    City varchar(100) not null,
	State char(2) not null,
	Country varchar(20) not null,
	PostalCode varchar(16) not null
  )
  
Go

	Create Table PetOwners
  (
    Id uniqueidentifier primary key,
    OwnerName varchar(255) not null,
    Phone varchar(11) null,
    AdressId uniqueidentifier references Adress(Id) not null 
  )
  
Go

	Create Table Pets
  (
   Id uniqueidentifier primary key,
   PetName varchar(255) not null,
   PetOwnerId uniqueidentifier references PetOwner(Id) not null,
   Justification varchar(100) not null,
   StatusHealthId uniqueidentifier references StatusHealth(Id) not null,
   AccommodationId uniqueidentifier references Accommodation(Id) not null
  )
  
  
Inserts

Tabela - StatusHealth

INSERT INTO StatusHealth VALUES(NEWID(), 'Em Tratamento')
INSERT INTO StatusHealth VALUES(NEWID(), 'Se Recuperando')
INSERT INTO StatusHealth VALUES(NEWID(), 'Recuperado')


Tabela - StatusAccommodation

INSERT INTO Accommodation VALUES(NEWID(), 'Esperando Dono')
INSERT INTO Accommodation VALUES(NEWID(), 'Ocupado')
INSERT INTO Accommodation VALUES(NEWID(), 'Livre')


Tabela - Accommodation

INSERT INTO Accommodation VALUES(NEWID(), (SELECT sa.id FROM StatusAccommodation sa WHERE sa.Description = 'Livre'), (SELECT sa.Description FROM StatusAccommodation sa WHERE sa.Description = 'Livre'))
INSERT INTO Accommodation VALUES(NEWID(), (SELECT sa.id FROM StatusAccommodation sa WHERE sa.Description = 'Ocupado'), (SELECT sa.Description FROM StatusAccommodation sa WHERE sa.Description = 'Ocupado'))
INSERT INTO Accommodation VALUES(NEWID(), (SELECT sa.id FROM StatusAccommodation sa WHERE sa.Description = 'Esperando Dono'), (SELECT sa.Description FROM StatusAccommodation sa WHERE sa.Description = 'Esperando Dono'))


