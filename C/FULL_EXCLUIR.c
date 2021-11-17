#include <stdio.h>
#include <string.h>
#include <conio.h>
#define num 2

/* Exclusão */
main() {
       char nome[num][100]={"Pedro","Maria"};
       float salario[num]={1000.00,2500.50};
       int i;
       char nome_e[100];
       
       printf("\nInforme o nome que deseja excluir: ");
       gets(nome_e);
       
       for(i=0;i<num;i++)
       {
          if(strcmp(nome_e,nome[i])==0)
          {
             for(;i<num;i++)
             {
               strcpy(nome[i],nome[i+1]);
               salario[i]=salario[i+1];
               if(i==num-1)
               {
                  puts("\nFuncionario Excluido!");
                  strcpy(nome[i+1],"");
                  salario[i+1]=0;
               }
             }
          }
          else
          {
              if(i==num-1)
                 puts("\nFuncionario nao Encontrado!");
          }
       }
          getch();
}
