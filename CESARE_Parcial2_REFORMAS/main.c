#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"
#include "controller.h"
#include "Dominio.h"
#include "validaciones.h"
#include "parser.h"


int main()
{
    int flag=0;
    int flagMap=0;
    int flagMapDesktop=0;


    ///FILE *pArchivo;

    ///LinkedList* listaCachorro = ll_newLinkedList();

    LinkedList* listaBikes = ll_newLinkedList();
    LinkedList* listaMapeadaVelocidad = NULL;

    LinkedList* listaMTB = NULL;
    LinkedList* listaPASEO=NULL;
    LinkedList* listaBMX=NULL;
    LinkedList* listaPLAYERA=NULL;

    ///LinkedList* listaMapeadaDesktop = NULL;
    ///  LinkedList* listaMapeadaOfertas = NULL;

    ///LinkedList* lista45Dias = NULL; ///cada nuevo linkedlist que crea MAP, se incializa en NULL
    ///LinkedList* listaMachos = NULL;

    char salir = 'n';
    char nombreArchivo [15];
    char nombreArchivoAux [15]="bicicletas.csv";

    ///int count=0;  LA USO SI USO LL_COUNT

    if(listaBikes!=NULL)
    {
        do
        {
            switch(menu())
            {
            case 1:

                getString(nombreArchivo, "INGRESE EL NOMBRE DEL ARCHIVO QUE DESEA ABRIR:\n\n", "ERROR ");
                strcat(nombreArchivo, ".csv");

                if (!strcmpi(nombreArchivo,nombreArchivoAux))///(parser_CachorroFromText(pArchivo, listaCachorro))

                {
                    system("cls");
                    if (controller_loadFromText(nombreArchivo, listaBikes))
                    {
                        system("cls");
                        printf("\nEL ARCHIVO ESTA CARGADO CORRECTAMENTE, PUEDE CONTINUAR\n");
                        flag=1;
                    }

                }
                else
                {
                    system("cls");
                    printf("\n***EL ARCHIVO NO EXISTE***\n");
                }

                break;

            case 2:
                if (flag)

                {
                    showBicicletas(listaBikes);
                   /// controller_sort(listaComputer);
                }
                else
                {
                    system("cls");
                    printf("\n***Primero debe cargar algun archivo***\n");
                }
                break;

            case 3: ///mostrar

                if (flag)
                {
                    if (listaMapeadaVelocidad=ll_map(listaBikes, setearVelocidad))
                        printf("acaaaaa");

                   /// showBicicletas(listaBikes);
                    flagMap=1;

                }
                else
                {
                    system("cls");
                    printf("\n***Primero debe cargar algun archivo***\n");
                }

                break;

            case 4: ///LL MAP
                if (flag)

                {
                    Controller_filterPorTipo(listaBikes);

                    flagMap=1;
                }

                else
                {
                    system("cls");
                    printf("\n***Primero debe cargar algun archivo para mapearlo***\n");
                }

                break;


            case 5:///filtar y mostrar


                if (flag && flagMap)
                {
                    system("cls");
                  ///  listaMapeadaDesktop = ll_filter(listaComputer, filter_desktop);///filtra y genera una nueva lista
                    printf("\n***Se Mapeo y Filtro las Tipo Desktop***\n");
                    system("pause");
                ///    showComputers(listaMapeadaDesktop);
                    flagMapDesktop=1;
                }
                else
                {
                    system("cls");
                    printf("\n***Algun paso se salteo, controle haber seteado las ofertas***\n");
                }
                break;
/*
            case 6:/// generar dato de salida filtrado;


                if(flagMapDesktop==1 && flag==1)
                {
                    /// listaMapeadaDesktop = ll_filter(listaComputer, filter_desktop);///filtra y genera una nueva lista
                    printf("\n***Se genero un archivo de salida Filtrado por Desktop****\n");
             ///       controller_saveAsText("filtrado.csv", listaMapeadaDesktop);///guarda esa nueva lista en texto, con el nombre pasado como parametro

                }
                else
                {
                    system("cls");
                    printf("\n***Primero se debe mapear y filtrar el archivo***\n");

                }
                break;*/

            case 6: ///SALIR
                printf("\nConfirma la salida del sistema? (s/n): ");
                fflush(stdin);
                scanf("%c",&salir);
                break;

            default:
                printf("\nOPCION INVALIDA\n");

            }
            system("\n\npause\n");
        }
        while(salir == 'n');
    }
    {
        printf("\nERROR. No se consiguio espacio en memoria para el LinkedList");
    }

    system("\n\npause");
    return 0;
}

