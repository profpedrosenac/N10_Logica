create database N10_Ferragens

use N10_Ferragens

create table usuario
(
	id_usuario int not null identity primary key,
	nome_usuario varchar(50) not null,
	login_usuario varchar(30) not null unique,
	senha_usuario varchar(30) not null, 
	email_usuario varchar(30) not null unique,
	obs_usuario varchar(255) null,
	status_usuario varchar(30) not null
)

select * from usuario
select nome_usuario, login_usuario from usuario

-- deleta a tabela do banco de dados.
drop table usuario

create table funcionario
(
	id_funcionario int not null identity primary key ,
	nome_funcionario varchar(50) not null  ,
	login_funcionario varchar(30) not null unique ,
	senha_funcionario varchar(30) not null  ,
	email_funcionario varchar(30) not null unique ,
	obs_funcionario varchar(255) null  ,
	status_funcionario varchar(30) not null  
)

select * from funcionario

create table movimentacao
(
	id_movimentacao int not null identity primary key ,
	id_usuario_movimentacao int not null  ,
	id_produto_movimentacao int not null  ,
	id_funcionario_movimentacao int not null  ,
	data_movimentacao smalldatetime not null default getdate() ,
	obs_movimentacao varchar(255) null  ,
	status_movimentacao varchar(30) not null   
)
select * from movimentacao

drop table movimentacao

create table categoria
(
	id_categoria int not null identity primary key ,
	nome_categoria varchar(50) not null  ,
	descricao_categoria varchar(100) not null  ,
	obs_categoria varchar(255) null  ,
	status_categoria varchar(30) not null  
)
select * from categoria

create table produto
(
	id_produto int not null identity primary key ,
	id_estoque_produto int not null  ,
	id_categoria_produto int not null  ,
	nome_produto varchar(50) not null unique ,
	qtde_produto int not null  ,
	valorc_produto decimal(10,2) not null  ,
	valorv_produto decimal(10,2) not null  ,
	data_produto smalldatetime not null default getdate() ,
	obs_produto varchar(255) null  ,
	status_produto varchar(30) not null  
)
select * from produto
drop table produto

create table estoque
(
	id_estoque int not null identity primary key ,
	nome_estoque varchar(50) not null unique ,
	maximo_estoque int not null  ,
	obs_estoque varchar(255) null  ,
	status_estoque varchar(30) not null  
)

select * from estoque


alter table produto
add constraint FK_id_estoque_produto foreign key (id_estoque_produto)
references estoque (id_estoque)

alter table produto
add constraint FK_id_categoria_produto foreign key (id_categoria_produto)
references categoria (id_categoria)

select * from produto

alter table movimentacao
add constraint FK_id_usuario_movimentacao foreign key (id_usuario_movimentacao)
references usuario(id_usuario)

alter table movimentacao
add constraint FK_id_produto_movimentacao foreign key (id_produto_movimentacao)
references produto(id_produto)

alter table movimentacao
add constraint FK_id_funcionario_movimentacao foreign key (id_funcionario_movimentacao)
references funcionario (id_funcionario)