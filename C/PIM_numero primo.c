#include <stdio.h>
#include <conio.h>
main()
{
//Um número natural é um número primo quando ele tem exatamente dois 
// divisores: o número um e ele mesmo.

   int num, i, qtde;

  do
  {
    printf ("\n\tDigite um numero real: ");
    scanf ("%d", &num);
    fflush(stdin);

    qtde = 0;

    for (i=1;i<=num;i++)
    {
        if (num%i==0)
           qtde = qtde + 1;
    }

    if (qtde > 2)
       printf ("\n\tEste numero nao e primo\n");
    else
       printf ("\n\tEste numero e primo\n");
   
    getch ();
    system("cls");
  
  }while (num!=0);
}
