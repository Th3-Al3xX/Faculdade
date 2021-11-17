#include<stdio.h>
#include<conio.h>
main()
{
      char op;
      do 
      {
           printf( "\n \tMENU PRINCIPAL\n");
           printf(" \n\n\tM - Mostrar o Menu");
           printf("\n\n\tS - Sair\n");
           printf("\n\n\n\tOpcao: ");
           scanf("%c",&op);
           fflush(stdin); /* limpa o buffer do teclado garantindo 
                           * que nenhuma sujeira presente no buffer
                           *contaminara as variaveis*/
           system("cls"); /*limpa a tela*/
      }
         
         while(op!= 's' &&op != 'S');
}
         
         
           
                  
           
           
      
