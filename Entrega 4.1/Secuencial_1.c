#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

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

    serv_adr.sin_port = htons(9050);
    if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
        printf("Error al bind");
    if (listen(sock_listen, 3) < 0)
        printf("Error en el Listen");

    int i;

    for (i = 0; i<5; i++){
        printf("Escuchando\n");

        sock_conn = accept(sock_listen, NULL, NULL);
        printf ("He recibido conexion \n");

        ret =read(sock_conn, petition, sizeof(petition));
        printf("Recibido\n");
        
        petition[ret] = '\0';

        printf("Peticion: %s\n", petition);

        char *p = strtok(petition, "/");
        int codigo = atoi (p);
        p = strtok(NULL, "/");
        char nombre [20];
        strcpy(nombre, p);
        printf("Codigo: %d, Nombre: %s\n", codigo, nombre);

        if (codigo == 1)
            sprintf(respuesta,"%d",strlen(nombre));
        else
            if ((nombre[0]=='M')||(nombre[0]=='S'))
                strcpy(respuesta,"SI");
            else
                strcpy(respuesta, "NO");
            
            printf("Respuesta: %s\n", respuesta);
            write(sock_conn, respuesta, strlen(respuesta));
            close(sock_conn);
    }
}
