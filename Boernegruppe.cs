using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaalHytteBooking
{
    public class Boernegruppe
    {
        string _ID;
        string _Navn;
        string _Aldersgruppe;
        int _AntalDeltagere;


        // Assignment 12: Indfør Enumeration type
        // enum _Aldersgruppe { Ung, Teenager, Voksen, Ældre }
        public Boernegruppe(string ID, string Navn, string Aldersgruppe, int AntalDeltagere)
        {
            _ID = ID;
            _Navn = Navn;
            _Aldersgruppe = Aldersgruppe;
            _AntalDeltagere = AntalDeltagere;
        }
        
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Navn
        {
            get { return _Navn;  }
            set { _Navn = value; }
        }
        public string Aldersgruppe
        {
            get { return _Aldersgruppe; }
            set { _Aldersgruppe = value; }
        }
        public int AntalDeltagere
        {
            get { return _AntalDeltagere; }
            set { _AntalDeltagere = value; }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Navn: {Navn}, Aldersgruppe: {Aldersgruppe}, Antal Deltagere: {AntalDeltagere}";
        }
    }
}
