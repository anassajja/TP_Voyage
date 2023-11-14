using System;

namespace ConsoleApp2
{
    class Bus
    {
        public string Immatriculation { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }

        public Bus(string immatriculation, string marque, string modele)
        {
            Immatriculation = immatriculation;
            Marque = marque;
            Modele = modele;
        }

        public override string ToString()
        {
            return $"Immatriculation : {Immatriculation}\t Marque : {Marque}\t Modele : {Modele}";
        }
    }
}
