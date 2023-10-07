#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(int arge, char *agv[]){

    char peticion[100];
    char resultado[100];

    strcpy (peticion, "Miguel/47/Juan/12/Maria/22/Marcos/19");


    char nombre[20];
    int edad;
    char *p = strtok(peticion, "/");

    while (p != NULL)
    {
        strcpy (nombre, p);
        p = strtok (NULL, "/");
        edad = atoi(p);
        if (edad > 18)
            sprintf(resultado, "%s%s*%d-", resultado, nombre, edad);
        
        p = strtok(NULL, "/");

    }
    resultado [strlen(resultado) - 1] = '\0';

    printf ("Resultado: %s", resultado);
}