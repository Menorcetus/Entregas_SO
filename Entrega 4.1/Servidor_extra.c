#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>

int main(int argc, char *argv[])
{
    int sock_conn, sock_listen, ret;
    struct sockaddr_in serv_adr;
    char petition[512];
    char respuesta[512];
    // INICIALITAZIONS
    // Obrim el socket
    if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
        printf("Error creant socket");
    // Fem el bind al port
    

    memset (&serv_adr, 0, sizeof(serv_adr));
    serv_adr.sin_family = AF_INET;

    serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);

    serv_adr.sin_port = htons(9080);
    if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
        printf("Error al bind");
    if (listen(sock_listen, 3) < 0)
        printf("Error en el Listen");

    int i;

	for (;;){
		printf("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion \n");
		
		int  terminar = 0;
		while (terminar == 0){
			
			ret =read(sock_conn, petition, sizeof(petition));
			printf("Recibido\n");
			
			petition[ret] = '\0';
			
			printf("Peticion: %s\n", petition);
			
			char *p = strtok(petition, "/");
			int codigo = atoi (p);
			float transformado;	
			float temp;
			if(codigo != 0){
				p = strtok(NULL, "/");
				temp = atof(p);
			}

			if (codigo == 0)
				terminar = 1;
			// De Celsius a Fahrenheit
			else if (codigo == 1)
				{
					transformado = (temp * 1.8) + 32;
					sprintf(respuesta,"%f C son %f F.", temp, transformado);
				}
			// De Faherenheit a Celsius
			else if (codigo == 2)
				{
					transformado = (temp - 32) / 1.8;	
					sprintf(respuesta,"%f F son %f C.", temp, transformado);								
				}
	
			if (codigo != 0){
				printf("Respuesta: %s\n", respuesta);
				write(sock_conn, respuesta, strlen(respuesta));
			}
		}
		close(sock_conn);
    }
}
