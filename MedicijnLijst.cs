using System;
using System.Collections.Generic;
using System.Text;

namespace ZorgAppOop
{
    class MedicijnLijst
    {
        public List<Medicijn> medicijnLijst { get; private set; }
        public MedicijnLijst()
        {
            medicijnLijst = new List<Medicijn>();
            medicijnLijst.Add(new Medicijn(1, "Paracetemol", "", "", ""));
            medicijnLijst.Add(new Medicijn(2, "Asperine", "Omschrijving", "Soort", "Dosering"));
        }
    }

}
