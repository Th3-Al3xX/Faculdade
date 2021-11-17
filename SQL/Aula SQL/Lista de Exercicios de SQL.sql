/* Lista de Exerc�cios (para estudo segunda prova) - (SQL/DDL/DML/DQL) BD � UNIP Professor: Waldecir Pereira Junior */
			   
--1) O que � a SQL e qual sua vantagem?
		A grande vantagem da SQL em rela��o as outras linguagens � a forma como uma consulta SQL especifica a produz seu resultado e n�o o caminho para chegar
	a ele.

--2) Cite e explique os grupos de instru��es da SQL.
	- Data Definition Language ou Linguagem de Defini��o de Dados (DDL): permite a defini��o de elementos de banco de dados.

	- Data Manipulation Language ou Linguagem de Manipula��o de Dados (DML): permite inserir, alterar e apagar dados.

	- Data Control Language ou Linguagem de Controle de Dados (DCL): permite modificar as permiss�es dos usu�rios sobre o
	  acesso aos dados.

	- Data Query Language ou Linguagem de Consulta de Dados (DQL): permite consultar os dados de um banco de dados.

--3) Descreva como criar e apagar tabelas atrav�s de instru��es DDL.
	create table <tabela>
	drop table <tabela>

--4) Cite e explique os principais tipos de dados presentes na maioria dos SGBDs.
	- INT - para n�meros inteiros, 
	- FLOAT ou REAL para n�meros reais
	- CHAR(n) de tamanho fixo 
	- VARCHAR(n) de tamanho vari�vel, onde, n � o n�mero m�ximo de caracteres a ser armazenado;
	- DATE para armazenar datas (dia,m�s e ano), 
	- TIME para armazenar hor�rios (horas, minutos e segundos), 
	- DATETIME para armazenar datas e hor�rios.

--5) Al�m do tipo, quais informa��es podem ser inseridas a respeito de campos na cria��o de tabelas?
	- NOT NULL -> o campo n�o pode conter valor nulo, ou seja, o valor do campo deve ser informado;
	- DEFAULT valor_padr�o -> valor padr�o para o campo. Sempre que for inserido um novo registro o valor _padr�o ser� inserido como valor inicial do campo

--6) Sobre as restri��es estudadas (PRIMARY KEY, FOREIGN KEY e UNIQUE), explique-as e mostre como cri�-las atrav�s de instru��es DDL.
	- PRIMARY KEY -> � a chave prim�ria. Ela � �nica e n�o aceita repeti��o.
	- FOREIGN KEY - � a chave estrangeira. Ela refere a uma Primary Key de outra tabela.
	- UNIQUE - � uma restri��o de uma campo especifico de uma tabela, como por exeplor o CPF , que � �nico e n�o pode ter repeti��o parecido com a Primary key.
	
--7) Cite e exemplifique as poss�veis a��es adicionais que podem ser criadas juntamente com chaves estrangeiras.
	ON DELETE (para exclus�es) e ON UPDATE (para altera��es).

	- As instru��es ON DELETE e ON UPDATE devem ser seguidas pela a��o a que deve ser executada. As poss�veis a��es s�o:
	- SET NULL - quando o dado referenciado for exclu�do ou apagado, o dado dependente assume valor nulo.
	- SET DEFAULT - quando o dado referenciado for exclu�do ou apagado, o dado dependente assume seu valor padr�o.
	- CASCADE - quando o dado referenciado for exclu�do ou apagado, o dado dependente a exclus�o ou altera��o ser� propagada para o dados dependentes.

--8) Escreva as instru��es SQL (DML) para a cria��o do seguinte esquema de banco de dados:
	CREATE TABLE CIDADE(
			    ID_CIDADE INT,
			    NOME_CIDADE VARCHAR(25), 
			    UF VARCHAR(2),
		 	    CONSTRAINT CIDADE_PK PRIMARY KEY (ID_CIDADE)
			   );

	CREATE TABLE DEPARTAMENTO(
				  ID_DEPARTAMENTO INT, 
				  NOME_DEPARTAMENTO VARCHAR(25) ,
				  CONSTRAINT DEPARTAMENTO_PK PRIMARY KEY (ID_DEPARTAMENTO)
				 );

	CREATE TABLE FUNCIONARIO(
				 ID_FUNCIONARIO INT, 
				 NOME_FUNCIONARIO VARCHAR(40),
				 ENDERECO VARCHAR(40), 
				 BAIRRO VARCHAR(40), 
				 ID_CIDADE INT,
				 SALARIO FLOAT, 
				 SEXO VARCHAR(1), 
				 DATA_NASCIMENTO DATETIME
				 CONSTRAINT FUNCIONARIO_PK PRIMARY KEY (ID_FUNCIONARIO),
  				 CONSTRAINT FUNCIONARIO_FK FOREIGN KEY (ID_CIDADE) REFERENCES CIDADE(ID_CIDADE)
				);

--9) Na tabela Cidade fa�a as seguintes altera��es:
--a) Crie um novo campo chamado qtde_habitantes do tipo inteiro.
	ALTER TABLE CIDADE ADD QTDE_HABITANTES INT

--b) Altere o nome do campo criado anteriormente para num_habitantes.
	SP_RENAME 'CIDADE.[QTDE_HABITANTES]', 'NUM_HABITANTES', 'COLUMN'

--c) Altere o campo nome_cidade para que ele n�o possa receber valor nulo.
	ALTER TABLE CIDADE ALTER COLUMN NOME_CIDADE VARCHAR(25) NOT NULL

--d) Altere o campo UF para que ele n�o possa receber valor nulo.
	ALTER TABLE CIDADE ALTER COLUMN UF VARCHAR(2) NOT NULL

--e) No mundo real o nome de uma cidade pode se repetir em diferentes estados, mas nunca em um mesmo estado. Sendo assim, crie uma restri��o na tabela Cidade que obrigue que os valores de nome_cidade e UF sejam �nicos para cada registro (restri��o UNIQUE).
	ALTER TABLE CIDADE ADD CONSTRAINT NOME_CIDADE_UN UNIQUE (NOME_CIDADE)
	ALTER TABLE CIDADE ADD CONSTRAINT UF_UN UNIQUE (UF)

--10)Na tabela Funcionario fa�a as seguintes altera��es:
--a) Crie um campo chamado id_departamento do tipo inteiro.
	ALTER TABLE FUNCIONARIO ADD ID_DEPARTAMENTO INT

--b) Observe que no esquema anterior n�o existe relacionamento entre as tabelas Funcionario e Departamento, ou seja, n�o � poss�vel dizer em qual departamento um funcion�rio trabalha. Sendo assim, crie na tabela Funcion�rio uma restri��o de chave estrangeira no campo id_departamento referenciando a tabela Departamento. D� o nome que achar conveniente para esta restri��o.
	ALTER TABLE FUNCIONARIO ADD CONSTRAINT ID_DEPTO_FK FOREIGN KEY (ID_DEPARTAMENTO) REFERENCES DEPARTAMENTO(ID_DEPARTAMENTO)

--c) Altere a restri��o de chave estrangeira criada anteriormente para que quando um departamento for exclu�do da tabela Departamento, todos os atributos de outras tabelas que referenciavam este departamento sejam atualizados com NULL.
	ALTER TABLE FUNCIONARIO DROP CONSTRAINT ID_DEPTO_FK
	ALTER TABLE FUNCIONARIO ADD CONSTRAINT ID_DEPTO_FK FOREIGN KEY (ID_DEPARTAMENTO) REFERENCES DEPARTAMENTO(ID_DEPARTAMENTO) ON DELETE SET NULL

--d) Altere o campo endereco para que quando o endere�o n�o for informado durante a inclus�o ou atualiza��o de um funcion�rio, este campo receba o valor default �N�O INFORMADO�.
	ALTER TABLE FUNCIONARIO ADD DEFAULT 'N�O INFORMADO' FOR ENDERECO
	
--11) Insira os seguintes dados nas tabelas Cidade, Departamento e Funcionario, respectivamente:

	INSERT INTO CIDADE (ID_CIDADE,NOME_CIDADE,UF,NUM_HABITANTES) VALUES(1,'S�O PAULO','SP',5000000);
	INSERT INTO CIDADE (ID_CIDADE,NOME_CIDADE,UF,NUM_HABITANTES) VALUES(2,'RIO DE JANEIRO','RJ',3000000);
	INSERT INTO CIDADE (ID_CIDADE,NOME_CIDADE,UF,NUM_HABITANTES) VALUES(3,'BELO HORIZONTE','MG',2000000);
	INSERT INTO CIDADE (ID_CIDADE,NOME_CIDADE,UF,NUM_HABITANTES) VALUES(4,'PORTO ALEGRE','RG',NULL);

	INSERT INTO DEPARTAMENTO(ID_DEPARTAMENTO,NOME_DEPARTAMENTO) VALUES (1,'FINANCEIRO');
	INSERT INTO DEPARTAMENTO(ID_DEPARTAMENTO,NOME_DEPARTAMENTO) VALUES(2,'RH');
	INSERT INTO DEPARTAMENTO(ID_DEPARTAMENTO,NOME_DEPARTAMENTO) VALUES(3,'ADM');
	INSERT INTO DEPARTAMENTO(ID_DEPARTAMENTO,NOME_DEPARTAMENTO) VALUES(4,'TI');
	INSERT INTO DEPARTAMENTO(ID_DEPARTAMENTO,NOME_DEPARTAMENTO) VALUES(5,'VENDAS');

	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO) VALUES(1,'MARCIO','RUA IVAI,130','CENTRO',1,2000,'M','10/10/1980',2);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(2,'PEDRO','RUA COLOMBIA,50','VILA AMERICA',2,5000,'M','10/12/1980',1);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(3,'MARIA','AV 23 DE MAIO,756','CENTRO',3,4000,'F','12/05/1970',5);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(4,'CARLA','N�O INFORMADO',NULL,NULL,1000,'F','12/09/1970',NULL);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(5,'TIAGO','AV 23 DE MAIO,1000','CAMPO BELO',3,4500,'M','10/05/1975',NULL);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(6,'ANA','AV TIRADENTES,5000','CENTRO',NULL,900,'F','08/05/1981',NULL);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(7,'CARLA','N�O INFORMADO',NULL,NULL,9000,'F',NULL,1);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(8,'TIAGO','N�O INFORMADO',NULL,NULL,500,'M',NULL,2);

--12) Na tabela Cidade atualize:
--a) O valor do campo num_habitantes da cidade PORTO ALEGRE, que � NULL, para 1000000.
	UPDATE CIDADE SET NUM_HABITANTES=1000000 WHERE ID_CIDADE = 4

--b) O valor do campo uf da cidade PORTO ALEGRE, que � RG, para RS.
	UPDATE CIDADE SET UF='RS' WHERE ID_CIDADE=4

--13) Na tabela Funcionario atualize:
--a) O nome do funcion�rio MARCIO para MARCIO DA SILVA.
	UPDATE FUNCIONARIO SET NOME_FUNCIONARIO='MARCIO DA SILVA' WHERE ID_FUNCIONARIO=1

--b) Considere que o funcion�rio TIAGO, com c�digo 5, mudou de cidade e que seu novo endere�o seja RUA VIEIRA DE MORAIS, 150 - CAMPO BELO � S�O PAULO. Sendo assim, atualize os campos endereco_completo, bairro e id_cidade do funcion�rio PEDRO.
	UPDATE FUNCIONARIO SET ENDERECO='RUA VIEIRA DE MORAIS, 150', BAIRRO='CAMPO BELO', ID_CIDADE=1 WHERE ID_FUNCIONARIO=5

--c) Considere que a funcion�ria MARIA foi transferida do departamento VENDAS para o departamento ADM. Sendo assim, atualize a tabela Funcionario para que ela reflita este fato.
	UPDATE FUNCIONARIO SET ID_DEPARTAMENTO 3 WHERE ID_FUNCIONARIO=3

--d) Considere que o funcion�rio TIAGO com id_funcionario = 8 foi demitido. Sendo assim, apague o este funcion�rio da tabela.
	DELETE FROM FUNCIONARIO WHERE ID_FUNCIONARIO=8

--e) Considere que todos os funcion�rios tiveram um aumento de 200 reais. Sendo assim, atualize os sal�rios de todos os funcion�rios somando 200 reais ao sal�rio atual.
	UPDATE FUNCIONARIO SET SALARIO=(SALARIO + 200)

--14) Na tabela Departamento:
--a) Apague o departamento FINANCEIRO.
	DELETE FROM DEPARTAMENTO WHERE NOME_DEPARTAMENTO='FINANCEIRO'

--b) Foi poss�vel eliminar o departamento FINANCEIRO? Por que?
	N�o, Porque na tabela FUNCIONARIO existe alguem do departamento financeiro, se n�o existisse a restri��o de FOREIGN KEY, a tabela FUNCIONARIO n�o teria integridade, pois iria ter um registro id_departamento que n�o existe.

--15) Na tabela Cidade:
--a) Apague a cidade S�O PAULO.
	DELETE FROM CIDADE WHERE NOME_CIDADE='S�O PAULO'
	
--b) Foi poss�vel eliminar a cidade S�O PAULO? Por que?
     N�o, Porque na tabela FUNCIONARIO existe alguem da cidade de S�o Paulo, se n�o existisse a restri��o de FOREIGN KEY, a tabela FUNCIONARIO n�o teria integridade, pois iria ter um registro id_cidade que n�o existe.
	
--16) Listar todo o conte�do das tabelas Cidade, Departamento e Funcionario.
	SELECT * FROM CIDADE
	SELECT * FROM DEPARTAMENTO
	SELECT * FROM FUNCIONARIO

--17) Obter somente as colunas nome_funcionario e sal�rio dos funcion�rios.
	SELECT NOME_FUNCIONARIO, SALARIO FROM FUNCIONARIO
	  
--18) Obter somente as colunas nome_funcionario e sal�rio dos funcion�rios, e renomear as colunas para NOME DO FUNCION�RIO e SAL�RIO DO FUNCIONARIO, respectivamente.
	SELECT NOME_FUNCIONARIO AS 'NOME DO FUNCION�RIO', SALARIO AS 'SAL�RIO DO FUNCIONARIO' FROM FUNCIONARIO

--19) Obter os funcion�rios cujo sal�rio seja maior que 2000.
	SELECT * FROM FUNCIONARIO WHERE SALARIO>2000

--20) Obter o sal�rio do funcion�rio PEDRO.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO='PEDRO'

--21) Obter todos os funcion�rios que possuam nomes com 5 letras.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE '_____'

--22) Obter os funcion�rios cujo nome inicie com MA.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE 'MA%'

--23) Obter os funcion�rios cujo nome termine com A.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE '%A'

--24) Obter os funcion�rios cujo nome tenha a letra D em qualquer posi��o.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE '%D%'

--25) Obter o nome e o sal�rio, acrescido em 20%, de cada funcion�rio.
	SELECT NOME_FUNCIONARIO, (SALARIO + SALARIO * 0.2) AS SALARIO FROM FUNCIONARIO

--26) Obter o sal�rio total dos funcion�rios (somar todos os sal�rios).
	SELECT SUM(SALARIO) AS SALARIO FROM FUNCIONARIO

--27) Obter os funcion�rios do sexo masculino E com sal�rio superior a 3000.
	SELECT * FROM FUNCIONARIO WHERE SEXO = 'M' AND SALARIO>3000

--28) Obter os funcion�rios do sexo masculino OU com sal�rio superior a 3000.
	SELECT * FROM FUNCIONARIO WHERE SEXO = 'M' OR SALARIO>3000

--29) Obter os funcion�rios com sal�rio entre 1000 e 2000.
	SELECT * FROM FUNCIONARIO WHERE SALARIO BETWEEN 1000 AND 2000

--30) Obter os funcion�rios com sal�rio de 1100, 1200, 2200, 4200 e 4300.
	SELECT * FROM FUNCIONARIO WHERE SALARIO IN (1100,1200,2200,4200,4300)

--31) Obter os funcion�rios cuja data de nascimento seja nula.
	SELECT * FROM FUNCIONARIO WHERE DATA_NASCIMENTO IS NULL

--32) Obter os funcion�rios cujo bairro n�o seja nulo.
	SELECT * FROM FUNCIONARIO WHERE BAIRRO IS NOT NULL

--33) Obter os funcion�rios que nasceram ap�s 1970 e que trabalham em algum departamento.
	SELECT * FROM FUNCIONARIO WHERE YEAR(DATA_NASCIMENTO)>1970 AND ID_DEPARTAMENTO IS NOT NULL

--34) Obter os funcion�rios ordenados em ordem crescente de sal�rio.
	SELECT * FROM FUNCIONARIO ORDER BY SALARIO

--35) Obter os funcion�rios ordenados em ordem decrescente de sal�rio.
	SELECT * FROM FUNCIONARIO ORDER BY SALARIO DESC

--36) Obter os nomes dos funcion�rios sem repeti��o.
	SELECT DISTINCT NOME_FUNCIONARIO FROM FUNCIONARIO

--37) Obter a m�dia salarial dos funcion�rios.
	SELECT AVG(SALARIO) AS MEDIA_SALARIO FROM FUNCIONARIO

--38) Obter o maior sal�rio dos funcion�rios.
	SELECT MAX(SALARIO) AS MAIOR_SALARIO FROM FUNCIONARIO

--39) Obter o menor sal�rio dos funcion�rios.
	SELECT MIN(SALARIO) AS MENOR_SALARIO FROM FUNCIONARIO

--40) Obter o n�mero total de funcion�rios.
	SELECT COUNT(*) AS TOTAL_FUNCIONARIOS FROM FUNCIONARIO

--41) Obter o sal�rio total dos funcion�rios do sexo masculino e feminino.
	SELECT SEXO, SUM(SALARIO) AS SALARIO FROM FUNCIONARIO GROUP BY SEXO

--42) Obter os nomes das cidades com seus respectivos estados.
	SELECT NOME_CIDADE, UF FROM CIDADE

--43) Obter os nomes dos funcion�rios e os nomes das cidades dos funcion�rios.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE 

--44) Obter os nomes dos funcion�rios e os nomes das cidades dos funcion�rios com id 1.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE A.ID_FUNCIONARIO=1

--45) Obter os funcion�rios que moram na cidade de S�O PAULO.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE A.ID_CIDADE=1

--46) Obter os funcion�rios que moram na cidade de S�O PAULO e que ganham mais de 3000.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE, A.SALARIO FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE A.ID_CIDADE=1 AND A.SALARIO>3000

--47) Obter os funcion�rios que trabalham no departamento RH.
	SELECT A.NOME_FUNCIONARIO, B.NOME_DEPARTAMENTO  FROM FUNCIONARIO A JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO=B.ID_DEPARTAMENTO WHERE NOME_DEPARTAMENTO='RH'

--48) Obter a quantidade de funcion�rio que moram em BELO HORIZONTE.
	SELECT COUNT(*) AS QTD_FUNCIONARIOS FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE B.NOME_CIDADE='BELO HORIZONTE'

--49) Obter o nome da cidade e a quantidade de funcion�rios que trabalham em cada cidade.
	SELECT B.NOME_CIDADE, COUNT(A.ID_FUNCIONARIO) AS QTD_FUNCIONARIO FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE = B.ID_CIDADE GROUP BY B.NOME_CIDADE
	
--50) Obter o nome da cidade e a quantidade de funcion�rios que trabalham em cada cidade com mais de um funcion�rio.
	SELECT B.NOME_CIDADE, COUNT(A.ID_FUNCIONARIO) AS QTD_FUNCIONARIO FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE = B.ID_CIDADE GROUP BY B.NOME_CIDADE HAVING COUNT(A.ID_FUNCIONARIO)>1

--51) Obter os nomes de todos os funcion�rios e os nomes de seus respectivos departamentos. N�o importando se trabalham ou n�o em algum departamento.
	SELECT A.NOME_FUNCIONARIO, B.NOME_DEPARTAMENTO FROM FUNCIONARIO A LEFT JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO = B.ID_DEPARTAMENTO

--52) Obter os nomes de todos os departamentos e os nomes de seus respectivos funcion�rios. N�o importando se os departamentos possuem ou n�o funcion�rios.
	SELECT B.NOME_DEPARTAMENTO, A.NOME_FUNCIONARIO FROM FUNCIONARIO A RIGHT JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO = B.ID_DEPARTAMENTO
	
--53) Obter os nomes de todos os funcion�rios e de todos os departamentos. N�o importando se os funcion�rios possuem ou n�o departamentos e se os departamentos possuem ou n�o funcion�rios.
	SELECT A.NOME_FUNCIONARIO, B.NOME_DEPARTAMENTO FROM FUNCIONARIO A FULL JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO = B.ID_DEPARTAMENTO