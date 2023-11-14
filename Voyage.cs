using System;

namespace ConsoleApp2
{
    class Voyage
    {
        public int NumeroVoyage { get; set; }

        public Chauffeur? Vchauffeur { get; set; }

        public Bus? Vbus { get; set; }

        public DateTime DateVoyage { get; set; }

        public string? VilleDepart { get; set; }

        public string? VilleArrivee { get; set; }

        public int NumberDePlace { get; set; }

        public float PrixBillet { get; set; }

        public Voyage(int numeroVoyage, Chauffeur vchauffeur, Bus vbus, DateTime dateVoyage, string villeDepart, string villeArrivee, int numberDePlace, float prixBillet)
        {
            NumeroVoyage = numeroVoyage;
            Vchauffeur = vchauffeur;
            Vbus = vbus;
            DateVoyage = dateVoyage;
            VilleDepart = villeDepart;
            VilleArrivee = villeArrivee;
            NumberDePlace = numberDePlace;
            PrixBillet = prixBillet;
        }
        
        public override string ToString()
        {
            return $"NumeroVoyage : {NumeroVoyage}\tDateVoyage : {DateVoyage}\tVilleDepart : {VilleDepart}\tVilleArrivee : {VilleArrivee}\tNumverDePlace : {NumberDePlace}\tPrixBillet : {PrixBillet}\tChauffeur : {Vchauffeur}\tBus : {Vbus}\nLa recette du voyage est : {NumberDePlace * PrixBillet}";
        }
    }
}
