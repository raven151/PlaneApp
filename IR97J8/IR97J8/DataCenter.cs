using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IR97J8
{
    class DataCenter
    {

        

        //Beolvassuk egy adott file összes sorát majd a kapott értéket a programnak adjuk.
        public static List<string> ReadLinesFromFile(string fileName)
        {
            List<string> lines = new List<string>();

            StreamReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();

            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();



            return lines;
        }

        //Függvény a repülőgépek beolvasására
        public static Plane ReadPlane(string line)
        {
            string[] record = line.Split(";");//mivel a fileban ;-vel vannak elválasztva  az adatok igy egy tömbbe azok mentén szétszedjük a sorokat.
           
                string name = record[0];//Első adat egy név
                string type = record[1];//Második a gép típusa
                string length = record[2];//Harmadik a gép hossza
                string height = record[3];//Negyedik a gép magassága
                string crew =record[4];//Ötödik a legénység száma
                string wingspan = record[5];//Hatodik a szárnyfesztávolság
                Plane newPlane = new Plane(name, type, length, height, crew, wingspan);//Létrehozunk egy új repülőgép példányt a beolvasott adatokkal
            
           
            
           
            

            return newPlane;//Ezt a példányt a programnak visszaadjuk
        }

        //Függvény repülőgép szakaszok beolvasására
        public static Squadron ReadSquadron(string line)
        {
            string[] record = line.Split(";");//mivel a fileban ;-vel vannak elválasztva  az adatok igy egy tömbbe azok mentén szétszedjük a sorokat.

            string SName = record[0];//Első adat a szakasz neve
            string PName = record[1];//Második az adott repülőgép neve
            string PNumber = record[2];//Harmadik hogy a szakasz adott repülőgépből hányat tartalmaz.
            
            
            Squadron newSquad = new Squadron(SName, PName , PNumber);//A beolvasott adatokból egy új szakasz példányt hozunk létre






            return newSquad;//Ezt a példányt visszaadjuk a programnak
        }
        //Függvény a repülőgépek állományába való beírásra
        public static async System.Threading.Tasks.Task TextWriterAsync(string line)
        {

            
                

                using StreamWriter file = new StreamWriter("D:\\tanulmanyok\\csharp\\beadando\\IR97J8\\PlaneData.txt", append: true);
                await file.WriteLineAsync(line);
            
            }
        //Függvény a repülőgép szakaszok állományába való beírásra
        public static async System.Threading.Tasks.Task TextWriterSquadAsync(string line)
        {


            

            using StreamWriter file = new StreamWriter("D:\\tanulmanyok\\csharp\\beadando\\IR97J8\\SquadronData.txt", append: true);
            await file.WriteLineAsync(line);

        }
    }
        
    }

