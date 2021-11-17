#include <stdio.h>
#include <conio.h>
#define num 4

/* Cadastro */
main() {
       char nome[num][100];
       float salario[num];
       int i;
       
       for (i=0;i<num;i++)
       {
           puts("\tCADATRO DE FUNCIONARIOS\n");
           printf("\nNome: ");
           gets(nome[i]);
           printf("\nSalario: ");
           scanf("%f",&salario[i]);
           fflush(stdin);
           system("cls");
       }
       getch();
}
