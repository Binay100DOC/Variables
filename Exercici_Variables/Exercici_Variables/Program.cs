using System;
using System.Collections.Generic;

namespace Exercici_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Binay";
            string cognom1 = "Timilsina";
            string cognom2 = "Dhungana";

            int dia = 6;
            int mes = 9;
            int any = 1995;

            int anyInicialDeTraspas = 1948;
            int anysDeTraspas = 0;

            Console.WriteLine("///////////////Fase 1///////////////\n{0} {1} {2}",cognom1,cognom2,nom);
            Console.WriteLine("{0}/{1}/{2}\n", dia, mes, any);
            Console.ReadKey();

            for(int i = anyInicialDeTraspas; i<any; i+=4)
            {
                anysDeTraspas += 1;
            }
            Console.WriteLine("///////////////Fase 2///////////////\nHay {0} años de traspaso entre la fecha 1948 hasta 1995\n", anysDeTraspas);
            Console.ReadKey();

            var anysDeTraspasEnString = new List<int>();
            bool esAnyDeTrapas;
            
            for(int i = 1948; i<any;i+= 4)
            {
                anysDeTraspasEnString.Add(i);
            }

            Console.WriteLine("///////////////Fase 3///////////////");

            string esAnyDeTraspasSi = ("Mi año de nacimiento 1995 es un año de Traspaso\n");
            string esAnyDeTraspasNo = ("Mi año de nacimiento 1995 no es un año de Traspaso\n");

            foreach (object j in anysDeTraspasEnString)
            {
                Console.WriteLine(j);
            }

            if (anysDeTraspasEnString.Contains(1995))
            {
                esAnyDeTrapas = true;
                Console.WriteLine(esAnyDeTraspasSi);
            }
            else
            {
                esAnyDeTrapas = false;
                Console.WriteLine(esAnyDeTraspasNo);
            }

            Console.ReadKey();
            Console.WriteLine("///////////////Fase 4///////////////");

            Console.WriteLine("Mi nombre es {0} {1} {2}",nom,cognom1,cognom2);
            Console.WriteLine("Nací el {0}/{1}/{2}", dia, mes, any);
            Console.WriteLine(esAnyDeTraspasNo);
            Console.ReadKey();

        }
    }
}
