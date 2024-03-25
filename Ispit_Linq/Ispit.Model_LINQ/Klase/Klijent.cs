using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model_LINQ.Klase
{
    public class Klijent
    {

        private string _Ime;
        private string _Prezime;
        private double _Stanje;





        public string Ime
        {
            get { return this._Ime; }

            set { this._Ime = value; }

        }

        public string Prezime
        {
            get { return this._Prezime; }

            set { this._Prezime = value; }

        }


        public double Stanje
        {
            get { return this._Stanje; }

            set { this._Stanje = value; }

        }


        public string Banka { get; set; }


    }
}
