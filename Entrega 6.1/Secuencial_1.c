#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>
#include <pthread.h>

int contador;

pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente(void *socket)
{
	char petition[512];
    char respuesta[512];
	int ret;

	int sock_conn;
	int *s;
	s= (int*) socket;
	sock_conn= *s;

	int  terminar = 0;
	while (terminar == 0){

		ret =read(sock_conn, petition, sizeof(petition));
		printf("Recibido\n");

		petition[ret] = '\0';

		printf("Peticion: %s\n", petition);

		char *p = strtok(petition, "/");
		int codigo = atoi (p);
		p = strtok(NULL, "/");
		char nombre [20];

		if((codigo != 0) && (codigo != 6)){
			strcpy(nombre, p);
			printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		if (codigo == 0)
			terminar = 1;
		// Longitud de nombre
		else if (codigo == 1)
			sprintf(respuesta,"%d",strlen(nombre));
		// Nombre Bonico
		else if (codigo == 2)
			if ((nombre[0]=='M')||(nombre[0]=='S'))
				strcpy(respuesta,"SI");
			else
				strcpy(respuesta, "NO");
		// Alto?			
		else if(codigo == 3)
		{
			p = strtok(NULL, "/");
			float altura = atof (p);
			if (altura > 1.70)
				sprintf(respuesta, "%s: eres alto", nombre);
			else
				sprintf(respuesta, "%s: eres bajo", nombre);
		}			
		// Nombre palnidromo
		else if (codigo == 4)
		{
			int n = 0;
			int f = strlen(nombre)-1;
			int Negativo = 0;
			while (n != strlen(nombre))
			{
			    if(nombre[n] == nombre[f])
			    {
			        printf("%c %c \n",nombre[n], nombre[f]);
			        n++;
			        f--;
			    }
			    else if (nombre[n] != nombre[f])
			    {
			        printf("%c %c \n",nombre[n], nombre[f]);
			        Negativo = 1;
			        n = strlen(nombre);
			    }
			}
			if(Negativo == 0)
			    sprintf(respuesta,"%s SI es palindromo", nombre);   
			else if (Negativo == 1)
			    sprintf(respuesta,"%s NO es palindromo", nombre); 
		}
		// NOMBRE
		else if (codigo == 5)
		{
			for (int i = 0; nombre[i] != '\0'; ++i)
			{
				nombre[i] = toupper(nombre[i]);
			}
			sprintf(respuesta,"%s ahora esta en mayusculas", nombre);
		}

		else if (codigo == 6)
			sprintf(respuesta,"%d",contador);

		if (codigo != 0){
			printf("Respuesta: %s\n", respuesta);
			write(sock_conn, respuesta, strlen(respuesta));
		}
		if ((codigo != 0) && (codigo != 6))
			pthread_mutex_lock(&mutex);
			contador++;
			pthread_mutex_unlock(&mutex);
	}
	close(sock_conn);
}

int main(int argc, char *argv[])
{
    int sock_conn, sock_listen, ret;
    struct sockaddr_in serv_adr;

    // INICIALITAZIONS
    // Obrim el socket
    if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
        printf("Error creant socket");
    // Fem el bind al port
    

    memset (&serv_adr, 0, sizeof(serv_adr));
    serv_adr.sin_family = AF_INET;

    serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);

    serv_adr.sin_port = htons(9050);
    if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
        printf("Error al bind");
    if (listen(sock_listen, 3) < 0)
        printf("Error en el Listen");

	contador = 0;
    int i = 0;
	int sockets[100];
	pthread_t thread;

	for (;;){
		printf("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion \n");
		
		sockets[i] = sock_conn;

		pthread_create (&thread, NULL, AtenderCliente, &sockets[i]);
		i++;
    }
}
