#include <stdio.h>
#include <conio.h>

toupper (char ch);

main()
{
 	  char nome,var;
 	  
	  printf("\n\tDigite uma letra: ");
 	  scanf("%c",&nome);
 	  
 	  var=toupper(nome);
 	  
 	  printf("\n\t%c",var);
 	  getch();
}

toupper (char ch)
{
 		if (ch >= 'A' && ch <= 'Z')
 		{
		   	 ch = ch + 32;
		}
		
 		return ch;
}
