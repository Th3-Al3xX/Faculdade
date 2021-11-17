#include <stdio.h>
#include <conio.h>

main()
{
      char ch ='A',x;
      char *ptr; /*ponteiro para char*/
      
      ptr = &ch; /*ptr recebe o endereço de ch*/
      x    = *ptr; /*x receb o dado associado*/
      
      printf("&ch  = %d\n", &ch);
      printf("&ptr = %d\n",&ptr);
      printf("ch   = %c\n" , ch);
      printf("ptr  = %d\n", ptr);
      printf("*ptr = %c\n",*ptr);
      printf("x    = %c\n", x);
      
     getch();
     
     }     
