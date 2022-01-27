using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignent_Speelkaarten
{
    internal class Sofa
    {

        public Sofa(string naam, string serienummer, Kleur kleur=Kleur.Rood, Grondstof grondstof=Grondstof.Leder)
        {
            Naam = naam;
            Serienummer = serienummer;
            Kleur = kleur;
            Grondstof = grondstof;

        }

        public Sofa(
            double gewichtInKilo 
            ,double lengte
            ,double breedte
            ,double hoogte
            ,double zitDiepte 
            ,string naam
            ,string serienummer
            , Kleur kleur = Kleur.Rood
            , Grondstof grondstof = Grondstof.Sky
            ): this(naam, serienummer, kleur,grondstof)
        {
            GewichtInKilo = gewichtInKilo;
            Lengte = lengte;    
            Breedte = breedte;
            Hoogte = hoogte;
            ZitDiepte = zitDiepte;
            
        }
        public double GewichtInKilo { get; set; }
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public double Hoogte { get; set; }
        public double ZitDiepte { get; set; }
        public string Naam { get; set; }
        public string Serienummer { get; set; }

        public Grondstof Grondstof { get; set; }

        public Kleur Kleur { get; set; } 




    }

    public enum Kleur
    {
        None = 0,
        Rood,
        Blauw,
        Geel,
        Zwart,
        Wit 
    }

    public enum Grondstof
    {
        None=0,
        Stoffen,
        Leder,
        Nylon,
        Sky,
        Andere

    }
}
