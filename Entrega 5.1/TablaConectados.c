#include <stdio.h>
#include <stdlib.h>
#include <string.h>


typedef struct {
    char nombre [20];
    int socket;
} Conectado;

typedef struct {
    Conectado conectados [100];
    int num;
} ListaConectados;

int Pon (ListaConectados *lista, char nombre[20], int socket) {
    if (lista->num == 100)
        return -1;
    else {
        strcpy(lista->conectados[lista->num].nombre, nombre);
        lista->conectados[lista->num].socket = socket;
        lista->num++;
        return 0;
    }
}

int DamePosicion (ListaConectados *lista, char nombre[20]){
    int i = 0;
    int encontrado = 0;
    while ((i < lista->num) && !encontrado)
    {
        if (strcmp(lista->conectados[i].nombre, nombre)==0)
            encontrado = 1;
        if(!encontrado)
            i++;
    }
    if (encontrado)
        return i;
    else
        return -1;
    
}

int Eliminar (ListaConectados *lista, char nombre[20]){
    int pos = DamePosicion(lista, nombre);
    if (pos == -1)
        return -1;
    else {
        for (int i = pos; i<lista->num-1; i++)
        {
            lista->conectados[i] = lista->conectados[i+1];
        }
        lista ->num--;
        return 0;
    }
}

void DameConectados (ListaConectados *lista, char conectados[300]){
    sprintf(conectados,"%d", lista->num);
    for (int i = 0; i < lista->num; i++)
        sprintf(conectados,"%s/%s", conectados, lista->conectados[i].nombre);
}

int main(int argc, char *argv[]){
    ListaConectados miLista;
    miLista.num = 0;

    int res = Pon (&miLista, "Pedro", 5);
    res = Pon (&miLista, "Maria", 30);
    res = Pon (&miLista, "Carlos", 7);
    res = Pon (&miLista, "Juan", 20);
    res = Pon (&miLista, "Paco", 25);

    int pos = DamePosicion(&miLista, "Pedro");
    if (pos != -1)
        printf("El socket de Pedro es: %d\n", miLista.conectados[pos].socket);
    else
        printf("Ese usuario no esta conectado.\n");
    
    res = Eliminar(&miLista,"Juan");
    if (res == -1)
        printf("Juan no estaba.\n");
    else
        printf("Eliminado.\n");

    pos = DamePosicion (&miLista, "Juan");
    if (pos != -1)
        printf ("El socket de Juan es: %d\n", miLista.conectados[pos].socket);
    else
        printf("Juan no esta en la lista.\n");

    char misConectados[300];
    DameConectados(&miLista, misConectados);
    printf("Resultado: %s\n",misConectados);

    char *p = strtok(misConectados,"/");
    int n = atoi(p);
    for(int i = 0; i <n; i++){
        char nombre[20];
        p = strtok (NULL, "/");
        strcpy(nombre, p);
        printf("Conectado: %s\n", nombre);
    }

    return 0;
}