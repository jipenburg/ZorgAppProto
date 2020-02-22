using System;
using System.Collections.Generic;
using System.Text;


namespace ZorgAppOop
{
    class ZorgApp
    {
        //variabels
        private ProfileList profileList;
        

        //constructor. voert automatisch uit na aanroep met "new ZorgApp()".
        public ZorgApp()
        {
            profileList = new ProfileList();
            DisplayMenu();

        }
        
        //methods
        public void BewerkenPatient()
        {
           
        }
        public void DisplayMenu()
        {
            Console.WriteLine("Welkom in het menu");
            Console.WriteLine($"Maak een keuze: \n1) Zoeken patient. \n2) Bewerken patientgegevens.");
            var keuze = Console.ReadLine();
            if (keuze == "1")
            {
                Console.Clear();
                Console.WriteLine("Zoek op:");
                var searchValue = Console.ReadLine();
                var match = SearchPatient(searchValue, out Profile classTypeOut);
                if (match == true) 
                {
                    Console.Clear();
                    Console.WriteLine(ProfileToString(classTypeOut));

                }
            }
            else if (keuze == "2") 
            { 

            }
            else
            {
                return;
            }

        }


        // Profile gezochtePatient = zorgApp.ZoekPatient("Frank");
        //void: deze methode returned geen waarde
        //SearchPatient: vergelijkt seachValue met classType.Property van profileList.profileList
        public bool SearchPatient(string searchValue, out Profile classTypeOut) 
        {
            //string searchValue = "Ipenburg"

            foreach (Profile classType in profileList.profileList)
            {
                if (classType.VoorNaam == searchValue || 
                    classType.AchterNaam == searchValue || 
                    classType.Leeftijd.ToString() == searchValue ||
                    classType.Gewicht.ToString() == searchValue ||
                    classType.Lengte.ToString() == searchValue) 
                {
                  classTypeOut = classType;
                  return true;
                } 

            }
            classTypeOut = null;
            return false;
        }
        //return de waardes van gevonden profiel zien in een string
        public string ProfileToString(Profile profile) 
        {
            return $"Voornaam: {profile.VoorNaam}\nAchternaam: {profile.AchterNaam}\nLeeftijd: {profile.Leeftijd}\nGewicht {profile.Gewicht}\nLengte: {profile.Lengte}";

        }
       
    }
}
