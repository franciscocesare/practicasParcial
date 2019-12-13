#ifndef ENTIDAD_2_H_INCLUDED
#define ENTIDAD_2_H_INCLUDED

typedef struct
{
    int idllamada;
    char motivo[30];
    char estado[30];
    int isEmptyllamadas;

}eLlamada;

#endif // ENTIDAD_2_H_INCLUDED
#include "entidad_3.h"

int harcodearllamadas(eLlamada vec[], int tam, int cant);

void mostrarllamada (eLlamada llam, eAbonado vec[], int tam);

void mostrarllamadas (eLlamada vec [], int tam, eAbonado vecA[], int tamA);

void obtenerNombreAbonado (eAbonado vec[], int tam, int id, char dondeAsignar[]);

int altallamada(eLlamada vec[], int tam, int idllamada, eAbonado vecA[], int tamA);
eLlamada newllamada(int idAbonado,char motivo []);

void inicializarllamadas(eLlamada vec[], int tam);

int findFree(eLlamada vec[], int tam);

int modificarllamada(eLlamada vec[], int tam, eAbonado abo[], int tamA);

int buscarAllamadaPorId(int idllmado, eLlamada vec[], int tam);
