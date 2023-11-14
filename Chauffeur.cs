using System;

namespace ConsoleApp2
{
    class Chauffeur
    {
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Chauffeur(string cin, string nom, string prenom)
        {
            Cin = cin;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return $"{Cin}\t{Nom}\t{Prenom}";
        }


        
    }
}