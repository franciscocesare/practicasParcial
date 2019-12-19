
#ifndef __LINKEDLIST
#define __LINKEDLIST
struct Node
{
    void* pElement;                 ///puntero al elemento (persona, empleado, etc.)
    struct Node* pNextNode;         ///puntero al prox nodo
}typedef Node;

struct LinkedList
{
    Node* pFirstNode;
    int size;                       ///cada vez que agrego o elimino un elemento size++/--
}typedef LinkedList;
#endif



//Publicas
LinkedList* ll_newLinkedList(void); /// cada vez que se agrega un empleado se hace un resize con realoc
int ll_add(LinkedList* this, void* pElement); /// recibe el puntero a la lista y agrega un elemnento (void porque no sabe què tipo de dato es)

int ll_len(LinkedList* this); ///devuelve el valor del campo int size

Node* test_getNode(LinkedList* this, int nodeIndex);
int test_addNode(LinkedList* this, int nodeIndex,void* pElement);

void* ll_get(LinkedList* this, int index);/// sirve para pedir un elemento a través del índice,devuelve un puntero a void
int ll_set(LinkedList* this, int index,void* pElement);/// reemplaza un puntero en un nodo existente
int ll_remove(LinkedList* this,int index); /// quita un elemento de la lista (el nodo anterior deja de apuntar al que queremos borrar y pasa a apuntar al siguiente)
int ll_clear(LinkedList* this); /// vuelve a la lista al estado original (como estaba antes de hacer un ingreso)
int ll_deleteLinkedList(LinkedList* this); /// remueve todos los nodos, hasta la raiz, como si nunca se hubiese ejecutado el new
int ll_indexOf(LinkedList* this, void* pElement); /// le paso un puntero a un elemento y le pregunto en qué índice lo tiene
int ll_isEmpty(LinkedList* this); /// pregunta si está vacía (responde si o no)
int ll_push(LinkedList* this, int index, void* pElement);/// permite meter un elemento entre 2 elementos existentes (es la versión posta del add)
void* ll_pop(LinkedList* this,int index);        ///elimina un elemento (l enlace a ese elemento) y devuelve un puntero a ese elemento
int ll_contains(LinkedList* this, void* pElement); /// me devuelve si ese elemento está o no está (es la versión no sofisticada de la que devuelve el index)
int ll_containsAll(LinkedList* this,LinkedList* this2);  /// recibe 2 listas, se usa para saber si los elementos de la lista 2 están dentro de la 1 (recorre la lista y verifica que cada elemento de la 2 esté contenido en la 1)
LinkedList* ll_subList(LinkedList* this,int from,int to); /// hace slicing: de una lista obtener un pedazo, o sea: devuelve una nueva lista integrada solo por los elementos "desde" "hasta"
LinkedList* ll_clone(LinkedList* this); /// es un caso particular del sublist: cuando se copian todas los elementos (soft copy: solo se copia el puntero a la lisata != deep copy: se hace un puntero a una lista nueva y se copia los punteros a los elementos)
int ll_sort(LinkedList* this, int (*pFunc)(void* ,void*), int order);
LinkedList* ll_map (LinkedList* lista, void* (*pFunc)(void*));
///LinkedList* ll_filter (LinkedList* lista, int (*pFun)(void*), char tipoVehiculo);
LinkedList* ll_filter(LinkedList* this, int (*pFunc)(void*));
/// le pasa una lista, le pasa un criterio, y le pasa un orden
                        /// el criterio puede ser cualquier cosa: devuelve -1, 0 y 1 como el strcmp y le dice si tiene que hacer el swap o no
                        /// el criterio tambièn puede devolver V o F para saber si hay que hacer o no algo (por ejemplo una sublista, remover algo, incrementar el salario de un sector, etc.)

int ll_counter(LinkedList* this, int (*pFunc)(void*));
