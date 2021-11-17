#include <stdio.h>
#include <conio.h>

main()
{
      struct Tfuncionario
      {
             char nome[50];
             float salario;
      };
      
      struct Tfuncionario fun;
      
      printf("\n\tDigite um nome: ");
      gets(fun.nome);
      
      printf("\n\tDigite o salario: ");
      scanf("%f",&fun.salario);
      
      printf("\a\n\n\tNome: %s - Salario: %f\a", fun.nome, fun.salario);
      getch();
}
             
