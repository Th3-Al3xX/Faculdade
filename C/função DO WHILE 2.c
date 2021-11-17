#include<stdio.h>
#include<conio.h>
main()
{
      char op;
      do 
      {
           printf("\tMENU PRINCIPAL\n");
           printf("\n\n\tC - Clientes");
           printf("\n\n\tF - Fornecedores\n");
           printf("\n\n\tS - Sair\n");
           printf("\n\n\n\t Opcao: ");
           scanf("%c",&op);
           fflush(stdin); /* limpa o buffer do teclado garantindo 
                           * que nenhuma sujeira presente no buffer
                           *contaminara as variaveis*/
           system("cls"); /*limpa a tela*/
           switch (op) 
          {
           case 'c': 
           case 'C': printf("Opcao CLIENTES."); break;
           case 'f':
           case 'F': printf("Opcao FORNECEDORES."); break;
           case 's':/*não faz nada*/
           case 'S': break;
           default: printf("Opcao Invalida!");
          }
      getch(); /* para a tela */
      system("cls"); /*limpa a tela*/
      }
      while (op != 's' && op != 'S');
}
