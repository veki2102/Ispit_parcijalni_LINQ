using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit.Model_LINQ;


namespace Ispit.Konzola_LINQ
{
    internal class Program:Podaci
    {
        static void Main(string[] args)
        {
            var GrupirajPremaBanci = from klijent in ListaKlijenata
                                     where klijent.Stanje >= 1000000
                                     group klijent by klijent.Banka into grupirano
                                     select grupirano;


            foreach (var grupa in GrupirajPremaBanci)
            {
                Console.WriteLine("{0}", grupa.Key + ": ");


                foreach (var klijent in grupa)

                {

                    Console.Write(" " + klijent.Ime + " " + klijent.Prezime + "  ");
                    Console.WriteLine();
                }

            }



            Console.WriteLine();
            Console.WriteLine();
            var IzvjestajMiljunasa = from lk in ListaKlijenata
                                     join lb in ListaBanki
                                     on lk.Banka equals lb.Simbol
                                     where lk.Stanje >= 1000000
                                     select new
                                     {
                                         ImePrezimeKlijent = lk.Ime + " " + lk.Prezime,
                                         PuniNazivBanke = lb.Naziv

                                     };

            foreach (var mil in IzvjestajMiljunasa)
            {
                Console.WriteLine(mil.ImePrezimeKlijent + " je u " + mil.PuniNazivBanke);

            }


        }
    }
}
