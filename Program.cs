namespace Baalhyttebooking
{
    public class Program

    {
        static void Main(string[] args)

        {

            //Opgave 1

            Boernegruppe boernegruppe = new Boernegruppe() { Id = "MS", Name = "Mohammed Syed", Aldersgruppe = "10", AntalDeltagere = 20 };

            Console.WriteLine($"Børnegruppens Id: {boernegruppe.Id}");

            Console.WriteLine($"Børnegruppens Name: {boernegruppe.Name}");

            Console.WriteLine($"Børnegruppens Aldersgruppe: {boernegruppe.Aldersgruppe}");

            Console.WriteLine($"Børnegruppens AntalDeltagere: {boernegruppe.AntalDeltagere}");


            //Opgave 2

            DateTime tids = new DateTime(2020, 06, 10);

            Reservation reservation = new Reservation();

            Reservation reservation1 = new Reservation() { Id = 1, Tidspunkt = tids, boernegruppe = new Boernegruppe() { Id = "MS", Name = "Mohammed Syed", Aldersgruppe = "10", AntalDeltagere = 20 } };
           
            ReservationsListe reservationsListe = new ReservationsListe();

            reservationsListe.AddReservation(reservation1);

            reservationsListe.PrintReservation();

            Console.WriteLine("Hej BoerneGruppe");

            reservationsListe.RemoveReservation(reservation1);

            reservationsListe.PrintReservation();



        }

    }


}