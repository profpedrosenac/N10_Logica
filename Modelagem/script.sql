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
	qtde_movimentacao int not null,
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


insert into usuario 
(nome_usuario,login_usuario,senha_usuario,email_usuario,obs_usuario,status_usuario)
values
('Asdrubal','asdrubal','123','email','','ATIVO')

select * from usuario

insert into usuario 
(nome_usuario,login_usuario,senha_usuario,email_usuario,obs_usuario,status_usuario)
values
('Administrador','admin','123','admin@admin.com.br','','ATIVO')

delete from usuario where id_usuario = 3

update usuario set 
	nome_usuario = 'Administrador do Sistema',
	obs_usuario = 'Nome alterado!'
where id_usuario = 4

select * from usuario


insert into usuario
(nome_usuario,login_usuario,senha_usuario,email_usuario,obs_usuario,status_usuario)
values
('Benegundes','benegundes','123','benegundes@bla.com.br','','ATIVO'),
('Matuzalem','matuzalem','123','matuzalem@bla.com.br','','ATIVO'),
('Asdrubal','asdrubal','123','asdrubal@bla.com.br','','ATIVO'),
('Judith','judith','123','judith@bla.com.br','','ATIVO'),
('Genoveva','genoveva','123','genoveva@bla.com.br','','ATIVO')

insert into funcionario
(nome_funcionario,login_funcionario,senha_funcionario,email_funcionario,obs_funcionario,status_funcionario)
values
('Benegundes','benegundes','123','benegundes@bla.com.br','','ATIVO'),
('Matuzalem','matuzalem','123','matuzalem@bla.com.br','','ATIVO'),
('Asdrubal','asdrubal','123','asdrubal@bla.com.br','','ATIVO'),
('Judith','judith','123','judith@bla.com.br','','ATIVO'),
('Genoveva','genoveva','123','genoveva@bla.com.br','','ATIVO')

select * from funcionario

insert into categoria
(nome_categoria,descricao_categoria,obs_categoria,status_categoria)
values
('Parafuso','','','ATIVO'),
('Nylon','','','ATIVO'),
('Zoio','','','ATIVO'),
('Inox','','','ATIVO'),
('Calha','','','ATIVO')

select * from Categoria

insert into estoque
(nome_estoque,maximo_estoque,obs_estoque,status_estoque)
values
('Caixinha 897',533,'','ATIVO'),
('Box 398',715,'','ATIVO'),
('Box 483',791,'','ATIVO'),
('Box 162',541,'','ATIVO'),
('Caixinha 1672',952,'','ATIVO')

select * from estoque


insert into produto
(id_estoque_produto,id_categoria_produto,nome_produto,qtde_produto,valorc_produto,valorv_produto,obs_produto,status_produto)
values
(4,3,'Ferragens Forte',3467,7.94,2.03,'','ATIVO'),
(5,4,'MetalMaster',407,2.02,7.73,'','ATIVO'),
(2,3,'FerroFácil',3717,3.08,3.32,'','ATIVO'),
(2,5,'IronWorks',3152,6.31,9.29,'','ATIVO'),
(1,4,'Ferragens Premium',2903,9.38,6.79,'','ATIVO'),
(4,2,'MetalPro',3496,1.58,5.71,'','ATIVO'),
(1,3,'FerroFix',1412,6.3,9.52,'','ATIVO'),
(1,5,'IronCraft',4961,3.67,7.52,'','ATIVO'),
(1,1,'Ferragens Duráveis',4200,10.54,9.67,'','ATIVO'),
(2,1,'MetalMax',1352,6.95,1.86,'','ATIVO')


select * from produto

select * from usuario

select * from funcionario

insert into movimentacao
(id_usuario_movimentacao,id_produto_movimentacao,id_funcionario_movimentacao,qtde_movimentacao,obs_movimentacao,status_movimentacao)
values
(6,1,1,101,'','ATIVO'),
(6,1,4,95,'','ATIVO'),
(6,5,1,98,'','ATIVO'),
(9,3,2,187,'','ATIVO'),
(4,4,3,12,'','ATIVO'),
(4,8,2,160,'','ATIVO'),
(4,6,1,232,'','ATIVO'),
(4,4,2,142,'','ATIVO'),
(6,4,3,199,'','ATIVO'),
(8,1,2,62,'','ATIVO')


select * from movimentacao