#include <stdio.h>
#include <conio.h>

typedef struct data
{
        int dia, ano;
        char mes[3];
}data;

mostrar(data x);

main()
{
      data feriado;
      
      printf("\tEntre com o dia: ");
      scanf("%d",&feriado.dia);
      fflush(stdin);
      
      printf("\n\tEntre com o Mes: ");
      gets(feriado.mes);
      fflush(stdin);
      
      printf("\n\tEntre com o Ano: ");
      scanf("%d",&feriado.ano);
      fflush(stdin);

      mostrar(feriado);
}

mostrar(data x)
{
      system("cls");
      printf("\n\tA data Digitada e %d/%s/%d.", x.dia, x.mes, x.ano);
      getch();
}
