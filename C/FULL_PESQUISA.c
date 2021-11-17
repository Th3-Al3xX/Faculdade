#include <stdio.h>
#include <string.h>
#include <conio.h>
#define num 2

/* Pesquisa */
main() {
       char nome[num][100]={"Pedro","Maria"};
       float salario[num]={1000.00,2500.50};
       int i;
       char nome_p[100];
       
       printf("\nInforme o nome que deseja pesquisar: ");
       gets(nome_p);
       
       
       for (i=0;i<num;i++)
       {
           if(strcmp(nome_p,nome[i])==0)
           {
                printf("\nNome: %s",nome[i]);
                printf("\nSalario: %f", salario[i]);
                break;
           }
           if (i==num-1)
              puts("Funcionario nao cadastrado!");
              
       }
       getch();
}
