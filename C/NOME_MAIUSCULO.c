#include <stdio.h>
#include <conio.h>

toupper (char ch);
upper (char texto[]);

main()
{
 	  char nome[100];
 	  
	  printf("\n\tDigite uma letra: ");
 	  gets(nome);
 	  
 	  upper(nome);
 	  
 	  printf("\n\t%s",nome);
 	  getch();
}

upper (char texto[])
{
 	  int i;
 	   	  
 	  for (i=0;texto[i]!='\0';i++)
 	  {
	   	  texto[i]=toupper(texto[i]);
	  }
}
 	  	  
toupper (char ch)
{
 		if (ch >= 'a' && ch <= 'z')
 		{
		   	 ch = ch - 32;
		}
		
 		return ch;
}
