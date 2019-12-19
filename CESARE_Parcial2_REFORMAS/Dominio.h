
/*
typedef struct {

    int id;
    char descripcion[150];
    float precio;
    int idTipo;
    char oferta[50];

}eBicicleta;
*/
typedef struct {

    int id;
    char nombre[30];
    char tipo[20];
    int tiempo;
    float velocidad;

}eBicicleta;


//eCachorro* newCachorro();

///NEW PARAMETROS SON TODOS CHAR, DESPUES CASTEA CON ATOI A LOS CARACTERES
//eCachorro* newCachorro_Parametros(char* id,char* nombre,char* dias, char* raza , char* reservado,char* genero

///EL SET MODIFICA EL ELEMENTO, EL GET OBTIENE Y CARGA



eBicicleta* newBicileta();
eBicicleta* newBicicleta_Parametros(char* idBike, char* nombre, char* tipo, char* tiempo, char*velocidad);

void showBicicleta(eBicicleta* bici);
void showBicicletas(LinkedList* pLinkedBike);


int eBicicleta_setId(eBicicleta* listaBike,int id);
int eBicicleta_getId(eBicicleta* listaBike,int* id);///el get lleva * el SET no

int eBicicleta_setNombre(eBicicleta* listaBike, char* nombre);
int eBicicleta_getNombre(eBicicleta* listaBike,char* nombre);

int eBicicleta_setTipo(eBicicleta* listaBike, char* tipo);///SET RAZA CADENA DE CARACTERES
int eBicicleta_getTipo(eBicicleta* listaBike,char* tipo); ///GET RAZA CADENA DE CARACTERES

int eBicicleta_setTiempo(eBicicleta* listaBike,int tiempo);
int eBicicleta_getTiempo(eBicicleta* listaBike,int* tiempo); ///el get lleva * el SET no

int eBicicleta_setVelocidad(eBicicleta* listaBike,float velocidad);
int eBicicleta_getVelocidad(eBicicleta* listaBike, float* velocidad);

int setearVelocidad(void* element);



//int cargarDescripcion(void* lista, char* desc);

int sortBikes (void* desktop, void* laptop);

int filter_mtb(void* aux);
int filter_bmx(void* aux);
int filter_paseo(void* aux);
int filter_playera(void* aux);

int filter_desktop(void* aux);

int setearOferta(void* element);



///FILTER DE CACHORROS
/*int filter_45dias(void* aux);
int filter_machos(void* aux);
int filter_callejeros(void* aux) ;
int filter_reservado(void* aux); ///la funcion que despues es pasada como pFUNC a ll_filter con filtro de CARACTERES


///FILTER DE DOMINIOS

int setearTipo(eCachorro* cacho);///aca setear 45 dias??? y setear machos, y listado callejeros
void* seteaTipo(eCachorro* e);

int filterTipo(void* e);
*/
