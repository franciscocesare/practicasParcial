#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <conio.h>
#include "stdlib.h"

#include "LinkedList.h"
#include "parser.h"
#include "Dominio.h"
#include "validaciones.h"


/** \brief Carga los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
 int controller_loadFromText(char* path , LinkedList* pLinkedBikes)
{
     FILE* pFile = NULL;
    int result=0;

    if(path != NULL && pLinkedBikes != NULL){
        pFile= fopen(path,"r");
        if(pFile==NULL)
        {
            result=0;
        }
        else
        {
          result = parser_BikesFromText(pFile, pLinkedBikes);
        }
    }
    fclose(pFile);

    return result;
}
/*int controller_loadFromText(char* path , LinkedList* pArrayLinkedCachorros)
{
     FILE* pFile = NULL;
    int result=0;

    if(path != NULL && pArrayLinkedCachorros != NULL){
        pFile= fopen(path,"r");
        if(pFile==NULL)
        {
            result=0;
        }
        else
        {
          result = parser_CachorroFromText(pFile, pArrayLinkedCachorros);
        }
    }
    fclose(pFile);

    return result;
}*/

/** \brief Carga los datos de los empleados desde el archivo data.csv (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
/*int controller_loadFromBinary(char* path , LinkedList* pArrayLinkedDominio)
{
    FILE* pFile = NULL;
    int result=0;

    if(path != NULL && pArrayLinkedDominio != NULL){
        pFile = fopen(path,"rb");
        if(pFile==NULL)
        {
            result=0;
        }
        else
        {
          result = parser_DominioFromBinary(pFile, pArrayLinkedDominio);
        }
    }
    fclose(pFile);

    return result;
}
*/

/*int controller_map(LinkedList* pList)
{
    int todoOk = 0;

    system("cls");

    if(pList != NULL)
    {

      pList=ll_map(pList,setearOferta);
      todoOk=1;

    }
    return todoOk;
}*/

int Controller_filterPorTipo(LinkedList* pListBike)
{
    int todoOk = 0;
    int option;

    LinkedList* listaMTB = ll_newLinkedList();
    LinkedList* listaPASEO=ll_newLinkedList();
    LinkedList* listaBMX=ll_newLinkedList();
    LinkedList* listaPLAYERA=ll_newLinkedList();

  ///  int criterio;

    system("cls");
    printf("***FILTRAR POR TIPO***\n");
    printf("\n1-PASEO");
    printf("\n2-BMX");
    printf("\n3-MTB");
    printf("\n4-PLAYERA");

    if(pListBike != NULL)
    {

        printf("\nIngrese la opcion elegida: ");
        fflush(stdin);
        scanf("%d",&option);


        switch(option)
        {
        case 1:
            printf("\nFiltrando las bicicletas por Tipo\n");
            //ll_sort(pArrayListEmployee, ordenarEmpleadosId, criterio);
           if ( listaPASEO=ll_filter(pListBike, filter_paseo))
           {
               controller_saveAsText("filtradoPASEO.csv", listaPASEO);
           }


            todoOk=1;
            break;

        case 2:
            printf("\nFiltrando las bicicletas por Tipo\n");

           if (listaBMX=ll_filter(pListBike, filter_bmx))
           {
               controller_saveAsText("filtradoBMX.csv", listaBMX);
           }
            todoOk=1;
            break;

        case 3:
            printf("\nFiltrando las bicicletas por Tipo\n");

           if (listaMTB=ll_filter(pListBike, filter_mtb))
           {
               controller_saveAsText("filtradoMTB.csv", listaMTB);
           }
            todoOk=1;
            break;

        case 4:
            printf("\nFiltrando las bicicletas por Tipo\n");


           if (listaPLAYERA=ll_filter(pListBike, filter_playera))
           {
               controller_saveAsText("filtradoPLAYERA.csv", listaPLAYERA);
           }
            todoOk=1;
            break;

        default:
            printf("\nOPCION INVALIDA.\n");
        }

    }
    printf("\nSe filtro y genero archivo .CSV correctamente.\n\n");
    return todoOk;
}



/** \brief Ordenar empleados
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 */

int controller_sort(LinkedList* pList)
{
    int todoOk = 0;

    system("cls");

    if(pList != NULL)
    {

///       ll_sort(pList,sortComputers,1);

    }
    system("pause");
    return todoOk;
}




/** \brief Guarda los datos de los empleados en el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
///int controller_saveAsText(char* path , LinkedList* pArrayLinkedDominio)
int controller_saveAsText(char* path , LinkedList* pLinkedBikes)
{
    FILE* pFile = NULL;
    eBicicleta* auxBike = NULL;///la inicio en NULL para arrancar
    int size=ll_len(pLinkedBikes);///defino el tamaño igual al array
    int result=-1;

    int id;
    char nombre[30];
    char tipo[20];
    int tiempo;

    if(pLinkedBikes!=NULL && path!=NULL)
    {
        if(size>0)
        {
            pFile=fopen(path,"w");///abrimos el archivo para escrbirlo

            if(pFile!=NULL)
            {
                 for(int i=0;i<size;i++)
                {
                    auxBike=(eBicicleta*)ll_get(pLinkedBikes,i);///obtiene el array en tal indice
                    eBicicleta_getId(auxBike,&id);
                    eBicicleta_getNombre(auxBike,nombre);
                    eBicicleta_getTipo(auxBike,tipo);
                    eBicicleta_getTiempo(auxBike,&tiempo);

                    fprintf(pFile,"%d,%s,%s,%d\n",id,nombre,tipo,tiempo);
                }
                fclose(pFile);
                result=1;
            }
            else{
                result=0;
            }
        }
    }

    return result;
}

/** \brief Guarda los datos de los empleados en el archivo data.bin (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
/*int controller_saveAsBinary(char* path , LinkedList* pArrayLinkedDominio)
{
    FILE* pFile = NULL;
    eDominio* auxDom = NULL;
    int size = ll_len(pArrayLinkedDominio);
    int result = -1;

    if(pArrayLinkedDominio!=NULL && path!=NULL)
    {
        if(size>0)
        {
            pFile=fopen(path,"wb");

            if(pFile!=NULL)
            {
                for(int i=0; i<size;i++)
                {
                    auxDom=ll_get(pArrayLinkedDominio,i);
                    if(auxDom!=NULL)
                    {
                        fwrite(auxDom,sizeof(eDominio),1,pFile);
                    }
                }
            result=1;
            fclose(pFile);
            }
            else{
            result=0;
            }
        }
    }
    else{
        result=0;
    }

    return result;
}

*/

