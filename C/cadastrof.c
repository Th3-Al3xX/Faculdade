#include <stdio.h>
#include <conio.h>
#define num 150

int i, *id;
id=i;

typedef struct TData
{	int dia[2],ano[4];
	char mes[3]; }TData;

typedef struct Tfuncionario
{	char nome[num][100], rua[num][100], bairro[num][100];
	float salario[num];
	int numero[num];
	TData data_nasc[num]; }TFuncionario;

int MENUP ();

main()
{	int j;

MENUP(); }

int MENUP()
{   int op;
	do{
		puts("\n\tCADASTRO DE FUNCIONÁRIOS\n");
		puts("\t1 - Cadastrar");
		puts("\t2 - Alterar");
		puts("\t3 - Pesquisar");
		puts("\t4 - Listar Cadastros");
		puts("\t5 - Excluir");
		puts("\t6 - Excluir Tudo");
		puts("\t7 - Sair");
		printf("\n\tSlecione sua Opção: ");
		scanf("%d",&op);
		fflush(stdin);
		system("cls");
	}while (op!=7);
    
    return 0; }
	
