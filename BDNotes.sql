create database notas;
use notas;

create table nota(
	id int(3) auto_increment primary key,
    titulo varchar(50),
    conteudo varchar(2000),
    username int(5) references login
);
create table login(
	id_user int(5) auto_increment primary key,
	username varchar(50),
    senha varchar(50),
    nome varchar(50),
    qnt int(5)
);

select * FROM login;