#include <stdio.h>
#include <conio.h>

typedef struct data
{
 		int dia,ano;
 		char mes[3];
}data;

typedef struct pessoa
{
 	 char nome[50];
 	 float salario;
 	 data data_nasc;
}pessoa;

mostrar(pessoa x);

int i;

main()
{
 	  pessoa func[3];
 	  
 	  for (i=0;i<3;i++)
 	  {
	   	  printf("\nEntre com o nome: ");
	   	  gets(func[i].nome);
	   	  fflush(stdin);
	   	  
	   	  printf("\nEntre com o Salario: ");
	   	  scanf("%f",&func[i].salario);
	   	  fflush(stdin);
	   	  
	   	  printf("\nEntre com o dia de nascimento: ");
	   	  scanf("%d",&func[i].data_nasc.dia);
	   	  fflush(stdin);
	   	  
	   	  printf("\nEntre com o mes de nascimento: ");
	   	  gets(func[i].data_nasc.mes);
	   	  fflush(stdin);
	   	  
	   	  printf("\nEntre com o ano de nascimento: ");
	   	  scanf("%d",&func[i].data_nasc.ano);
	   	  fflush(stdin);
	   	  
	   	  mostrar(func[i]);
      }
}

mostrar (pessoa x)
{
 		printf("\a\n\nO Salario de %s e de %8.2f, nasceu em %d/%s/%d.", x.nome, x.salario, x.data_nasc.dia, x.data_nasc.mes, x.data_nasc.ano);
 		getch();
 		
 		system("cls");
}
