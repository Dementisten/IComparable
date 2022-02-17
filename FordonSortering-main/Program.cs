using System;
using System.Collections.Generic;

namespace exempelComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fordon> fLista = new List<Fordon>();
            fLista.Add(new Fordon("Volvo","V90", 2019));
            fLista.Add(new Fordon("SAAB","9-5", 2009));
            fLista.Add(new Fordon("Volkswagen","Passat", 2012));
            fLista.Add(new Fordon("Skoda","Fabia", 2015));
            
            fLista.Sort();

            foreach(Fordon f in fLista) {
                Console.WriteLine(f);
            }

            
        }
    }
}
