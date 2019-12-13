#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "inputDiaz.h"
///#include "entidad_1.h"
#include "entidad_2.h"
#include "entidad_3.h"

/*
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "inputDiaz.h"
#include "categoria.h"
#include "juego.h"
#include "clientes.h"
#include "alquileres.h"
*/


int harcodearAbonados(eAbonado vecA[], int tamA, int cant)///tiene que tener de estado CHAR
{
    int cont=0;
    eAbonado Abonados[]=
    {
        {1000,"1135535446","JUAN", "PEREZ",0},
        {1001,"1154478985","ROMINA", "GOMEZ",0},
        {1002,"1147522563","CARLOS","PORTA",0},
        {1003,"1156647891","MARIANA","LALA",0},
        {1004,"1134774145","ALBERTO","KAKA",0},
        {1005,"1136988744","FRANCISCO","CESARE",0},
        {1006,"1125584747","JUANA","MUNE",0},
        {1007,"1125587413","MARIA","GUTO",1},
        {1008,"1162355414","JIMENA","WEWE",1},

    };

    if(cant<= tamA && cant<=9)
    {
        for(int i=0; i<tamA; i++)
        {
            vecA[i]=Abonados[i];
            cont++;
        }
    }

    return cont;
}

void inicializarAbonados(eAbonado vecA[], int tamA)
{
    for(int i=0; i<tamA; i++)
    {
        vecA[i].isEmptyAbonados=1;
    }
}

int buscarLibreAbonado(eAbonado vecA[],int tamA)
{
    int indice=-1;

    for(int i=0; i<tamA; i++)
    {
        if(vecA[i].isEmptyAbonados==1)
        {
            indice=i;
            break;
        }
    }

    return indice;
}


void mostrarAbonado(eAbonado vecA)
{
    /// char nomDestino[30];
    ///char nomPiloto[51];

    ///obtenerNomPiloto(piloto, tamPil,vecA.idPiloto, nomPiloto);
    /// obtenerNomDestino(destino, tamD, vecA.idDestino, nomDestino);

    printf("%2d  %17s  %10s  \n",vecA.idAbonado, vecA.nombre, vecA.apellido);

}

void mostrarAbonados(eAbonado vecA[], int tamA)
{
    int cont=0;

    ///system("cls");
    printf(" ID   NOMBRE    APELLIDO\n\n");

    for(int i=0; i<tamA; i++)
    {
        if(vecA[i].isEmptyAbonados==0)
        {
            mostrarAbonado(vecA[i]);
            cont++;
        }
    }


}



int altaAbonado(eAbonado vec[], int tam, int idAbonado)///agregar la estructura piltos para ver los Id
{
    int todoOk = 0;
    int index;
    //int idVuelo;
   // int idAbonado;
    char telefono[30];
    char nombre[30];
    char apellido[30];

    system("cls");

    printf("*****ALTA DE UN ABONADO*****\n\n");

    index = buscarLibreAbonado(vec, tam); ///a ver si hay lugar libre, lo guarda en index 1 si hay, -1 sino
    ///printf("%d",index);

    if( index == -1)
    {
        printf("\nEl Sistema Esta Completo\n\n");
        system("pause");
    }
    else
    {
        vec[index].idAbonado = idAbonado+1;

        getStringAlpha(30, "\nIngrese el nombre del Abonado: \n", nombre);
        strupr(nombre);
        getStringAlpha(30, "\nIngrese el apellido del Abonado: \n", apellido);
        strupr(apellido);

        pedirTelefono(telefono, 30, "Ingrese el telefono del abonado: \n");

        /// getIntRange(&telefono,00,24, "\nIngrese el horario de partida \n");
        ///getIntRange(&llegada,00,24, "\nIngrese el horario de llegada \n");

        vec[index] = newAbonado(idAbonado, telefono, nombre, apellido);

        todoOk = 1;
        printf("\nSe ha realizado el alta del Abonado\n\n");
        system("pause");

    }

    return todoOk;
}

eAbonado newAbonado(

    int idAbonado,
    char telefono [],
    char nombre[],
    char apellido[])

{
    eAbonado abonado;
    abonado.idAbonado= idAbonado;
    strcpy(abonado.numero,telefono);
    strcpy(abonado.nombre,nombre);
    strcpy(abonado.apellido,apellido);
    abonado.isEmptyAbonados = 0;

    return abonado;
}
///PARA PODER DAR EL ALTA


void bajaAbonado(eAbonado vecA[], int tamA)
{
    int confirma;
    int indice;
    int id;

    // mostrarClientes(vec,tam);
    mostrarAbonados(vecA, tamA);

    getIntRange(&id,1000,1100,"Ingrese id del abonado: ");

    //indice=buscarClienteId(vec,tam,id);
    indice=buscarAbonadoPorId(id, vecA, tamA);

    if(indice==-1)
    {
        getIntRange(&id,1000,1100,"Ingrese id de Abonado valido: ");

        indice=buscarAbonadoPorId(id, vecA, tamA);

        printf("\nEl id ingresado es incorrecto\n\n");
    }
    if(indice !=-1)
    {
        mostrarAbonado(vecA[indice]);
        confirma=confimarSalir("\n\nDar de baja el Abonado? s/n: ");

        if(confirma==1)
        {
            vecA[indice].isEmptyAbonados=1;
            printf("\nOperacion realizada\n\n");
        }
        else
        {
            printf("\nOperacion cancelada\n\n");
        }
    }

}


int buscarAbonadoPorId(int idAbonado, eAbonado vecA[], int tamA)
{
    int index = -1;

    for(int i=0; i < tamA; i++)
    {
        if( vecA[i].idAbonado == idAbonado && vecA[i].isEmptyAbonados == 0)
        {
            index = i;
            break;
        }

    }
    return index;
}

int modificarAbonado(eAbonado vec[], int tam)
{
    int indice;
    int todoOk=0;
    int id;

    //mostrarClientes(vec,tam);
    mostrarAbonados(vec, tam);

    getIntRange(&id,1000,1100,"Ingrese id del abonado: ");

    indice=buscarAbonadoPorId(id, vec, tam);

    while(indice==-1)
    {
        getIntRange(&id,1000,1100,"Ingrese id de abonado valido: ");

        indice=buscarAbonadoPorId(id, vec, tam);
    }
    if(indice !=-1)
    {
        getStringAlpha(30,"Ingrese el nuevo nombre: ",vec[indice].nombre);
        getStringAlpha(30, "Ingrese el nuevo apellido: ", vec[indice].apellido);
        pedirTelefono(vec[indice].numero, 30,"ingrese el nuevo numero");
    }
    return todoOk=1;
}
