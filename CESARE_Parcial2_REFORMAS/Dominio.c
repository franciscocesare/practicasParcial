#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"
#include "validaciones.h"
#include "Dominio.h"

/** \brief Valida el valor de la ID y lo carga en estructura.
 *
 * \param recibe puntero de estructura Employee.
 * \param Toma el valor ID ingresado por el usuario.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_setId(eBicicleta* listaBike,int id)
{
    int result=0;
    if(listaBike!=NULL && id >0)
    {
        listaBike->id = id;
        result=1;
    }

    return result;
}

/** \brief Toma valor de ID de una estructura Employee.
 *
 * \param recibe puntero de estructura Employee.
 * \param puntero a entero y que guardara el valor del ID.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_getId(eBicicleta* listaBike,int* id)
{
    int result=0;

    if(listaBike!=NULL && id!=NULL)
    {
        *id = listaBike->id;
        result = 1;
    }

    return result;
}

/** \brief Valida la cadena y lo carga en estructura.
 *
 * \param Recibe puntero de estructura Employee.
 * \param Recibe cadena de caracteres.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_setTipo(eBicicleta* listaBike, char* tipo)
{
    int result=0;
    if( listaBike != NULL && tipo != NULL && strlen(tipo) <= 20 )
    {
        strcpy(listaBike->tipo, tipo);
        result = 1;
    }
    return result;
}


/** \brief Toma la cadena de una estructura Employee.
 *
 * \param Recibe puntero de estructura Employee.
 * \param Puntero a char donde guardara la cadena de la estructura.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_getTipo(eBicicleta* listaBike,char* tipo)
{

    int result=0;
    if( listaBike != NULL && tipo != NULL)
    {
        strcpy( tipo,listaBike->tipo);
        result = 1;
    }
    return result;
}

/** \brief Valida la cadena y lo carga en estructura.
 *
 * \param Recibe puntero de estructura Employee.
 * \param Recibe cadena de caracteres.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_setNombre(eBicicleta* listaBike, char* nombre)
{
    int result=0;
    if( listaBike != NULL && nombre != NULL && strlen(nombre) <= 30 )
    {
        strcpy(listaBike->nombre, nombre);
        result = 1;
    }
    return result;
}


/** \brief Toma la cadena de una estructura Employee.
 *
 * \param Recibe puntero de estructura Employee.
 * \param Puntero a char donde guardara la cadena de la estructura.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_getNombre(eBicicleta* listaBike,char* nombre)
{

    int result=0;
    if( listaBike != NULL && nombre != NULL)
    {
        strcpy( nombre,listaBike->nombre);
        result = 1;
    }
    return result;
}

/** \brief Valida el valor de la velocidad y lo carga en estructura.
 *
 * \param recibe puntero de estructura Employee.
 * \param Toma el valor ID ingresado por el usuario.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_setVelocidad(eBicicleta* listaBike,float velocidad)
{
    int result=0;
    if(listaBike!=NULL && velocidad >0)
    {
        listaBike->velocidad = velocidad;
        result=1;
    }

    return result;
}

/** \brief Toma valor de ID de una estructura Employee.
 *
 * \param recibe puntero de estructura Employee.
 * \param puntero a entero y que guardara el valor del ID.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_getVelocidad(eBicicleta* listaBike,float* velocidad)
{
    int result=0;

    if(listaBike!=NULL && velocidad!=NULL)
    {
        *velocidad = listaBike->velocidad;
        result = 1;
    }

    return result;
}


/** \brief Valida la cadena y lo carga en estructura.
 *
 * \param Recibe puntero de estructura Employee.
 * \param Recibe cadena de caracteres.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_setTiempo(eBicicleta* listaBike,int tiempo)
{
    int result=0;
    if(listaBike!=NULL && tiempo >0)
    {
        listaBike->tiempo = tiempo;
        result=1;
    }

    return result;
}


/** \brief Toma la cadena de una estructura Employee.
 *
 * \param Recibe puntero de estructura Employee.
 * \param Puntero a char donde guardara la cadena de la estructura.
 * \return Retorna 0 (cero) o 1 (uno).
 */
int eBicicleta_getTiempo(eBicicleta* listaBike,int* tiempo)
{
    int result=0;

    if(listaBike!=NULL && tiempo!=NULL)
    {
        *tiempo = listaBike->tiempo;
        result = 1;
    }

    return result;
}

int setearVelocidad(void* element)
{
    int result = 0;
    int minutos;
    float velocidadPromedio;



    eBicicleta* bici = NULL;

    if( element != NULL)
    {
        bici = (eBicicleta*)element;

        if( eBicicleta_getTiempo(element, minutos))
        {
            velocidadPromedio=(float) 10/minutos;
            eBicicleta_setVelocidad(element, velocidadPromedio);
             result = 1;
        }
    }
    return result;
}




/** \brief Crea espacio en memoria y crea una nueva estructura del tipo Employee
 *
 * \return Devuelve la nueva estructura creada con los campos inicializados
 */
/*eCachorro* newCachorro()
{
    eCachorro* nuevo = (eCachorro*) malloc(sizeof(eCachorro));
    if(nuevo != NULL)
    {
        nuevo->id_cachorro = 0;
        strcpy(nuevo->nombre, "");
        nuevo->dias = 0;
        strcpy(nuevo->raza, "");
        strcpy(nuevo->reservado, "");
        nuevo->genero=' ';

    }
    return nuevo;
}*/
eBicicleta* newBicileta()
{
    eBicicleta* nuevo = (eBicicleta*) malloc(sizeof(eBicicleta));///nuevo->para los Int Float, strcpy para los string
    if(nuevo != NULL)
    {
        nuevo->id= 0;
        strcpy(nuevo->nombre, "");
        strcpy(nuevo->tipo, "");
        nuevo->tiempo=0;
        nuevo->velocidad=0;
    }
    return nuevo;
}


/** \brief Crea una nueva estructura de tipo Employee* y se cargan los campos con los parametros recibidos
 *
 * \param  Recibe cadena con los datos de la Id
 * \param  Recibe cadena de caracteres con los datos de Nombre
 * \param  Recibe cadena con el valor de las Horas trabajadas
 * \param  Recibe cadena con el valor del Sueldo
 *
 * \return Retorna la estructura Employee* con los datos cargados en sus campos
 */

eBicicleta* newBicicleta_Parametros(char* id, char* nombre, char* tipo, char* tiempo, char*velocidad)
{
    eBicicleta* nuevo = newBicileta();
    if( nuevo != NULL)
    {
        if (id!=NULL && nombre!=NULL && tipo!=NULL &&  tiempo!=NULL && velocidad!=NULL)
        {
            eBicicleta_setId(nuevo,atoi(id));
            eBicicleta_setNombre(nuevo, nombre);
            eBicicleta_setTipo(nuevo, tipo);
            eBicicleta_setTiempo(nuevo,atoi(tiempo));
            eBicicleta_setVelocidad(nuevo, atof(velocidad));

        }
        else
        {
            free(nuevo);
        }
    }
    return nuevo;
}
/*eCachorro* newCachorro_Parametros(char* id,char* nombre,char* dias, char* raza, char* reservado,char* genero)
{
    eCachorro* nuevo = newCachorro();
    if( nuevo != NULL)
    {
        if (id!=NULL && nombre!=NULL && dias!=NULL &&  raza!=NULL && reservado != NULL && genero!=NULL)
        {
            eCachorro_setId(nuevo,atoi(id));
            eCachorro_setNombre(nuevo, nombre);
            eCachorro_setDias(nuevo, atoi(dias));
            eCachorro_setRaza(nuevo, raza);
            eCachorro_setReservado(nuevo, reservado);
            eCachorro_setGenero(nuevo, genero);
        }
        else
        {
            free(nuevo);
        }
    }
    return nuevo;
}*/





/** \brief Muestra en pantalla, los datos de la linkedList
 *
 * \param Recibe LinkedList*
 */
/*void showCachorro(eCachorro* nuevo)
{
    if (nuevo!= NULL)
    {
        printf("%4d   %10s  %5d   %10s   %10s   %5c\n",nuevo->id_cachorro, nuevo->nombre, nuevo->dias, nuevo->raza, nuevo->reservado, nuevo->genero);
    }
}*/

void showBicicleta(eBicicleta* bici)
{
   /// char descTipo [30]; ///para poner el tipo en vez de Id Tipo
    if(bici!=NULL)
    {
        ///cargarDescripcion(compu, descTipo);
        printf("%2d %10s  %10s  %10d \n",bici->id, bici->nombre, bici->tipo, bici->tiempo);
    }
}



/** \brief Muestra los datos de una bicicleta
 *
 * \param Recibe un puntero a Employee
 */

///void showDominios(LinkedList* pArrayLinkedDominio)

void showBicicletas(LinkedList* pLinkedBike)
{
    int tam;
    system("cls");
    printf(" ID   NOMBRE         TIPO           TIEMPO\n");
    printf("-----------------------------------------------\n");

    if(ll_len(pLinkedBike) == 0)
    {
        printf("NO HAY BICICLETAS  QUE MOSTRAR\n\n");
    }

    if(pLinkedBike != NULL)
    {
        tam = ll_len(pLinkedBike);
        for(int i=0; i<tam; i++)
        {
            showBicicleta((eBicicleta*) ll_get(pLinkedBike, i));
        }
    }
}



/*int sortComputers (void* desktop, void* laptop)///(void* Employee1, void* Employee2)
{

    int retorno;
    int idTipoDesktop;
    int idTipoLaptop;

    eBicicleta* auxComputer1 = (eBicicleta*) desktop;
    eBicicleta* auxComputer2 = (eBicicleta*) laptop;

    eBicicleta_getIdTipo(auxComputer1, &idTipoDesktop);
    eBicicleta_getIdTipo(auxComputer2, &idTipoLaptop);

    if (idTipoDesktop > idTipoLaptop)
    {
        retorno = 1;
    }
    else if (idTipoDesktop < idTipoLaptop)

    {
        retorno=-1;
    }
    else
    {
        retorno =0;
    }

    return retorno;
}*/

int filter_mtb(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES
{
    int todoOk = 0;
    char tipo [20];

    ///eCachorro* cachorro45 =NULL;
    if(aux != NULL)
    {

        aux = (eBicicleta*)aux;
        eBicicleta_getTipo(aux,tipo);
        if (strcmpi(tipo,"MTB")==0)
            todoOk=1;
    }
    return todoOk;
}
    ///

int filter_bmx(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES
{
    int todoOk = 0;
    char tipo [20];

    ///eCachorro* cachorro45 =NULL;
    if(aux != NULL)
    {
        aux = (eBicicleta*)aux;
        eBicicleta_getTipo(aux,tipo);
        if (strcmpi(tipo,"BMX")==0)
            todoOk=1;
    }
    return todoOk;
}
///

int filter_paseo(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES
{
    int todoOk = 0;
    char tipo [20];

    ///eCachorro* cachorro45 =NULL;
    if(aux != NULL)
    {
        aux = (eBicicleta*)aux;
        eBicicleta_getTipo(aux,tipo);
        if (strcmpi(tipo,"PASEO")==0)
            todoOk=1;
    }
    return todoOk;
}



int filter_playera(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES
{
    int todoOk = 0;
    char tipo [20];

    ///eCachorro* cachorro45 =NULL;
    if(aux != NULL)
    {

        aux = (eBicicleta*)aux;
        eBicicleta_getTipo(aux,tipo);
        if (strcmpi(tipo,"PLAYERA")==0)
            todoOk=1;
    }
    return todoOk;
}





/*int filter_desktop(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES
{
    int todoOk = 0;
    int idTipo;

    ///eCachorro* cachorro45 =NULL;
    if(aux != NULL)
    {
        aux = (eBicicleta*)aux;
        eBicicleta_getIdTipo(aux, &idTipo);
        if (idTipo==1)
            todoOk=1;
    }
    return todoOk;
}*/



/*int setearOferta(void* element)
{
    int result = 0;
    eBicicleta* compu = NULL;

    if( element != NULL)
    {
        compu = (eBicicleta*)element;
        if( compu->idTipo == 2)
        {
            strcpy(compu->oferta, "SIN DATOS");
        }
        else if(compu->idTipo == 1   && compu->precio > 20000 )
        {
            strcpy(compu->oferta, "50% DESCUENTO");
        }
        result = 1;
    }
    return result;
}*/

/// PARA FILTER
/*int filter_45dias(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter filtro de INT
{
    int todoOk = 0;
    int dias;

    if(aux != NULL)
    {
        aux = (eCachorro*)aux;
        eCachorro_getDias(aux,&dias);
        if (dias>45)
            todoOk=1;
    }
    return todoOk;
}*/


///FILTER SIN LOS CACHORROS QUE SON MACHOS
/*int filter_machos(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de UN CARACTER
{
    int todoOk = 0;
    char genero;
    if(aux != NULL)  ///me falla machos
    {
        aux = (eCachorro*)aux;
        eCachorro_getGenero(aux,&genero);///el & va porque es un carcater no una cadena

        if (genero !='M')
            todoOk=1;
    }
    return todoOk;
}*/


/*int filter_callejeros(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES
{
    int todoOk = 0;
    char raza [20];

    ///eCachorro* cachorro45 =NULL;
    if(aux != NULL)
    {

        aux = (eCachorro*)aux;
        eCachorro_getRaza(aux,raza);
        if (strcmpi(raza,"Callejero")==0)
            todoOk=1;
    }
    return todoOk;
}*/

///FILTER DE RESERVADO COMO EJEMPLO

/*int filter_reservado(void* aux) ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES
{
    int todoOk = 0;
    char reservado [20];

    if(aux != NULL)
    {

        aux = (eCachorro*)aux;
        eCachorro_getReservado(aux,reservado);
        if (strcmpi(reservado,"SI")==0)
            todoOk=1;
    }
    return todoOk;
}*/

///FILTER DE RO
/*int employee_filterUnder45(void* aux)
{
    int returnAux = 0;

    if(aux != NULL)
    {
        int age;
        aux = (mascota*)aux;

        employee_getAge(aux, &age);

        if(age > 45)
            returnAux = 1;
    }

    return returnAux;
}


/*int cargarDescripcion(void* lista, char* desc)
{
    int todoOk = 0;
    int idTipo;

    if(lista != NULL && desc != NULL)
    {
        if(eBicicleta_getIdTipo(lista, &idTipo))
        {
            if(idTipo == 1)
            {
                strcpy(desc, "DESKTOP");
            }
            else if(idTipo == 2)
            {
                strcpy(desc, "LAPTOP");
            }
            todoOk=1;
        }
    }
    return todoOk;
}
*/
