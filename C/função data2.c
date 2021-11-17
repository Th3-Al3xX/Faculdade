#include <stdio.h>
#include <conio.h>

typedef struct data
{
    int dia, ano;
    char mes[3];
}data;

typedef struct pessoa
{
    char nome[50];
    float salario;
    data data_nasc;
}pessoa;

main()
{
    pessoa fun={"Joao",199.46,{31,2015,"FEV"}};
    
    printf("O salario de %s e de %6.2f e nasceu em %d/%s/%d.", fun.nome,fun.salario,fun.data_nasc.dia,fun.data_nasc.mes,fun.data_nasc.ano);
    getch();
}
      
        
