using System;
using System.Collections.Generic;
using System.Text;

namespace ZorgAppOop
{
    class ProfileList
    {
        //new ProfileList();
        //class zorgapp: EditProfile();
        public List<Profile> profileList { get; private set; }
        /*profileList Object #foreach number 1
            I=>profileList type of List<Profile> #foreach number 1
                    I=> Profile type of Class #foreach number 1
                            I=> VoorNaam type of String #foreach number 2
                                      I=> "Frank" type of value
        */
        public ProfileList() 
        {
            profileList = new List<Profile>();
            profileList.Add(new Profile(1, "Frank", "Krijnen", 26, 65.15, 1.80));
            profileList.Add(new Profile(2, "Joel", "Ipenburg", 27, 83.64, 1.88));
        }
       

    }
}
