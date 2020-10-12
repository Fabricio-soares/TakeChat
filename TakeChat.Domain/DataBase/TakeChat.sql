Create DataBase TakeChat
Go

use TakeChat

CREATE TABLE Usuario (
    id uniqueidentifier Primary key default(NEWID()),
    nome_usuario varchar(150),
    apelido varchar(100),

);

CREATE TABLE Sala (
    id uniqueidentifier Primary key default(NEWID()),
    nome_sala varchar(150),
    ativa bit,
);

CREATE TABLE Usuario_has_Sala (
	id uniqueidentifier  Primary key default(NEWID()),
    id_usuario uniqueidentifier,  
    id_sala uniqueidentifier,
	ativa bit,
	data_inclusao date default(GETDATE())
);

CREATE TABLE Mensagem (
	id uniqueidentifier  Primary key default(NEWID()),
    conteudo varchar(max),  
    id_sala uniqueidentifier,
    id_usuario_env uniqueidentifier,  
    id_usuario_rec uniqueidentifier,  
    data_env datetime default(GETDATE()),  
);

ALTER TABLE Usuario_has_Sala
ADD FOREIGN KEY (id_usuario) REFERENCES Usuario(id);

ALTER TABLE Usuario_has_Sala
ADD FOREIGN KEY (id_sala) REFERENCES Sala(id);

ALTER TABLE Mensagem
ADD FOREIGN KEY (id_sala) REFERENCES Sala(id);

ALTER TABLE Mensagem
ADD FOREIGN KEY (id_usuario_env) REFERENCES Usuario(id);

ALTER TABLE Mensagem
ADD FOREIGN KEY (id_usuario_rec) REFERENCES Usuario(id);