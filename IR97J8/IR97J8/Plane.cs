using System;
using System.Collections.Generic;
using System.Text;

namespace IR97J8
{//Repülőgép osztály, ennek segítségével hozunk létre repülőgépet. A programban egy repülőgépnek 6 adattal kell rendelkeznie.
    class Plane
    {
        string name;//Névvel
        string type;//Típussal
        string length;//Hosszúsággal
        string height;//Magassággal
        string crew;//Személyzet létszámával
        string wingspan;//Szárnyfesztávolsággal


        //Példányosítás
        public Plane(string name, string type, string length, string height, string crew, string wingspan)
        {
            this.name = name;
            this.type = type;
            this.length = length;
            this.height = height;
            this.crew = crew;
            this.wingspan = wingspan;
        }

        //Getter függvények.
        public string getName()
        {
            return this.name;
        }
        public string getType()
        {
            return this.type;
        }
        public string getLength()
        {
            return this.length;
        }
        public string getHeight()
        {
            return this.height;
        }
        public string getCrew()
        {
            return this.crew;
        }
        public string getWingspan()
        {
            return this.wingspan;
        }



    }
}
