#include <stdio.h> /*Prototipo com GLOBAL*/
#include <conio.h>

float soma(float A, float B);
float num;

main()
{
      float S,N;
      printf("\n\tEntre com dois valores: ");
      scanf("%f%f",&S,&N);
      num=soma(S,N);
      printf("\n\tA Soma E %f",num);
      getch();
}

float soma(float A, float B)
{
 return A+B;
}


