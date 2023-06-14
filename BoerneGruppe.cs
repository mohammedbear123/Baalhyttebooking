using System;
namespace Baalhyttebooking
{
    public class Boernegruppe
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Aldersgruppe { get; set; }

        public int AntalDeltagere { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Aldersgruppe: {Aldersgruppe}, Antaldeltagere: {AntalDeltagere}";
        }
    }
}
