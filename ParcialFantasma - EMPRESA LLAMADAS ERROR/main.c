#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "inputDiaz.h"
#include "entidad_1.h"
#include "entidad_2.h"
#include "entidad_3.h"
#include "informes.h"

///#define TAM_ENTIDAD_1 5
#define TAMLLAMADA 9
#define TAMABONADO 9


int menuOpciones();

int main()
{
    int salir;
    int atrasInf;
    int flag=0;


    int idAbonado=1000;
    int idllamada=100;


    ///ePiloto pilotos[TAM_ENTIDAD_1];
    ///eVuelo vuelos [TAM_ENTIDAD_3];
    eAbonado abonados[TAMABONADO];
    eLlamada llamadas[TAMLLAMADA];

    inicializarAbonados(abonados,TAMABONADO);
    inicializarllamadas(llamadas, TAMLLAMADA);

    ///harcodearPilotos(pilotos, TAM_ENTIDAD_1);
    ///harcodearDestino(destinos, TAM_ENTIDAD_2);
    harcodearAbonados(abonados,TAMABONADO, 7);
    harcodearllamadas(llamadas, TAMLLAMADA, 7);

    idAbonado=idAbonado+harcodearAbonados(abonados,TAMABONADO,9);
    idllamada=idllamada+harcodearllamadas(llamadas, TAMLLAMADA, 9);

    do
    {
        switch(menuOpciones())
        {

        case 1:

            if (altaAbonado(abonados, TAMABONADO,idAbonado))
            {
                idAbonado ++;
                flag=1;

                mostrarAbonados(abonados,TAMABONADO);
            }
            break;

        case 2:

            if (flag)
            {
                bajaAbonado(abonados, TAMABONADO);
            }
            else
            {
                printf("\nprimero debe cargar algun abonado\n");
            }
            break;

        case 3:

            if (flag)
                modificarAbonado(abonados, TAMABONADO);///ver que nunca deja de pedir la modificacion
            else
            {
                printf("\nprimero debe cargar algun abonado\n");
            }
            break;

        case 4:

            if (altallamada(llamadas, TAMLLAMADA,idllamada, abonados, TAMABONADO ))
            {
                idllamada ++;
                flag=1;
                system("pause");
                mostrarllamadas(llamadas, TAMLLAMADA, abonados, TAMABONADO);
            }

            else
            {

                printf("\nprimero debe cargar algun llamado\n");
            }

            break;

        case 5:

            if (flag)
            {
                modificarllamada(llamadas, TAMLLAMADA, abonados, TAMABONADO);

            }
            else
            {
                printf("aun no se cargaron datos\n");
            }

            break;

        case 6:
            ///fin de una llamada


                do
                {
                    switch(menuInformes())
                    {
                    case 1 :
                        ///nombre del abonado con mas reclamos
                        ///vuelosPilotoSeleccionado(vuelos, TAM_ENTIDAD_3, pilotos, TAM_ENTIDAD_1, destinos, TAM_ENTIDAD_2);

                        break;

                    case 2 :
                        ///el reclamo mas realizado

                        clientequemasreclamo(llamadas, TAMLLAMADA, abonados, TAMABONADO);

                        break;

                    case 3 :
                        ///reclamo que en prmedio mas demora
                        ///recaudacionPilotoSeleccionado(pilotos, TAM_ENTIDAD_1, vuelos, TAM_ENTIDAD_3, destinos, TAM_ENTIDAD_2);

                        break;


                    case 4:
                        atrasInf=confimarSalir("\nVolver atras? s/n: ");
                        break;

                    }
                    printf("\n\n");
                    system("pause");

                }
                while(atrasInf !=1);


            break;

        case 7:
            salir=confimarSalir("\nDesea salir? s/n: ");
            break;

        default:
            printf("Ingrese opcion correcta\n");
        }

        printf("\n\n");
        system("pause");

    }
    while(salir != 1);

    return 0;
}

int menuOpciones()
{
    int opcion;

    system("cls");
    printf("  ***  MENU DE OPCIONES ***   \n\n");
    printf("1. Alta de un Abonado\n");
    printf("2. Baja de un Abonado\n");
    printf("3. Modificar Abonado\n");
    printf("4. Alta de una llamada\n");
    printf("5. Fin de una llamada\n");
    printf("6. Informes\n");
    printf("7. Salir\n\n");
    printf("Ingrese opcion: ");
    scanf("%d",&opcion);

    return opcion;
}

