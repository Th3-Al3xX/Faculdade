#include <stdio.h>
#include <conio.h>

main()
{
      int a,b,*num;
      
      num=&a;

      printf("Entre com um numero: ");
      scanf("%d",&*num);
      
      printf("\nEntre com um numero: ");
      scanf("%d",&b);
      
      (*num)=(*num)*b;
      
      printf("\nTotal: %d\n",a);
      
      getch();
}
