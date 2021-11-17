#include <stdio.h>
#include <conio.h>

main()
{
      int a=6, *nota;
      
      printf("a antes = %d\n",a);
      
      nota =&a; /* *nota ==6 */
      (*nota)++; /* *nota ==7 */
      
      printf("a depois = %d", a);
      
      getch();
}
