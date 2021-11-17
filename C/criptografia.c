/* crypt:
 * crypt input output key
 *
 * Autor: André Ramaciotti da Silva
 * Versão: 0.3
 *
 * Esse programa abre o arquivo determinado pelo primeiro argumento (input) e
 * criptografa-o usando um algoritmo que usa o operador lógico ^ (XOR) e a
 * chave (key) que foi dada como terceiro argumento.
 *
 * O resultado é gravado no arquivo dado pelo segundo argumento (output). No
 * atual estado, deve-se tomar cuidado, pois se já houver um arquivos com o
 * nome do segundo argumento, este será sobrescrito.
 *
 * NOTAS DA VERSÃO:
 * Modificado para ser complacente com a última versão do C. Faltam ainda
 * modificações no que diz respeito a sobrescrever um arquivo (-f).
 *
 * ESTE CÓDIGO ESTÁ EM DOMÍNIO PÚBLICO
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <termios.h> /* struct termios */

#define PASSMAX 32 /* tamanho máximo da senha */

/* Criptografa o *text* do primeiro argumento usando a *key* do segundo e
 * retorna uma string com o resultado */
char *encrypt( const char *text, const char *key, int size );

/* Retorna uma string com todo o conteudo do arquivo *fileptr* */
char *get_from_file( FILE *fileptr );

/* Abre o arquivo *filename* com as opções *options*. Se bem sucedido, retorna
 * um ponteiro para o arquivo, se não, aborta a execução do programa. */
FILE *xfopen( const char *filename, const char *options );

/* Retorna o tamanho do arquivo *fileptr* em número de caracteres */
int filesize( FILE *fileptr );

/* Salva *num* caracteres da string *str* no arquivo *fileptr*. Útil se houver
 * algum caractere nulo em meio à string */
void to_file( const char *str, FILE *fileptr, int num );

/* Aloca memória usando calloc e verifica se foi bem sucedido. Se for, retorna
 * o(s) ponteiros, se não for, aborta a execução do programa */
void *xcalloc( size_t number, size_t size );

/* AQUI COMEÇA O PROGRAMA */
int main( int argc, char* argv[] )
{
	char *encrypted = NULL; /* string encriptada */
        char key[ PASSMAX+1 ]; /* senha */
	char *string = NULL; /* string original */

	FILE *input = NULL; /* arquivo de entrada */
	FILE *output = NULL; /* arquivo de saída */

	int size; /* tamanho do arquivo em número de caracteres */

	struct termios def_termios, new_termios; /* estrutura com informações sobre o terminal */

	if( argc != 3 ) /* verifica se foi chamado com os argumentos corretos */
	{
		fprintf( stderr, "Usage:\ncrypt inputfile outputfile\n");
		exit(EXIT_FAILURE);
	}

	input = xfopen( argv[1], "r" ); /* abre arquivo de entrada ("r"ead) */

	/* Aqui usaremos fopen pois é permitido que o arquivo não exista */
	output = fopen( argv[2], "r" ); /* usamos "r", pois "w" iria sobrescrevê-lo */
	if( output ) /* se o arquivo já existir, não vamos sobrescrevê-lo */
	{
		fprintf( stderr, "File exists: %s.\n", argv[2]);
		exit(EXIT_FAILURE);
	}

	output = xfopen( argv[2], "w" ); /* se não existia, agora o criamos ("w"rite) */

	tcgetattr( fileno( stdin ), &def_termios ); /* descobrimos os atributos do terminal */
	new_termios = def_termios; /* copiamos os atributos para uma nova estrutura */
	new_termios.c_lflag &= ~ECHO; /* novo terminal não irá imprimir na tela */

	printf("Password: ");

        /* tentamos atribuir as novas opções ao terminal */
	if( tcsetattr( fileno( stdin ), TCSAFLUSH, &new_termios ) != 0 ) /* se não conseguir: */
	{
		fprintf( stderr, "Unable to set password (termios fault).\n" );
		exit(EXIT_FAILURE);
	}

	else /* se conseguir: */
	{
		fgets( key, PASSMAX, stdin); /* pega a senha */
		tcsetattr( fileno( stdin ), TCSANOW, &def_termios ); /* volta a como era antes */
	}

	printf("\n");

	size = filesize( input ); /* descobrimos o tamanho do arquivo (quantidade de caracteres) */

	string = (char *) xcalloc( size, sizeof( char ) ); /* alocamos a memória para guardá-lo */
	encrypted = (char *) xcalloc( size, sizeof( char ) ); /* e para encriptá-lo. */

	string = get_from_file( input ); /* salvamos todo o conteúdo numa string */

	encrypted = encrypt( string, key, size ); /* encriptamos o conteúdo */
	to_file( encrypted, output, size ); /* e salvamos o que criptografado */

	fclose( input );
	fclose( output );

	exit( EXIT_SUCCESS );
}

void *xcalloc( size_t number, size_t size ) /* versão "segura" de calloc */
{
	void *ptr = NULL;

	ptr = calloc( number, size ); /* chama calloc */

	if( ptr == NULL ) /* e verifica se foi bem sucedido */
		exit( EXIT_FAILURE );

	return ptr;
}

FILE *xfopen( const char *filename, const char *options ) /* versão "segura" de fopen */
{
	FILE *file = fopen( filename, options ); /* chama fopen */
	if( file == NULL ) /* e verifica se foi bem sucedido */
		exit( EXIT_FAILURE );

	return file;
}

char *encrypt( const char *text, const char *key, int size ) /* criptografa */
{
	char *str = NULL; /* string criptografada */
	int scount, kcount; /* contagem da string e da senha para o loop */

	str = (char *) xcalloc( size, sizeof( char ) );

	for( scount = 0, kcount = 0; scount < size;
			scount++, kcount++) /* enquanto não chegar ao tamanho da string ... */
	{

		str[scount] = (text[scount] ^ key[kcount]); /* (des)criptografa usando XOR */

		if( kcount == (strlen( key ) -1) ) /* reseta contagem da senha quando necessário */
		{
			kcount = -1;
		}

	}

	str[ size ] = ''; /* termina string com 'null' */
	return str;

	free( str );
}

int filesize( FILE *fileptr ) /* acha tamanho do arquivo em número de caracteres */
{
	char c;
	int count = 0;

	while( c != EOF )
	{
		c = fgetc( fileptr );
		count++;
	}

	rewind( fileptr );
	return count;
}

char *get_from_file( FILE *fileptr ) /* adquire string de um arquivo */
{
	int size, i;
	char *str;

	size = filesize( fileptr );
	str = (char *) xcalloc( size, sizeof( char ) );

	for( i = 0; i < size; i++ )
	{
		str[i] = fgetc( fileptr );
	}

	str[size-1] = '';

	return str;

	free( str );
}

void to_file( const char *str, FILE *fileptr, int num ) /* salva string em um arquivo */
{
	int i;

	for( i = 0; i < (num-1); i++ )
	{
		fputc( str[i], fileptr );
	}
}
