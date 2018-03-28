//UAEMEX ZUMPANGO 
//UA: ALGORITMOS GENETICOS
//CARRERA:INGENIERO EN COMPUTACIÓN
//ALUMNO:EDUARDO FRANCISCO GARCIA GAMBOA
//PROFESOR: ASDRUBAL LOPEZ CHAU
//16 DE FEBRERO DEL 2018
//DESCRIPCIÓN: Implementa la representación entera usando código gray. 
//El lenguaje de programación a usar es c#.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Inicio del Programa
namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Random r = new Random();
            Individuo padre = new Individuo(7,r);//Iniciamos con un numero de Genes de Herencia hacia el Individuo "PADRE"
            Individuo madre = new Individuo(7,r);//Iniciamos con un numero de Genes de Herencia hacia el Individuo "MADRE"
            Console.WriteLine(madre.ToString());//impresion de resultado de Madre
            Console.WriteLine(padre.ToString());//impresion de resultado de Padre
           
            madre.devolver(madre, padre, 7);//Mandamos a llamr la cruza por PUNTO
            Console.ReadLine(); //Pause  
        }
    }
}
