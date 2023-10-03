//programa en C para consultar en que partida se encuentra el jugador buscado
#include <mysql.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
int main(int argc, char **argv)
{
    MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;

	int partida;
	char usuario[10];
	char consulta [80];
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "bd",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}

	// Ahora vamos a buscar la partida
	printf ("Dame el nombre de usuario que quieres buscar: \n"); 
	scanf ("%s", usuario);

	// construimos la consulta SQL
	strcpy (consulta,"SELECT ID_PARTIDA FROM USUARIOS WHERE NOMBRE = '"); 
	strcat (consulta, usuario);
	strcat (consulta,"'");


	// hacemos la consulta 
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
    
	//recogemos el resultado de la consulta 
	resultado = mysql_store_result (conn); 
		row = mysql_fetch_row (resultado);
		if (row == NULL)
			printf ("No se han obtenido datos en la consulta\n");
		else
			// El resultado debe ser una matriz con una sola fila
			// y una columna que contiene el nombre
			printf ("La partida en la que se encuentra es: %s\n", row[0] );
		// cerrar la conexion con el servidor MYSQL 
		mysql_close (conn);
		exit(0);
}
