#include <stdio.h>
#include <conio.h>
#define num 150

titulo(int a); /* Função relacionada ao titulos dos menus */
upper (char texto[]); /* Função converte uma string em maiuscula com suporte da funcao toupper()*/
toupper (char ch);  /* Função que torna letra em maiuscula */

/* Declaração de Variáveis eutilizando Struct*/
typedef struct Tfuncionario
{
       char nome[num][100], pesq[100]; /* Varíavel pesq será usada para pesquisa */
       float salario[num];
}TFuncionario;
      
typedef struct Tmenu
{
       char op, op2;
       int menu;
}TMenu;

TFuncionario fun;
TMenu opt;

main()
{
       int i=0,j;
       
       do {
           /* Menu Principal */
           titulo(0);
           
           puts("\n\t1 - Cadastro de Funcionarios");
           puts("\n\t2 - Alterar Informacoes de Funcionarios");
           puts("\n\t3 - Pesquisar Informacoes de Funcionarios");
           puts("\n\t4 - Listar Informacoes de Funcionarios");
           puts("\n\t5 - Excluir Cadastro de Funcionarios");
           puts("\n\t6 - Excluir todos os Cadastros de Funcionarios");
           puts("\n\t7 - Sair do Sistema\n");
           printf("\n\tSelecione uma opcao: ");
           scanf("%d",&opt.menu);
           fflush(stdin);
           system("cls");
           
           /* Executação de Rotinas conforme seleção no menu */
           
           switch (opt.menu)
           {
                  case 1: /* Modulo Cadastro */
                  {
                       do
                       {
                           titulo(opt.menu);
                           
                           if (i>=num) /* esta estrutura verifica limite de linhas na Matriz do Vetor */
                           {
                              printf("\n\tCadastro de Funcionarios Completo!\n\tNao e possivel adicionar mais funcionarios!");
                              getch(); 
                              system("cls"); break;
                           }
                           
                           printf("\n\tNome do Funcionario: ");
                           gets(fun.nome[i]);
                           fflush(stdin);
                           upper(fun.nome[i]);

                           printf("\n\tSalario: ");
                           scanf("%f",&fun.salario[i]);
                           fflush(stdin);

                           puts("\n\n\tStatus:");
                           printf("\t--------------------------------------------------------------");
                           puts("\n\tDados Gravados com Sucesso...");

                           i++;
                           
                           printf("\n\n\tCadastrar outro Funcionario? (S\\N): ");
                           scanf("%c",&opt.op);
                           fflush(stdin);
                           
                           system("cls");
                       }while(toupper(opt.op)=='S');
                       break;
                  }
                  case 2: /* Modulo Alterar */
                  {
                       do
                       { /* Cabeçalho */
                           titulo(opt.menu);
                           printf("\n\tEntre com o nome a pesquisar: ");
                           gets(fun.pesq);
                           
                           system("cls");
                           titulo(opt.menu);

                           puts("\n\tResultado da Busca:");
                           printf("\t--------------------------------------------------------------");

                           for (j=0;j<i;j++) /* Pesquisa, Comparação e Modificação de Dados */
                           {
						   	   if (strcmp(fun.pesq,fun.nome[j])==0)
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

                                  puts("\n\n\tStatus:");
                                  printf("\t--------------------------------------------------------------");
							      puts("\n\tDados Alterados com Sucesso...");
							      
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

						   printf("\n\n\tDeseja fazer outra alteracao? (S\\N): ");
						   scanf("%c",&opt.op);
						   fflush(stdin);
						   
						   system("cls");
                       }while(toupper(opt.op)=='S');
                       break;
                  }
                  case 3: /* Modulo Pesquisa */
                  {
                       do
                       { /* Cabeçalho */
                           titulo(opt.menu);
                           printf("\n\tEntre com o nome a pesquisar: ");
                           gets(fun.pesq);
                           fflush(stdin);
                           
                           upper(fun.pesq);
                           
                           system("cls");
                           titulo(opt.menu);
                           
                           puts("\n\tResultado da Busca:");
                           printf("\t--------------------------------------------------------------");

                           for (j=0;j<i;j++) /* Comparação e Pesquisa */
                           {
						   	   if (strcmp(fun.pesq,fun.nome[j])==0)
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
						   scanf("%c",&opt.op);
						   fflush(stdin);
						   
						   system("cls");
                       }while(toupper(opt.op)=='S');
                       break;
                  }
                  case 4: /* Modulo de Listagem Geral */
                  {
                       /* Cabeçalho */
                           titulo(opt.menu);
                           
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
                           titulo(opt.menu);
                           printf("\n\tEntre com o nome a excluir: ");
                           gets(fun.pesq);
                           
                           fflush(stdin);
                           
                           system("cls");
                           titulo(opt.menu);

                           puts("\n\tResultado da Busca:");
                           printf("\t--------------------------------------------------------------");
                           
                           for (j=0;j<i;j++) /* Comparação e Pesquisa */
                           {
						   	   if (strcmp(fun.pesq,fun.nome[j])==0)
                               {  printf("\n\tFuncionario: %s - Salario: %7.2f\n", fun.nome[j],fun.salario[j]);
							      
	                              printf("\n\n\tDeseja Excluir? (S\\N): ");
                                  scanf("%c",&opt.op2);
                                  fflush(stdin);
                           
                                  if (toupper(opt.op2)=='S')
           	                      {
       		   	  					 for (j=0;j<i;j++)
	       	   	  					 {
		       						  	 if(strcmp(fun.pesq,fun.nome[j])==0)
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
						   scanf("%c",&opt.op);
						   fflush(stdin);
						   
						   system("cls");
                       }while(toupper(opt.op)=='S');
                       
                       break;
                  }
                  case 6:
 				  {
                       /* Cabeçalho */
                       titulo(opt.menu);
                           
			       	   printf("\n\tDesja excluir toda a base de dados? (S\\N): ");
				       scanf("%c",&opt.op2);
						   
					   if (toupper(opt.op2)=='S')
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
       }while(opt.menu!=7); /* Enquanto não for digitado 7 no menu principal o sistema permanece operativo */
}

titulo(int a)
{
     char mens[14];
     
     switch (a)
     {
          case 0:
          {
               strcpy(mens,"MENU PRINCIPAL");
               break;
          }
          case 1:
          {
               strcpy(mens,"CADASTRO");
               break;
          }
          case 2:
          {
               strcpy(mens,"ALTERAR");
               break;
          }
          case 3:
          {
               strcpy(mens,"PESQUISAR");
               break;
          }
          case 4:
          {
               strcpy(mens,"LISTAR");
               break;
          }
          case 5:
          {
               strcpy(mens,"EXCLUIR");
               break;
          }
          case 6:
          {
               strcpy(mens,"EXCLUIR TUDO");
               break;
          }
     }
     
     printf("\n\tDepartamento Pessoal: %s", mens);
     printf("\n\t--------------------------------------------------------------\n");
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
