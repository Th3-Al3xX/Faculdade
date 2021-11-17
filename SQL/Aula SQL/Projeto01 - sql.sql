create table cidade(
id_cidade int,
nome_cidade varchar(50) not null,
UF varchar(2) not null,
constraint id_cidade_pk primary key (id_cidade),
);

create table funcionario(
id_funcionario int,
nome_funcionario varchar(50) not null,
endereco varchar(50) not null,
bairro varchar(30) not null,
id_cidade int not null,
salario float not null,
sexo varchar(2) not null,
data_nascimento smalldatetime not null,
constraint id_funcionario_pk primary key (id_funcionario),
constraint id_cidade_fk foreign key (id_cidade) references cidade(id_cidade),
);

create table dependente(
id_funcionario int,
nome_dependente varchar(50),
sexo varchar(2) not null,
data_nascimento smalldatetime not null,
parentesco varchar(8) not null,
constraint dependente_pk primary key (id_funcionario,nome_dependente),
constraint id_funcionario_fk foreign key (id_funcionario) references funcionario(id_funcionario),
);

create table departamento(
id_departamento int,
nome_departamento varchar(20) not null,
id_gerente int,
constraint id_departamento_pk primary key (id_departamento),
constraint id_gerente_fk foreign key (id_gerente) references funcionario(id_funcionario),
);

create table projeto(
id_projeto int,
nome_projeto varchar(30) not null,
id_supervisor int,
id_departamento int,
constraint id_projeto_pk primary key (id_projeto),
constraint id_supervisor_fk foreign key (id_supervisor) references funcionario(id_funcionario),
constraint id_departamento_fk foreign key (id_departamento) references departamento(id_departamento),
);

create table projeto_funcionario(
id_projeto int,
id_funcionario int,
horas_trabalhadas float not null,
constraint projeto_funcionario_pk primary key (id_projeto,id_funcionario),
constraint id_projeto_fk foreign key (id_projeto) references projeto(id_projeto),
constraint pf_id_funcionario_fk foreign key (id_funcionario) references funcionario(id_funcionario),
);

exec sp_help projeto_funcionario