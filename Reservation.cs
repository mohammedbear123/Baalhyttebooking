using System;
namespace Baalhyttebooking
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime Tidspunkt { get; set; }

        public Boernegruppe boernegruppe { get; set; }

        public override string ToString()
        {
            return $"GruppeId = " + Id + "Tidspunkt = " + Tidspunkt + "boernegruppe = " + boernegruppe;
        }
    }


}
