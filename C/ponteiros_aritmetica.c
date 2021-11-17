#include <stdio.h>
#include <conio.h>

main()
{
      float x[6]={5.5,4.0,7.6,8.1,5.0,6.5};
      float *nota;
      
      nota=&x[1];
      printf("%3.1f\n",*nota);
      
      printf("%3.1f\n",nota[2]);
      printf("%3.1f\n",*(nota+2));
      printf("%3.1f\n",*(nota-1));
      
      getch();
}
