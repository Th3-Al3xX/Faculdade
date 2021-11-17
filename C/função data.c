#include <stdio.h>
#include <conio.h>

typedef struct data
{
        int dia, ano;
        char mes[3];
}data;

mostrar(data x);
int i;

main()
{

   data feriado[3];

   for (i=0;i<3;i++)
   {
      printf("\n\tIndice: %d\n",i);

      printf("\n\tEntre com o dia: ");
      scanf("%d",&feriado[i].dia);
      fflush(stdin);
      
      printf("\n\tEntre com o Mes: ");
      gets(feriado[i].mes);
      fflush(stdin);
      
      printf("\n\tEntre com o Ano: ");
      scanf("%d",&feriado[i].ano);
      fflush(stdin);

      mostrar(feriado[i]);      
   }
}

mostrar(data x)
{
      printf("\n\tA data Digitada e %d/%s/%d.", x.dia, x.mes, x.ano);
      getch();
      system("cls");
}
