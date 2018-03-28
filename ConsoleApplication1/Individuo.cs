using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aquí representamos al Individuo como una sola unica solucion en donde se llegan a trabajar con mas de una sola unica solución
namespace Programa1
{
    class Individuo
    {
        Cromosoma cromosoma;
        public Individuo(int num_bits, Random r)
        {
            cromosoma = new Cromosoma(num_bits, r);
            cromosoma.Inicializar();//Aqui lo que estamos haciendo es mutar los genes del Individuo
            
        }
        public Individuo(int num_bits){//Declaramos constructor para el Individuo e inicialice valores en "0"
            cromosoma=new Cromosoma(num_bits);
            cromosoma.Inicializar2();
        }

        public override string ToString()//Representacion de soluciones
        {
            cromosoma.GetValue();
           // Console.WriteLine("Decimal:"+cromosoma.GetValue());
            return cromosoma.ToString();
        }
        /*FUNCION PRINCIPAL PARA LA CRUZA POR UN PUNTO*/
        public Individuo[] devolver(Individuo madre, Individuo padre, int num_bits){
            Individuo []hijos=new Individuo[2];
            for (int i=0;i<2;i++){//INICIALIZAR VALORES
                hijos[i]=new Individuo(num_bits);
                
            }
            int valor=madre.cromosoma.getGenes().Length;
            int[] temp = madre.cromosoma.getGrey();//añadimos las temporales para obtener valores dados respectivamente
            int[] temp2 = padre.cromosoma.getGrey();
            for (int j=0;j<valor;j++){//combinacion de los punto
                if (j < 3)
                {
                    hijos[0].cromosoma.setGenes(j, temp[j]);//Combinacion
                    hijos[1].cromosoma.setGenes(j,temp2[j]);
                }
                else
                {

                    hijos[0].cromosoma.setGenes(j, temp2[j]);
                    hijos[1].cromosoma.setGenes(j, temp[j]);
                }
            }
            //IMPRESION DE HIJOS DADOS POR PADRES
            //COMBINACION POR PUNTOS
            Console.WriteLine("INTERCAMBIANDO PUNTOS");
            hijos[0].ToString();
            hijos[1].ToString();
            Console.WriteLine(hijos[0].cromosoma.ToString2());
            Console.WriteLine(hijos[1].cromosoma.ToString2());
            return hijos;
        }
    }
}
