#include <stdio.h>
#include <conio.h>
#define num 150

int i=0, j;

toupper (char ch)
{      if (ch >= 'a' && ch <= 'z')
          ch = ch - 32;
		
       return ch;
}
       
upper (char texto[])
{ 	  int i;
 	  for (i=0;texto[i]!='\0';i++)
	   	  texto[i]=toupper(texto[i]);
}

typedef struct Tfuncionario
{      char nome[num][100];
       float salario[num];
}TFuncionario;
      
TFuncionario fun;

main()
{
      char op, pesq[100];int *id=&i; 
      
       do {
           /* Menu Principal */
           puts("\n\tCADASTRO DE FUNCIONARIOS\n");           
           puts("\t1 - Cadastro");
           puts("\t2 - Alterar");
           puts("\t3 - Pesquisar");
           puts("\t4 - Listar Todos");
           puts("\t5 - Excluir");
           puts("\t6 - Excluir Todos");
           puts("\t7 - Sair\n");
           printf("\n\tSelecione uma opcao: ");
           scanf("%d",&op);
           fflush(stdin);
           system("cls");
           
           /* Executação de Rotinas conforme seleção no menu */
           
           switch (op)
           {
                  case 1: /* Modulo Cadastro */
                  {
{
char op;
        

do{
    
    if (*id>=num){
        printf("\n\tCadastro de Funcionarios Completo!\n\tNao e possivel adicionar mais funcionarios!");
        getch();
        system("cls");
        break;}
        
    printf("\n\tNome do Funcionario: ");
    gets(fun.nome[*id]);
    fflush(stdin);
    upper(fun.nome[*id]);

    printf("\n\tSalario: ");
    scanf("%f",&fun.salario[*id]);
    fflush(stdin);

    printf("\t--------------------------------------------------------------");
    puts("\n\tDados Gravados com Sucesso...");

    *id++;
                           
    printf("\n\n\tCadastrar outro Funcionario? (S\\N): ");
    scanf("%c",&op);
    fflush(stdin);
                           
    system("cls");
}while(toupper(op)=='S');

                       break;
                  }
                  case 2: /* Modulo Alterar */
                  {
                  
                  do{
                          printf("\n\tEntre com o nome a pesquisar: ");
                          gets(pesq);
                           
                          system("cls");
                           
                          printf("\t--------------------------------------------------------------");
                                  for (j=0;j<i;j++)
                                      {
                                       	   if (strcmp(pesq,fun.nome[j])==0)
                                               {
                                  				      printf("\n\tFuncionario: %s - Salario: %7.2f\n", fun.nome[j],fun.salario[j]);
							      
                                   puts("\n\n\tInforme os dados abaixo para Alteracao:");
                      printf("\t--------------------------------------------------------------");
                           
					  printf("\n\tNome do Funcionario: ");
              	      gets(fun.nome[j]);
				      fflush(stdin);
				      upper(fun.nome[j]);

				      printf("\n\tSalario: ");
				      scanf("%f",&fun.salario[j]);
				      fflush(stdin);

                      printf("\t--------------------------------------------------------------");
                      puts("\n\tDados Alterados com Sucesso...");
							      
                       break;  }
             else
                 {
				   	   if (j==i-1)
	   	  		  	       puts("\n\tFuncionario nao encontrado ou nao cadastro...");
                   }

            printf("\n\n\tDeseja fazer outra alteracao? (S\\N): ");
			scanf("%c",op);
			fflush(stdin);
						   
   system("cls");
           }while(toupper(op)=='S');
           break;
                  }
                  case 3: /* Modulo Pesquisa */
                  {
                       do
                       { /* Cabeçalho */
                           
                           printf("\n\tEntre com o nome a pesquisar: ");
                           gets(pesq);
                           fflush(stdin);
                           
                           upper(pesq);
                           
                           system("cls");
                           
                           
                           puts("\n\tResultado da Busca:");
                           printf("\t--------------------------------------------------------------");

                           for (j=0;j<i;j++) /* Comparação e Pesquisa */
                           {
						   	   if (strcmp(pesq,fun.nome[j])==0)
                               {
                                  printf("\n\tFuncionario: %s - Salario: %7.2f\n", fun.nome[j],fun.salario[j]);
							      break;
                               }
                               else
                               {
							   	   if (j==i-1)
							   	   {
								   	  puts("\n\tFuncionario nao encontrado ou nao cadastro...");
                                   }
                               }
                           }

						   printf("\n\n\tNova Consulta? (S\\N): ");
						   scanf("%c",&op);
						   fflush(stdin);
						   
						   system("cls");
                       }while(toupper(op)=='S');
                       break;
                  }
                  case 4: /* Modulo de Listagem Geral */
                  {
                       /* Cabeçalho */
                           
                           
                           puts("\n\tListagem Completa de Funcionarios:");
                           printf("\t--------------------------------------------------------------");

                           for (j=0;j<i;j++) /* Ira varrer o vetor e trazer todos os dados encontrados */
                           {
                               printf("\n\tFuncionario: %s - Salario: %7.2f", fun.nome[j],fun.salario[j]);
                           }

					   	   if (j==i-1)
					   	   {
            			       puts("\n\tNao ha nenhum funcionario cadastrado no sistema...");
					       }

                           printf("\n\n\tPressione uma tecla pra retornar ao Menu Principal...");
						   getch();
						   
						   system("cls");
                       break;
                  }
                  case 5: /* Modulo de Exclusao */
                  {
				   	   do
				   	   {
				   	   /* Cabeçalho */
                           char pesq[100];
                           
                           printf("\n\tEntre com o nome a excluir: ");
                           gets(pesq);
                           
                           fflush(stdin);
                           
                           system("cls");
                           

                           puts("\n\tResultado da Busca:");
                           printf("\t--------------------------------------------------------------");
                           
                           for (j=0;j<i;j++) /* Comparação e Pesquisa */
                           {
						   	   if (strcmp(pesq,fun.nome[j])==0)
                               {  printf("\n\tFuncionario: %s - Salario: %7.2f\n", fun.nome[j],fun.salario[j]);
							      
							      char op2;
	                              
                                  printf("\n\n\tDeseja Excluir? (S\\N): ");
                                  scanf("%c",&op2);
                                  fflush(stdin);
                           
                                  if (toupper(op2)=='S')
           	                      {
       		   	  					 for (j=0;j<i;j++)
	       	   	  					 {
		       						  	 if(strcmp(pesq,fun.nome[j])==0)
			       					  	 {
			  	       						for(;j<i;j++)
			  		       					{
						       	 			   strcpy(fun.nome[j],fun.nome[j+1]);
							        		   fun.salario[j]=fun.salario[j+1];
							        		   
							 		       	   if(j==i-1)
							 			          {
                                         		       puts("\n\n\tStatus:");
                                         			   printf("\t--------------------------------------------------------------");
													   puts("\n\tFuncionario Excluido com Sucesso...");
				       			      			       strcpy(fun.nome[j+1],"");
					       		      			       fun.salario[j+1]=0;
						       	      			       i--;
							       		          }
								       	    }
                                         }
                                         else
                 		                 {
					       		   	   	  	 if (j==i-1)
   		 				       	 			 {
							       	   	  	  	puts("\n\tFuncionario nao encontrado ou nao cadastro...");
							       	   	  	  	getch();
                                             }
                 			 			 }
                                     }
                                   }							      
                               }
                               else
                               {
							   	   if (j==i-1)
							   	   {
								   	  puts("\n\tFuncionario nao encontrado ou nao cadastro...");
                                   }
                               }
                           }
                           
						   printf("\n\n\tNova Consulta? (S\\N): ");
						   scanf("%c",&op);
						   fflush(stdin);
						   
						   system("cls");
                       }while(toupper(op)=='S');
                       
                       break;
                  }
                  case 6:
 				  {
                       /* Cabeçalho */
                       char op2;
                           
			       	   printf("\n\tDesja excluir toda a base de dados? (S\\N): ");
				       scanf("%c",&op2);
						   
					   if (toupper(op2)=='S')
					   {
					      for (j=0;j<i;j++) /* Ira varrer o vetor e trazer todos os dados encontrados */
                          {
						   	  strcpy(fun.nome[j],fun.nome[j+1]);
						      fun.salario[j]=fun.salario[j+1];
                          }
                          
                           puts("\n\n\tStatus:");
                           printf("\t--------------------------------------------------------------");
					       puts("\n\tTodos os Cadastros foram excluidos...\n");
                           printf("\n\n\tPressione uma tecla pra retornar ao Menu Principal...");
						   getch();
   						   i=0;
					   }
					   else
					   {
                           puts("\n\n\tStatus:");
                           printf("\t--------------------------------------------------------------");
					       puts("\n\tNenhuma informacao foi excluida...\n");
                           printf("\n\n\tPressione uma tecla pra retornar ao Menu Principal...");
						   getch();
					   }				   	   
      				   system("cls");
					   break;
					   	   
                  }
                  case 7: break;
				  default:
      			  {
				   		  printf("\n\n\tOpcao Invalida! Tente novamente...");
				   		  getch();
				   		  system("cls");
				  }
           }
       }while(op!=7); /* Enquanto não for digitado 7 no menu principal o sistema permanece operativo */
}


 	  	  


