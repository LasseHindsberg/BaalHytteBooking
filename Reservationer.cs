using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaalHytteBooking
{
    public class Reservationer
    {
        int ID;
        List<int> _tidspunkter { get; set; }
        Dictionary<int, Reservation> _AllReservations { get; set; }

        public Reservationer(int id)
        {
            _AllReservations = new Dictionary<int, Reservation>();
            _tidspunkter = new List<int>() { 12, 14, 16, 18, 20 };
            ID = id;
        }
        // Opgave 6 - Opret CRUD Functionality
        public void RegistrerReservation(Reservation reservation)
        {
            _AllReservations.Add(reservation.ID, reservation);

            Console.WriteLine("Reservationen er blevet tilføjet");
        }

        public void PrintReservationer()
        {
            Console.WriteLine("Prøver at printe reservationer... \n \n");
            if (_AllReservations == null)
                return;

            foreach (var reservation in _AllReservations)
            {
                Console.WriteLine(reservation.ToString());
            }
        }
        public void FjernReservation(Reservation reservation)
        {
            _AllReservations.Remove(reservation.ID);
            Console.WriteLine($"Reservation med ID: {reservation.ID} er hermed slettet");
        }

        // Assignment 7: Valideringsfunktioner
        public int AntalReservationer(Boernegruppe bGruppe)
        {
            // r = gemte Reservationer forkortet ned

            // Instance field for hvor mange reservationer der matcher, starter på 0
            int count = 0;
            foreach(var r in _AllReservations.Values)
            {
                // Hvis der er match tilføjer vi et til "count"
                if (r.Boernegruppe == bGruppe)
                {
                    count++;
                }
            }
            // endelige antal reservationer bliver returned som vores value
            return count;
        }

        public bool ReservationLedig(Reservation reservation)
        {
            // r = Reservationer forkortet ned
            // koden tjekker om r (gemte reservationer)'s tidspunkt ikke er det samme som den reservation brugeren vil oprette.

            foreach (var r in _AllReservations.Values)
            {
                // Hvis tidspunkt matcher returner vi false, da tiden ikke er ledig
                if (r.Tidspunkt == reservation.Tidspunkt)
                {
                    return false;
                }
            }
            // else hvis tiden er ledig, returner vi true
            return true;
        }

        public bool ReservationsTidspunktOK(Reservation reservation)
        {

            // overseete at ID skulle være lig med hvilket aar der bliver booket til.
            // To Be Honest tror jeg ikk det her vil virke
            if (reservation.Tidspunkt.Year == ID)
            {
                if (reservation.Tidspunkt.DayOfWeek == DayOfWeek.Thursday)
                {
                    if (_tidspunkter.Contains(reservation.Tidspunkt.Hour))
                    {
                        if (reservation.Tidspunkt.Second == 0)
                        {
                            if (reservation.Tidspunkt.Minute == 0)
                            {
                                if
                                    (reservation.Tidspunkt.Millisecond == 0)
                                {
                                    return true;
                                } else { return false; }
                            } else { return false; }
                        }
                        else { return false; }
                    }
                    else { return false; }

                }
                else { return false; }
            }
            else { return false; }
        } 

    }
}
