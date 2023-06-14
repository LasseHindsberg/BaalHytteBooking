namespace BaalHytteBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAssignment 1: opret ny Boernegruppe og print i console");
            Boernegruppe BG1 = new Boernegruppe("1", "Baalhytte 1", "16-18", 24);
            Console.WriteLine(BG1);

            Console.WriteLine("\nAssignment 2: Opret ny Reservation og print i console");
            Reservation R1 = new Reservation(1, DateTime.Now, BG1);
            Console.WriteLine(R1);

            Reservationer reservationer = new Reservationer(1);
            Console.WriteLine("\nAssignment 3: opret en Dictionary til Reservationer");
            // tilføj reservation til Dictionary
            reservationer.RegistrerReservation(R1);
            Console.WriteLine("\nDictionary Oprettet. \n");
            // print list of registered reservations
            reservationer.PrintReservationer();

            Console.WriteLine("\nAssignment 6: Tilføj CRUD Functionality\n");
            // tilføj endnu reservation for at tjekke om ForEach loop virker
            reservationer.RegistrerReservation(new Reservation(2, DateTime.Now, BG1));

            // print list of registered reservations
            reservationer.PrintReservationer();

            //prøv at slette en reservation
            reservationer.FjernReservation(R1);
            
            // print nye liste, med element slettet
            reservationer.PrintReservationer();

        }
    }
}