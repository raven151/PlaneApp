using System;
using System.Collections.Generic;
using System.Text;

namespace IR97J8
{
    class Squadron
    {//Szakaszok osztály
        string squadName;//Szakasz neve
        string planeName;//Repülőgép neve
        
        string planeNumber;//Adott szakaszban adott repülőgépek száma

        //Példányosítás
        public Squadron(string squadName, string planename,  string planeNumber)
        {
            this.squadName = squadName;
            this.planeName = planename;
            this.planeNumber = planeNumber;
        }
        //Getter függvények.
        public string getSquadName()
        {
            return squadName;
        }
         public string getPlaneName()
        {
            return planeName;
        }
     
         public string getPlaneNumber()
        {
            return planeNumber;
        }

       
    }
}
