#include <stdio.h>
#include <conio.h>

main()
{
      int a=6,*nota,*nota_final;
      
      printf("a antes = %d\n",a);
      
      nota=&a;
      nota_final=nota;
      (*nota)++;
      (*nota_final)++;
      
      printf("a depois = %d\n",a);
      
      getch();
}
