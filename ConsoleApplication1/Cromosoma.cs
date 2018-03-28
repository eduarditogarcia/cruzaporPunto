using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    //Este es el cromosoma que contiene uno o mas genes
    class Cromosoma
    {
        private int BITS_PER_GENE;//Estamos presentando un ejemplo de el numero de genes que hay en una cromosoma
                                  //private int[] gene = { 0, 0, 0, 0, 1, 0, 1 };
        private int[] gene;       //el gen se representa por variable y esta es solo una variable 
        private int[] grey;       //el gen para grey
        private Random r; 
        public Cromosoma(int bits, Random r)
        {
            BITS_PER_GENE = bits;
            gene = new int[BITS_PER_GENE];//Es una forma del como se representa los genes en un cromosoma
            this.r=r;
        }
        //SOLO HACEMOS INICIALIZAMOS GENES
        public Cromosoma(int bits){
            BITS_PER_GENE = bits;
            gene = new int[BITS_PER_GENE];//Es una forma del como se representa los genes en un cromosoma
            
        }

        public void Inicializar()
        {//Aqui iniciamos con la mutación del Individuo con numeros aleatorios
            for (int a = 0; a < BITS_PER_GENE; a++)
            {
                gene[a] = r.Next(0, 2);
            }

        }
        //AQUI INICIALIZAMOS VALORES EN "0"
        public void Inicializar2()
        {   for (int a = 0; a < BITS_PER_GENE; a++)
            {
                gene[a] = 0;
            }

        }


        public int GetValue() {//funcion donde obtendremos el decimal y el grey
            int value = 0;
            int acumulador = 0;
            int pot;
            grey = ConversionGrey(gene);//mandamos a llamar la conversion grey
            for (int a = 1; a < BITS_PER_GENE; a++) {//bucle con el cual hacemos de binario a decimal
                pot = BITS_PER_GENE - a - 1;
                pot = (int)Math.Pow(2, pot);//2^potencia
                value = gene[a] * pot;
                acumulador = acumulador + value;//Solo aqui suma las potencias total+=1*pot
            }
            
             
            if (gene[0] == 1)//Definimos al gen
            {
                acumulador = acumulador *  -1;
            }

            return acumulador;
        }
        /*OBTENER VALORES DE GENES RESPECTIVAMENTE*/
        public int[] getGenes(){
            return gene;
        }
        public int[]getGrey(){
            return grey;
        }
        /*ASIGNACION DE VALORES EN LOS GENES*/
        public void setGenes(int indice,int valor)
        {
            gene[indice] = valor;
        }
        public int[] ConversionGrey(int[] binario)
        {//Funcion de conversión a grey con el cual combinamos el binario
            int inicio;
            int siguiente;
            int[] resultado = new int[BITS_PER_GENE];
            int aum = 1;
            resultado[0] = gene[0];
            for (int i = 0; i < BITS_PER_GENE - 1; i++)
            {//Bucle con el que recorre el numero binario dado aleatoriamente anteriormente
                inicio = binario[i];
                siguiente = binario[i + 1];
                if (i == 0 && inicio == 1)
                {
                    resultado[aum] = 0 ^ siguiente;//Aquí aplicamos la xor para solo el primer binaraio cuando solo sea el primero sea 1 ya que combinaba el ciclo 
                                                   //y no visualizaba el efecto grey que se requeria 
                }
                else
                {
                    resultado[aum] = inicio ^ siguiente;//Aquí se aplica el efecto grey con la xor en el recorrido normal
                }
                aum++;
            }

            return resultado;
        }

        public string ToString() {//Imprimir el resultado como de la cadena binaria
            string binario="";
            string binariogrey = "";
            for (int a = 0; a < BITS_PER_GENE; a++)
            {
                binario += Convert.ToString(gene[a]);
                binariogrey += Convert.ToString(grey[a]);  
            }
            return "Binario: "+binariogrey;
        }
        public string ToString2()
        {//Imprimir el resultado como de la cadena binaria 
            string binario = "";
            string binariogrey = "";
            for (int a = 0; a < BITS_PER_GENE; a++)
            {
                binario += Convert.ToString(gene[a]);
                binariogrey += Convert.ToString(grey[a]);
            }
            return "Binario: " + binario;
        }
    }
}
