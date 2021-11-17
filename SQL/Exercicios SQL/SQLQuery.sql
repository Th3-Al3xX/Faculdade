Create Table aluno(
cod_aluno INT,
nome_aluno varchar(30) not null,
cpf char(11),
data_nascimento datetime,
media float not null,
constraint cod_aluno_pk primary key (cod_aluno),
constraint aluno_cpf_un unique (cpf)
);

create table professor(
cod_professor int,
nome_professor varchar(30) not null,
area varchar(20),
constraint cod_professor_pk primary key (cod_professor)
);

create table disciplina(
cod_disciplina int,
nome_disciplina varchar(30) not null,
carga_horaria int not null,
cod_professor int not null,
constraint disciplina_pk primary key (cod_disciplina),
constraint disciplina_professor_fk foreign key (cod_professor) references professor(cod_professor)
);

create table matriculado(
cod_aluno int not null,
cod_disciplina int not null,
nota float,
constraint matriculado_pk primary key (cod_aluno,cod_disciplina),
constraint matriculado_aluno_fk foreign key (cod_aluno) references aluno(cod_aluno),
constraint matriculo_disciplina_fk foreign key (cod_disciplina) references disciplina(cod_disciplina)
);

insert into aluno(cod_aluno,nome_aluno,cpf,data_nascimento,media) values(1,'José','12345678910','10/10/1979',5.0);
insert into aluno(cod_aluno,nome_aluno,cpf,media) values(2,'Maria','12345678545',6.0);
insert into aluno(cod_aluno,nome_aluno,cpf,data_nascimento,media) values(3,'João','22637826439','05/11/1992',7.5);
insert into aluno(cod_aluno,nome_aluno,cpf,data_nascimento,media) values(4,'José','34568547896',null,8.5);
insert into aluno(cod_aluno,nome_aluno,cpf,data_nascimento,media) values(6,'Pedro','45912378901','05/05/1979',8.0);

insert into professor(cod_professor,nome_professor,area) values(10,'Roberto','Computação');
insert into professor(cod_professor,nome_professor,area) values(20,'Carlos','Administração');
insert into professor(cod_professor,nome_professor,area) values(30,'Arnaldo','Matemática');

insert into disciplina(cod_disciplina,nome_disciplina,carga_horaria,cod_professor) values(100,'Algorítmos',80,10);
insert into disciplina(cod_disciplina,nome_disciplina,carga_horaria,cod_professor) values(200,'Banco de Dados',80,10);
insert into disciplina(cod_disciplina,nome_disciplina,carga_horaria,cod_professor) values(300,'Cálculo',60,20);
insert into disciplina(cod_disciplina,nome_disciplina,carga_horaria) values(400,'Álgebra',60);
insert into disciplina(cod_disciplina,nome_disciplina,carga_horaria,cod_professor) values(500,'Empreendedorismo',40,null);

insert into matriculado(cod_aluno,cod_disciplina,nota) values(1,100,89.5);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(1,200,71);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(1,300,90);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(1,400,82.5);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(2,100,88.7);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(2,200,78);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(2,400,77.5);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(2,500,92);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(3,100,72.5);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(3,200,81);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(3,300,59);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(3,400,83.3);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(4,100,71);
insert into matriculado(cod_aluno,cod_disciplina,nota) values(4,200,52.8);

select * from aluno;
select * from aluno where media>='6.0';
select * from professor;
select * from disciplina;

select * from aluno where data_nascimento='10/10/1978';
select nome_aluno as 'Nome do Aluno' from aluno;
select * from aluno where data_nascimento='10/10/1979' and media=5;
select * from aluno where data_nascimento>='01/01/1970' and data_nascimento<='12/31/1980';
select * from aluno where data_nascimento between '01/01/1970' and '12/31/1980';
select * from aluno where media in(5,6,8.5,9);
select * from aluno where nome_aluno LIKE 'J%';
select * from aluno where nome_aluno not Like 'j%';
select * from aluno where nome_aluno Like '_____';
select * from aluno where nome_aluno = 'Maria';
select * from aluno where nome_aluno < 'Maria';
select * from aluno where data_nascimento is null;
select * from aluno where data_nascimento is not null;
select * from aluno order by nome_aluno, media desc;

delete from aluno where cod_aluno=4;
delete from aluno where nome_aluno='ana';
delete from aluno;

update aluno set cpf='1222233344455', data_nascimento='1980/10/20' where cod_aluno=2;
update aluno set cpf='123' where cod_aluno=1;
update aluno set cpf=1, media=10 where cod_aluno=2;
update aluno set media=3;

exec sp_help disciplina;