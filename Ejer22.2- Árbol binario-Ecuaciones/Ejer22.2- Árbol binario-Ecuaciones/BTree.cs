using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer22._2__Árbol_binario_Ecuaciones
{
    class BTree
    {
        private Nodo raiz;
        private Nodo _fin;

        private void agregarNodoALista(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                agregarALista(nuevo, raiz);
        }

        private void agregarALista(Nodo nuevo, Nodo anterior)
        {
            if (anterior.siguiente == null) {
                anterior.siguiente = nuevo;
                nuevo.anterior = anterior;
                _fin = nuevo;
            }
            else
                agregarALista(nuevo, anterior.siguiente);
        }

        public void crearArbol(string cadena) {
            if(raiz!=null)
                limpiarRaiz();
            
            char[] cadenaVector = cadena.ToCharArray();

            for (int contador = 0; contador < cadenaVector.Length; contador++) {
                Nodo nuevo = new Nodo(cadenaVector[contador]);
                agregarNodoALista(nuevo);
            }

            Nodo temporal = raiz;
            temporal = operadoresMulDiv(temporal, raiz);
            temporal = raiz;
            operadoresSumRes(temporal, raiz);
        }
        private void limpiarRaiz()
        {
            raiz.dato = '\0';
            raiz.hijoDer = null;
            raiz.hijoIzq = null;
            raiz.siguiente = null;
            raiz = null;
        }

        public bool revisarCadena(string cadena) {
            char[] cadenaVector = cadena.ToCharArray();
            bool cadenaBien = true;

            if (cadenaVector.Length % 2 == 0)
                cadenaBien = false;
            else {
                for (int contador = 0; contador < cadenaVector.Length && cadenaBien == true; contador++) { 
                    if (contador == 0 || contador % 2 == 0){
                        if (cadenaVector[contador] < 48 && cadenaVector[contador] > 57)
                            cadenaBien = false;
                    }
                    else{
                        if (cadenaVector[contador] > 47 && cadenaVector[contador] < 58)
                            cadenaBien = false;
                    }
                }
            }
            return cadenaBien;
        }

        private void bajarNodosLaterales(Nodo temporal) {
            //Bajarlos
            temporal.hijoIzq = temporal.anterior;
            temporal.hijoDer = temporal.siguiente;

            //Quitar anterior
            if (temporal.anterior == raiz) {
                raiz = temporal;
                raiz.anterior = null;
            }
            else {
                temporal.anterior.anterior.siguiente = temporal;
                temporal.anterior = temporal.anterior.anterior;
            }

            //Quitar siguiente
            if (temporal.siguiente == _fin) {
                _fin = temporal;
                _fin.siguiente = null;
            }
            else {
                temporal.siguiente.siguiente.anterior = temporal;
                temporal.siguiente = temporal.siguiente.siguiente;
            } 
        }

        private Nodo operadoresMulDiv(Nodo temporal, Nodo raiz)
        {
            //OPERADORES   "*"  Y  "/"
            while (temporal.dato != '*' && temporal.dato != '/'&& temporal.siguiente!=null) 
                temporal = temporal.siguiente;

            if(temporal.dato=='*'||temporal.dato=='/')
                bajarNodosLaterales(temporal);

            if (temporal.siguiente != null) 
                operadoresMulDiv(temporal.siguiente, raiz);

            return temporal;
        }

        private void operadoresSumRes(Nodo temporal, Nodo raiz)
        {
            //OPERADORES   "+"  Y  "."
            while (temporal.dato != '+' && temporal.dato != '-' && temporal.siguiente!= null) 
                    temporal = temporal.siguiente;

            if (temporal.dato=='+'||temporal.dato=='-')
                bajarNodosLaterales(temporal);

            if (temporal.siguiente!= null)
                operadoresSumRes(temporal.siguiente, raiz);
        }

        public string preOrder()
        {
            if (raiz == null)
                return "";
            else
                return preOrder(raiz);
        }

        private string preOrder(Nodo R)
        {
            string recorrido = "";
            recorrido += R.ToString();

            if (R.hijoIzq != null)
                recorrido += preOrder(R.hijoIzq);

            if (R.hijoDer != null)
                recorrido += preOrder(R.hijoDer);

            return recorrido;
        }

        public string postOrder()
        {
            if (raiz == null)
                return "";
            else
                return postOrder(raiz);
        }

        private string postOrder(Nodo R)
        {
            string recorrido = "";

            if (R.hijoIzq != null)
                recorrido += postOrder(R.hijoIzq);

            if (R.hijoDer != null)
                recorrido += postOrder(R.hijoDer);

            recorrido += R.ToString();

            return recorrido;
        }

        public float pilaPre(string cadena) {
            char[] cadenaVector = cadena.ToCharArray();
            Stack<float> pilaResultados = new Stack<float>();

            for (int contador = cadenaVector.Length - 1; contador >= 0; contador--) {
                if (cadenaVector[contador] != '-' && cadenaVector[contador] != '+' && cadenaVector[contador] != '*' && cadenaVector[contador] != '/')
                    pilaResultados.Push(Convert.ToSingle(cadenaVector[contador].ToString()));
                else {
                    char operando = cadenaVector[contador];
                    switch (operando){
                        case '*':
                            pilaResultados.Push(pilaResultados.Pop() * pilaResultados.Pop());
                            break;
                        case '/':
                            pilaResultados.Push(pilaResultados.Pop() / pilaResultados.Pop());
                            break;
                        case '+':
                            pilaResultados.Push(pilaResultados.Pop() + pilaResultados.Pop());
                            break;
                        case '-':
                            pilaResultados.Push(pilaResultados.Pop() - pilaResultados.Pop());
                            break;
                        default:
                            break;
                    }
                }
            }
            return pilaResultados.Pop();
        }

        public float colaPost(string cadena) {
            char[] cadenaVector = cadena.ToCharArray();  
            Stack<float> pilaResultados = new Stack<float>();

            for(int contador=0;contador<cadenaVector.Length;contador++){
                if (cadenaVector[contador] != '-' && cadenaVector[contador] != '+' && cadenaVector[contador] != '*' && cadenaVector[contador] != '/')
                    pilaResultados.Push(Convert.ToSingle(cadenaVector[contador].ToString()));
                else {
                    float nodo1 = Convert.ToSingle(pilaResultados.Pop());
                    float nodo2 = Convert.ToSingle(pilaResultados.Pop());
                    char operando = cadenaVector[contador];
                    switch (operando){
                        case '*':
                            pilaResultados.Push(nodo2 * nodo1);
                            break;
                        case '/':
                            pilaResultados.Push(nodo2 / nodo1);
                            break;
                        case '+':
                            pilaResultados.Push(nodo2 + nodo1);
                            break;
                        case '-':
                            pilaResultados.Push(nodo2 - nodo1);
                            break;
                        default:
                            break;
                    }
                }
            }
            return pilaResultados.Pop();
        }
    }
}
