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

        }
        
        //methods
        public void BewerkenPatient()
        {
           
        }


        // Profile gezochtePatient = zorgApp.ZoekPatient("Frank");
        //void: deze methode returned geen waarde
        /*public Profile ZoekPatient(string zoekWaarde) 
        {
            if (zoekWaarde == profile.VoorNaam)
            {
                return profile;
            }
            else if (zoekWaarde == profile.AchterNaam)
            {
                return profile;
            }
            else if (zoekWaarde == profile.Leeftijd) { return profile; }
            else if (zoekWaarde == profile.Gewicht) { return profile; }
            else if (zoekWaarde == profile.Lengte) { return profile; }
            else { return Object.}

            

        }*/


    }
}
