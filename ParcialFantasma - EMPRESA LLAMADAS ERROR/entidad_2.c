#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "inputDiaz.h"
///#include "entidad_1.h"
#include "entidad_2.h"
#include "entidad_3.h"

/*void harcodearDestino(eDestino vecDes[], int tamD)
{
    eDestino destinos[]=
    {
        {1,"Cancun",5000},
        {2,"Miami",3000},
        {3,"Rio",2000},
        {4,"Dominicana",6000},
        {5,"Cuba",10000},

    };

    for(int i=0; i<tamD; i++)
    {
        vecDes[i]=destinos[i];
    }
}
*/
int harcodearllamadas(eLlamada vec[], int tam, int cant)///tiene que tener de estado CHAR
{
    int cont=0;
    eLlamada llamadas[]=
    {
        {100,"FALLA 3G", "NO SOLUCIONADO",0},
        {101,"FALLA LTE", "SOLUCIONADO",0},
        {102,"FALLA EQUIPO","SOLUCIONADO",0},
        {103,"FALLA LTE","NO SOLUCIONADO",0},
        {104,"FALLA LTE","EN CURSO",0},
        {105,"FALLA EQUIPO","EN CURSO",0},
        {106,"FALLA 3G","EN CURSO",0},
        {107,"FALLA LTE","EN CURSO",1},
        {108,"FALLA EQUIPO","EN CURSO",1},

    };

    if(cant<= tam && cant<=9)
    {
        for(int i=0; i<tam; i++)
        {
            vec[i]=llamadas[i];
            cont++;
        }
    }

    return cont;
}
/*
void mostrarVuelo(eVuelo vecVue, eDestino destino[], int tamD, ePiloto piloto[], int tamPil)
{
    char nomDestino[30];
    char nomPiloto[51];

    obtenerNomPiloto(piloto, tamPil,vecVue.idPiloto, nomPiloto);
    obtenerNomDestino(destino, tamD, vecVue.idDestino, nomDestino);

    printf(" %2d  %17s  %10s  %4d   %4d   %10s  \n",vecVue.idVuelo,nomPiloto,nomDestino, vecVue.horaPartida, vecVue.horaLlegada, vecVue.estado);

}
*/

void mostrarllamada(eLlamada llam, eAbonado vec[],int tam)
{
  //  char nombre[30];
    char apellido[30];

    //obtenerNombreAbonado(vec, tam, vec.idAbonado, apellido);
    ///obtenerNomPiloto(piloto, tamPil,vecVue.idPiloto, nomPiloto);

  printf("%d    %10s   %10s     \n", llam.idllamada, llam.estado, apellido);

}

void mostrarllamadas(eLlamada llamadas[], int tamL, eAbonado abonados[], int tamA)
{
    int cont=0;

    ///system("cls");
    printf("  ID   ESTADO    APELLIDO ABONADO \n\n");

    for(int i=0; i<tamL; i++)
    {
        if(llamadas[i].isEmptyllamadas==0)
        {
            mostrarllamada(llamadas[i], abonados, tamA);
            cont++;
        }
    }


}

/*void mostrarDestinos(eDestino destino[],int tamD){

  ///  system("cls");
    printf("**** DESTINOS ****\n\n");
    printf(" ID    DESTINO          IMPORTE\n\n");

    for(int i=0 ;i<tamD; i++)
    {
        mostrarDestino(destino[i]);
    }
}
*/

void obtenerNombreAbonado(eAbonado vec [], int tam, int id, char dondeAsignar[])
{
    for(int i=0; i<tam; i++)
    {
        if(vec[i].idAbonado == id)
        {
            strcpy(dondeAsignar,vec[i].apellido);
        }
    }
}

/*
void obtenerNomPiloto(ePiloto vecPil[], int tamPil, int id, char dondeAsigar[])
{
    for(int i=0; i<tamPil; i++)
    {
        if(vecPil[i].idPiloto == id)
        {
            strcpy(dondeAsigar,vecPil[i].nombre);
            strcat(dondeAsigar,", ");
            strcat(dondeAsigar,vec[i].nombre);
        }
    }
}

*/

///
int altallamada(eLlamada vec[], int tam, int idllamada, eAbonado vecA[], int tamA)
{

    int todoOk = 0;
    int index;
    int id;
    int idAbonado;
    //char name[51];
    char motivo[30];
   /// char estado[30];

    system("cls");

    printf("*****Alta nueva llamada *****\n\n");

    index = findFree(vec, tam); ///a ver si hay lugar libre, lo guarda en index 1 si hay, -1 sino

    if( index == -1)
    {
        printf("\nEl Sistema Esta Completo\n\n");
        system("pause");
    }
    else
    {
        vec[index].idllamada = idllamada+1;

        mostrarAbonados(vecA, tamA);
        getIntRange(&idAbonado, 1000, 1010, "ingrese el Id del abonado");

        getStringAlphaNum(30, "Ingrese el motivo del llamado: ", motivo);


        vec[index] = newllamada(idllamada, motivo);
        todoOk = 1;
        printf("\nSe ha realizado el alta del cliente\n\n");
        system("pause");

    }
    return todoOk;
}

eLlamada newllamada(

    int idllamada,
    char motivo[])
{

    eLlamada llamada;
    llamada.idllamada = idllamada;
   strcpy( llamada.motivo, motivo);
    strcpy( llamada.estado,"EN CURSO");
    llamada.isEmptyllamadas = 0;

    return llamada;
}


int findFree(eLlamada vec[], int tam)
{
    int index = -1;

    for(int i=0; i < tam; i++)
    {
        if( vec[i].isEmptyllamadas == 1 )
        {
            index = i;
            break;
        }
    }
    return index;
}

/** \brief  para indicar que el array esta vacio pone en todas las posiciones,
el isEmpty en 1, vacio
* \param array cliente
* \param size int tamnio del array
* \return funcion VOID, todas las posiciones inicializadas
*
*/
void inicializarllamadas(eLlamada vec[], int tam)///inicia el array, pone todas las posicciones en 1. VACIO
{
    for(int i = 0; i < tam; i++)
    {
        vec[i].isEmptyllamadas = 1;
    }
}


int modificarllamada(eLlamada vec[], int tam, eAbonado abo[], int tamA)
{
    int indice;
    int todoOk=0;
    int id;
    int demoraDias;

    //mostrarClientes(vec,tam);
    ///mostrarAbonados(vec, tam);
    mostrarllamadas(vec, tam, abo, tamA);


    getIntRange(&id,100,120,"Ingrese id de la llamada a modificar: ");

    indice=buscarAllamadaPorId(id, vec, tam);

    while(indice==-1)
    {
        getIntRange(&id,100,120,"Ingrese id de la llamada a modificar VALIDO: ");

    indice=buscarAllamadaPorId(id, vec, tam);
    }
    if(indice !=-1)
    {
        getStringAlpha(30,"Ingrese el nuevo ESTADO, SOLUCIONADO - NO SOLUCIONADO: \n",vec[indice].estado);
        getIntRange(&demoraDias, 1,90, "ingrese cuantos dias demoro la reparacion: \n");
    }
    return todoOk=1;
}


int buscarAllamadaPorId(int idllmado, eLlamada vec[], int tam)
{
    int index = -1;

    for(int i=0; i < tam; i++)
    {
        if( vec[i].idllamada ==idllmado && vec[i].isEmptyllamadas == 0)
        {
            index = i;
            break;
        }

    }
    return index;
}
