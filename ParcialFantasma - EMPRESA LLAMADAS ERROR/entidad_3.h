#ifndef ENTIDAD_3_H_INCLUDED
#define ENTIDAD_3_H_INCLUDED

typedef struct
{
    int idAbonado;
    char numero[30];
    char nombre[30];
    char apellido[30];      ///vhardcodear ACTIVO, SUSPENDIDO, DEMORADO, CANCELADO ES EL ESTADO
    int isEmptyAbonados;

}eAbonado;

#endif // ENTIDAD_3_H_INCLUDED
//#include "entidad_1.h"
///eAbonado
int harcodearAbonados(eAbonado vec[], int tam, int cant);

void inicializarAbonados(eAbonado vec[], int tam);

int buscarLibreAbonado(eAbonado vec[],int tam);  ///xq para dar el alta necesito saber una pos libre

void mostrarAbonado(eAbonado abonado);
///EN EL CASO DEL MOSTRAR UNO, DE LO QUE TIENE ALTA, INFLUYEN MAS DE UN ARRAY

void mostrarAbonados(eAbonado vec[], int tam);

int altaAbonado(eAbonado vecA[], int tamA, int idabonado);
///EL ALTA LLEVA LOS ARRAYS DE CADA ESTRUC QUE ESTA INVOLUCRADA IGUAL QUE EL MOSTRAR TODOS
eAbonado newAbonado(int idAbonado,char numero [],char nombre[], char apellido []);
///LELVA LOS PARAMETROS QUE TIENE LA ESTRUCTURA.

void bajaAbonado(eAbonado vecA[], int tamA);

int buscarAbonadoPorId(int idAbonado, eAbonado vec[], int tam);

int modificarAbonado(eAbonado vec[], int tam);


