#include <stdio.h>
#include <conio.h>

main()
{
      char texto[50], *nome, ch;
      
      printf("Digite um nome: ");
      gets(texto);
      fflush(stdin);
      
      printf("\nDigite um caracter qualquer: ");
      scanf("%c",&ch);
      fflush(stdin);
      
      for (nome=texto;*nome!='\0';nome++)
      {
          if (strcmp(ch,*nome)==0)
          {
             printf("\n\n1ª Ocorrencia encontrada na memoria: %d", nome);
             break;
          }
          else
          {
           printf("\n\n\aNenhuma ocorrencia encontrada!!!");
             break;
          }
      }
      getch();
}
