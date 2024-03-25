using Ispit.Model_LINQ.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model_LINQ
{
    public class Podaci
    {
        public static List<Banka> ListaBanki = new List<Banka>()
    {
       new Banka() {Simbol = "PBZ", Naziv = "Privredna banka Zagreb" },
       new Banka() {Simbol = "ERSTE", Naziv = "Erste banka" },
       new Banka() {Simbol = "HPB", Naziv = "Hrvatska poštanska banka" }



    };



        public static List<Klijent> ListaKlijenata = new List<Klijent>()
    {
        new Klijent() {Ime="Robert", Prezime="Prosinečki",Stanje=30000,Banka="PBZ"},
        new Klijent() {Ime="Davor", Prezime="Šuker",Stanje=150000,Banka="PBZ"},
        new Klijent() {Ime="Dražen", Prezime="Ladić",Stanje=10000,Banka="ERSTE"},
        new Klijent() {Ime="Zvonimir", Prezime="Boban",Stanje=5000000,Banka="ERSTE"},
        new Klijent() {Ime="Robert", Prezime="Jarni",Stanje=15000,Banka="HPB"},
        new Klijent() {Ime="Aljoša", Prezime="Asanović",Stanje=250000,Banka="HPB"},
        new Klijent() {Ime="Slaven", Prezime="Bilić",Stanje=2000000,Banka="PBZ"},
        new Klijent() {Ime="Luka", Prezime="Modrić",Stanje=250000000,Banka="HPB"},
        new Klijent() {Ime="Zlatko", Prezime="Dalić",Stanje=5000000,Banka="HPB"},
        new Klijent() {Ime="Niko", Prezime="Kovač",Stanje=500000,Banka="PBZ"},


    };

    }
}
