using System;
using System.Collections.Generic;
using System.Text;

namespace ZorgAppOop
{
    class Profile
    {
        /*
        public — a public member can be accessed by any class
        private — a private member can only be accessed by code in the same class
        */

        //fields camal case
        //private string voorNaam;
        //private string achterNaam;
        //private int leeftijd;
        //private double gewicht;
        //private double lengte;

        /*public string size;
        public string Size
        {
            public get { return size; }
            private set { size = value; }
        }*/

        //properties pascal case. default op public
        //slaat inkomende variabels op in een field(Set) of haalt ze op uit een field(Get). get - public set - private
        public string VoorNaam { get; private set; }
        public string AchterNaam { get; private set; }
        public int Leeftijd { get; private set; }
        public double Gewicht { get; private set; }
        public double Lengte { get; private set; }

        //constructor
        public Profile()
        {
            
        }
        public Profile(string inputVoorNaam, string inputAchterNaam)
        {
            VoorNaam = inputVoorNaam;
            AchterNaam = inputAchterNaam;
        }
        public Profile(string inputVoorNaam, string inputAchterNaam, int inputLeeftijd, double inputGewicht, double inputLengte)
        {
            VoorNaam = inputVoorNaam;
            AchterNaam = inputAchterNaam;
            Leeftijd = inputLeeftijd;
            Gewicht = inputGewicht;
            Lengte = inputLengte;
        }

        //methods

    }
}
