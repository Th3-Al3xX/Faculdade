/* Lista de Exercícios (para estudo segunda prova) - (SQL/DDL/DML/DQL) BD – UNIP Professor: Waldecir Pereira Junior */
			   
--1) O que é a SQL e qual sua vantagem?
		A grande vantagem da SQL em relação as outras linguagens é a forma como uma consulta SQL especifica a produz seu resultado e não o caminho para chegar
	a ele.

--2) Cite e explique os grupos de instruções da SQL.
	- Data Definition Language ou Linguagem de Definição de Dados (DDL): permite a definição de elementos de banco de dados.

	- Data Manipulation Language ou Linguagem de Manipulação de Dados (DML): permite inserir, alterar e apagar dados.

	- Data Control Language ou Linguagem de Controle de Dados (DCL): permite modificar as permissões dos usuários sobre o
	  acesso aos dados.

	- Data Query Language ou Linguagem de Consulta de Dados (DQL): permite consultar os dados de um banco de dados.

--3) Descreva como criar e apagar tabelas através de instruções DDL.
	create table <tabela>
	drop table <tabela>

--4) Cite e explique os principais tipos de dados presentes na maioria dos SGBDs.
	- INT - para números inteiros, 
	- FLOAT ou REAL para números reais
	- CHAR(n) de tamanho fixo 
	- VARCHAR(n) de tamanho variável, onde, n é o número máximo de caracteres a ser armazenado;
	- DATE para armazenar datas (dia,mês e ano), 
	- TIME para armazenar horários (horas, minutos e segundos), 
	- DATETIME para armazenar datas e horários.

--5) Além do tipo, quais informações podem ser inseridas a respeito de campos na criação de tabelas?
	- NOT NULL -> o campo não pode conter valor nulo, ou seja, o valor do campo deve ser informado;
	- DEFAULT valor_padrão -> valor padrão para o campo. Sempre que for inserido um novo registro o valor _padrão será inserido como valor inicial do campo

--6) Sobre as restrições estudadas (PRIMARY KEY, FOREIGN KEY e UNIQUE), explique-as e mostre como criá-las através de instruções DDL.
	- PRIMARY KEY -> é a chave primária. Ela é única e não aceita repetição.
	- FOREIGN KEY - é a chave estrangeira. Ela refere a uma Primary Key de outra tabela.
	- UNIQUE - é uma restrição de uma campo especifico de uma tabela, como por exeplor o CPF , que é único e não pode ter repetição parecido com a Primary key.
	
--7) Cite e exemplifique as possíveis ações adicionais que podem ser criadas juntamente com chaves estrangeiras.
	ON DELETE (para exclusões) e ON UPDATE (para alterações).

	- As instruções ON DELETE e ON UPDATE devem ser seguidas pela ação a que deve ser executada. As possíveis ações são:
	- SET NULL - quando o dado referenciado for excluído ou apagado, o dado dependente assume valor nulo.
	- SET DEFAULT - quando o dado referenciado for excluído ou apagado, o dado dependente assume seu valor padrão.
	- CASCADE - quando o dado referenciado for excluído ou apagado, o dado dependente a exclusão ou alteração será propagada para o dados dependentes.

--8) Escreva as instruções SQL (DML) para a criação do seguinte esquema de banco de dados:
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

--9) Na tabela Cidade faça as seguintes alterações:
--a) Crie um novo campo chamado qtde_habitantes do tipo inteiro.
	ALTER TABLE CIDADE ADD QTDE_HABITANTES INT

--b) Altere o nome do campo criado anteriormente para num_habitantes.
	SP_RENAME 'CIDADE.[QTDE_HABITANTES]', 'NUM_HABITANTES', 'COLUMN'

--c) Altere o campo nome_cidade para que ele não possa receber valor nulo.
	ALTER TABLE CIDADE ALTER COLUMN NOME_CIDADE VARCHAR(25) NOT NULL

--d) Altere o campo UF para que ele não possa receber valor nulo.
	ALTER TABLE CIDADE ALTER COLUMN UF VARCHAR(2) NOT NULL

--e) No mundo real o nome de uma cidade pode se repetir em diferentes estados, mas nunca em um mesmo estado. Sendo assim, crie uma restrição na tabela Cidade que obrigue que os valores de nome_cidade e UF sejam únicos para cada registro (restrição UNIQUE).
	ALTER TABLE CIDADE ADD CONSTRAINT NOME_CIDADE_UN UNIQUE (NOME_CIDADE)
	ALTER TABLE CIDADE ADD CONSTRAINT UF_UN UNIQUE (UF)

--10)Na tabela Funcionario faça as seguintes alterações:
--a) Crie um campo chamado id_departamento do tipo inteiro.
	ALTER TABLE FUNCIONARIO ADD ID_DEPARTAMENTO INT

--b) Observe que no esquema anterior não existe relacionamento entre as tabelas Funcionario e Departamento, ou seja, não é possível dizer em qual departamento um funcionário trabalha. Sendo assim, crie na tabela Funcionário uma restrição de chave estrangeira no campo id_departamento referenciando a tabela Departamento. Dê o nome que achar conveniente para esta restrição.
	ALTER TABLE FUNCIONARIO ADD CONSTRAINT ID_DEPTO_FK FOREIGN KEY (ID_DEPARTAMENTO) REFERENCES DEPARTAMENTO(ID_DEPARTAMENTO)

--c) Altere a restrição de chave estrangeira criada anteriormente para que quando um departamento for excluído da tabela Departamento, todos os atributos de outras tabelas que referenciavam este departamento sejam atualizados com NULL.
	ALTER TABLE FUNCIONARIO DROP CONSTRAINT ID_DEPTO_FK
	ALTER TABLE FUNCIONARIO ADD CONSTRAINT ID_DEPTO_FK FOREIGN KEY (ID_DEPARTAMENTO) REFERENCES DEPARTAMENTO(ID_DEPARTAMENTO) ON DELETE SET NULL

--d) Altere o campo endereco para que quando o endereço não for informado durante a inclusão ou atualização de um funcionário, este campo receba o valor default ‘NÃO INFORMADO’.
	ALTER TABLE FUNCIONARIO ADD DEFAULT 'NÃO INFORMADO' FOR ENDERECO
	
--11) Insira os seguintes dados nas tabelas Cidade, Departamento e Funcionario, respectivamente:

	INSERT INTO CIDADE (ID_CIDADE,NOME_CIDADE,UF,NUM_HABITANTES) VALUES(1,'SÃO PAULO','SP',5000000);
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
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(4,'CARLA','NÃO INFORMADO',NULL,NULL,1000,'F','12/09/1970',NULL);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(5,'TIAGO','AV 23 DE MAIO,1000','CAMPO BELO',3,4500,'M','10/05/1975',NULL);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(6,'ANA','AV TIRADENTES,5000','CENTRO',NULL,900,'F','08/05/1981',NULL);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(7,'CARLA','NÃO INFORMADO',NULL,NULL,9000,'F',NULL,1);
	INSERT INTO FUNCIONARIO(ID_FUNCIONARIO,NOME_FUNCIONARIO,ENDERECO,BAIRRO,ID_CIDADE,SALARIO,SEXO,DATA_NASCIMENTO,ID_DEPARTAMENTO)	VALUES(8,'TIAGO','NÃO INFORMADO',NULL,NULL,500,'M',NULL,2);

--12) Na tabela Cidade atualize:
--a) O valor do campo num_habitantes da cidade PORTO ALEGRE, que é NULL, para 1000000.
	UPDATE CIDADE SET NUM_HABITANTES=1000000 WHERE ID_CIDADE = 4

--b) O valor do campo uf da cidade PORTO ALEGRE, que é RG, para RS.
	UPDATE CIDADE SET UF='RS' WHERE ID_CIDADE=4

--13) Na tabela Funcionario atualize:
--a) O nome do funcionário MARCIO para MARCIO DA SILVA.
	UPDATE FUNCIONARIO SET NOME_FUNCIONARIO='MARCIO DA SILVA' WHERE ID_FUNCIONARIO=1

--b) Considere que o funcionário TIAGO, com código 5, mudou de cidade e que seu novo endereço seja RUA VIEIRA DE MORAIS, 150 - CAMPO BELO – SÃO PAULO. Sendo assim, atualize os campos endereco_completo, bairro e id_cidade do funcionário PEDRO.
	UPDATE FUNCIONARIO SET ENDERECO='RUA VIEIRA DE MORAIS, 150', BAIRRO='CAMPO BELO', ID_CIDADE=1 WHERE ID_FUNCIONARIO=5

--c) Considere que a funcionária MARIA foi transferida do departamento VENDAS para o departamento ADM. Sendo assim, atualize a tabela Funcionario para que ela reflita este fato.
	UPDATE FUNCIONARIO SET ID_DEPARTAMENTO 3 WHERE ID_FUNCIONARIO=3

--d) Considere que o funcionário TIAGO com id_funcionario = 8 foi demitido. Sendo assim, apague o este funcionário da tabela.
	DELETE FROM FUNCIONARIO WHERE ID_FUNCIONARIO=8

--e) Considere que todos os funcionários tiveram um aumento de 200 reais. Sendo assim, atualize os salários de todos os funcionários somando 200 reais ao salário atual.
	UPDATE FUNCIONARIO SET SALARIO=(SALARIO + 200)

--14) Na tabela Departamento:
--a) Apague o departamento FINANCEIRO.
	DELETE FROM DEPARTAMENTO WHERE NOME_DEPARTAMENTO='FINANCEIRO'

--b) Foi possível eliminar o departamento FINANCEIRO? Por que?
	Não, Porque na tabela FUNCIONARIO existe alguem do departamento financeiro, se não existisse a restrição de FOREIGN KEY, a tabela FUNCIONARIO não teria integridade, pois iria ter um registro id_departamento que não existe.

--15) Na tabela Cidade:
--a) Apague a cidade SÃO PAULO.
	DELETE FROM CIDADE WHERE NOME_CIDADE='SÃO PAULO'
	
--b) Foi possível eliminar a cidade SÃO PAULO? Por que?
     Não, Porque na tabela FUNCIONARIO existe alguem da cidade de São Paulo, se não existisse a restrição de FOREIGN KEY, a tabela FUNCIONARIO não teria integridade, pois iria ter um registro id_cidade que não existe.
	
--16) Listar todo o conteúdo das tabelas Cidade, Departamento e Funcionario.
	SELECT * FROM CIDADE
	SELECT * FROM DEPARTAMENTO
	SELECT * FROM FUNCIONARIO

--17) Obter somente as colunas nome_funcionario e salário dos funcionários.
	SELECT NOME_FUNCIONARIO, SALARIO FROM FUNCIONARIO
	  
--18) Obter somente as colunas nome_funcionario e salário dos funcionários, e renomear as colunas para NOME DO FUNCIONÁRIO e SALÁRIO DO FUNCIONARIO, respectivamente.
	SELECT NOME_FUNCIONARIO AS 'NOME DO FUNCIONÁRIO', SALARIO AS 'SALÁRIO DO FUNCIONARIO' FROM FUNCIONARIO

--19) Obter os funcionários cujo salário seja maior que 2000.
	SELECT * FROM FUNCIONARIO WHERE SALARIO>2000

--20) Obter o salário do funcionário PEDRO.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO='PEDRO'

--21) Obter todos os funcionários que possuam nomes com 5 letras.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE '_____'

--22) Obter os funcionários cujo nome inicie com MA.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE 'MA%'

--23) Obter os funcionários cujo nome termine com A.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE '%A'

--24) Obter os funcionários cujo nome tenha a letra D em qualquer posição.
	SELECT * FROM FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE '%D%'

--25) Obter o nome e o salário, acrescido em 20%, de cada funcionário.
	SELECT NOME_FUNCIONARIO, (SALARIO + SALARIO * 0.2) AS SALARIO FROM FUNCIONARIO

--26) Obter o salário total dos funcionários (somar todos os salários).
	SELECT SUM(SALARIO) AS SALARIO FROM FUNCIONARIO

--27) Obter os funcionários do sexo masculino E com salário superior a 3000.
	SELECT * FROM FUNCIONARIO WHERE SEXO = 'M' AND SALARIO>3000

--28) Obter os funcionários do sexo masculino OU com salário superior a 3000.
	SELECT * FROM FUNCIONARIO WHERE SEXO = 'M' OR SALARIO>3000

--29) Obter os funcionários com salário entre 1000 e 2000.
	SELECT * FROM FUNCIONARIO WHERE SALARIO BETWEEN 1000 AND 2000

--30) Obter os funcionários com salário de 1100, 1200, 2200, 4200 e 4300.
	SELECT * FROM FUNCIONARIO WHERE SALARIO IN (1100,1200,2200,4200,4300)

--31) Obter os funcionários cuja data de nascimento seja nula.
	SELECT * FROM FUNCIONARIO WHERE DATA_NASCIMENTO IS NULL

--32) Obter os funcionários cujo bairro não seja nulo.
	SELECT * FROM FUNCIONARIO WHERE BAIRRO IS NOT NULL

--33) Obter os funcionários que nasceram após 1970 e que trabalham em algum departamento.
	SELECT * FROM FUNCIONARIO WHERE YEAR(DATA_NASCIMENTO)>1970 AND ID_DEPARTAMENTO IS NOT NULL

--34) Obter os funcionários ordenados em ordem crescente de salário.
	SELECT * FROM FUNCIONARIO ORDER BY SALARIO

--35) Obter os funcionários ordenados em ordem decrescente de salário.
	SELECT * FROM FUNCIONARIO ORDER BY SALARIO DESC

--36) Obter os nomes dos funcionários sem repetição.
	SELECT DISTINCT NOME_FUNCIONARIO FROM FUNCIONARIO

--37) Obter a média salarial dos funcionários.
	SELECT AVG(SALARIO) AS MEDIA_SALARIO FROM FUNCIONARIO

--38) Obter o maior salário dos funcionários.
	SELECT MAX(SALARIO) AS MAIOR_SALARIO FROM FUNCIONARIO

--39) Obter o menor salário dos funcionários.
	SELECT MIN(SALARIO) AS MENOR_SALARIO FROM FUNCIONARIO

--40) Obter o número total de funcionários.
	SELECT COUNT(*) AS TOTAL_FUNCIONARIOS FROM FUNCIONARIO

--41) Obter o salário total dos funcionários do sexo masculino e feminino.
	SELECT SEXO, SUM(SALARIO) AS SALARIO FROM FUNCIONARIO GROUP BY SEXO

--42) Obter os nomes das cidades com seus respectivos estados.
	SELECT NOME_CIDADE, UF FROM CIDADE

--43) Obter os nomes dos funcionários e os nomes das cidades dos funcionários.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE 

--44) Obter os nomes dos funcionários e os nomes das cidades dos funcionários com id 1.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE A.ID_FUNCIONARIO=1

--45) Obter os funcionários que moram na cidade de SÃO PAULO.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE A.ID_CIDADE=1

--46) Obter os funcionários que moram na cidade de SÃO PAULO e que ganham mais de 3000.
	SELECT A.NOME_FUNCIONARIO, B.NOME_CIDADE, A.SALARIO FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE A.ID_CIDADE=1 AND A.SALARIO>3000

--47) Obter os funcionários que trabalham no departamento RH.
	SELECT A.NOME_FUNCIONARIO, B.NOME_DEPARTAMENTO  FROM FUNCIONARIO A JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO=B.ID_DEPARTAMENTO WHERE NOME_DEPARTAMENTO='RH'

--48) Obter a quantidade de funcionário que moram em BELO HORIZONTE.
	SELECT COUNT(*) AS QTD_FUNCIONARIOS FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE=B.ID_CIDADE WHERE B.NOME_CIDADE='BELO HORIZONTE'

--49) Obter o nome da cidade e a quantidade de funcionários que trabalham em cada cidade.
	SELECT B.NOME_CIDADE, COUNT(A.ID_FUNCIONARIO) AS QTD_FUNCIONARIO FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE = B.ID_CIDADE GROUP BY B.NOME_CIDADE
	
--50) Obter o nome da cidade e a quantidade de funcionários que trabalham em cada cidade com mais de um funcionário.
	SELECT B.NOME_CIDADE, COUNT(A.ID_FUNCIONARIO) AS QTD_FUNCIONARIO FROM FUNCIONARIO A JOIN CIDADE B ON A.ID_CIDADE = B.ID_CIDADE GROUP BY B.NOME_CIDADE HAVING COUNT(A.ID_FUNCIONARIO)>1

--51) Obter os nomes de todos os funcionários e os nomes de seus respectivos departamentos. Não importando se trabalham ou não em algum departamento.
	SELECT A.NOME_FUNCIONARIO, B.NOME_DEPARTAMENTO FROM FUNCIONARIO A LEFT JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO = B.ID_DEPARTAMENTO

--52) Obter os nomes de todos os departamentos e os nomes de seus respectivos funcionários. Não importando se os departamentos possuem ou não funcionários.
	SELECT B.NOME_DEPARTAMENTO, A.NOME_FUNCIONARIO FROM FUNCIONARIO A RIGHT JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO = B.ID_DEPARTAMENTO
	
--53) Obter os nomes de todos os funcionários e de todos os departamentos. Não importando se os funcionários possuem ou não departamentos e se os departamentos possuem ou não funcionários.
	SELECT A.NOME_FUNCIONARIO, B.NOME_DEPARTAMENTO FROM FUNCIONARIO A FULL JOIN DEPARTAMENTO B ON A.ID_DEPARTAMENTO = B.ID_DEPARTAMENTO