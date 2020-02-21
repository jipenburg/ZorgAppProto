using System;
using System.Collections.Generic;
using System.Text;

namespace ZorgAppOop
{
    class ProfileList
    {
        private List<Profile> profileList;
        /*profileList type of List<Profile>
          I=> Profile type of Class
             I=> VoorNaam type of String
                I=> "Frank" value
        */
        public ProfileList() 
        {
            profileList = new List<Profile>();
            profileList.Add(new Profile("Frank", "Krijnen", 26, 88.00, 1.80));
        }
  

    }
}
