using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaalHytteBooking
{
    public class Reservation
    {
        int _ID;
        DateTime _Tidspunkt;
        Boernegruppe _Boernegruppe;

        public Reservation(int ID, DateTime Tidspunkt, Boernegruppe Boernegruppe)
        {
            _ID = ID;
            _Tidspunkt = Tidspunkt;
            _Boernegruppe = Boernegruppe;
        }
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public DateTime Tidspunkt
        {
            get { return _Tidspunkt; }
            set { _Tidspunkt = value; }
        }
        public Boernegruppe Boernegruppe
        {
            get { return _Boernegruppe; }
            set { _Boernegruppe = value; }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Tidspunkt: {Tidspunkt}, Boernegruppe: {Boernegruppe}";
        }

    }
}
