#include<stdio.h>
#include<conio.h>
main()
{
      int i=1,j,num = 5;
      while(i<=num)
      {
                   j=1;
                   while (j<=10)
                   {
                   printf (" %d * %d = %d\n", i,j,i*j);
                   j++;
                   }
                   if (i!=5)
                   {
                            printf(" Pressione  <ENTER , ESC OU QUALQUER TECLA !!>  para continuar...\n");
                            getch();
                            system("cls");
                   }
                   i++;
      }
      getch();
}             
      
