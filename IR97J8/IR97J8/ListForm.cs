using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IR97J8
{
    public partial class ListForm : Form
    {
        List<Plane> Planes = new List<Plane>();//Repülőgépek tárolására lista
        List<Squadron> Squads = new List<Squadron>();//Repülőgép szakaszok/ hadosztályok tárolására  lista
        void Start()
        {//Start metódus mely segítségével a program indulásakor beolvassuk a két txt állományból az adatokat majd azokat alap értékre állítjuk.



            List<string> Plines = DataCenter.ReadLinesFromFile("D:\\tanulmanyok\\csharp\\beadando\\IR97J8\\PlaneData.txt");

            for (int i = 0; i < Plines.Count(); i++)
            {
                string line = Plines[i];
                Planes.Add(DataCenter.ReadPlane(line));



            }
            for (int i = 0; i < Planes.Count(); i++)
            {
                PlaneListBox.Items.Add(Planes[i].getName());


            }
            PlaneListBox.SelectedIndex = 0;

            List<string> Slines = DataCenter.ReadLinesFromFile("D:\\tanulmanyok\\csharp\\beadando\\IR97J8\\SquadronData.txt");

            for (int i = 0; i < Slines.Count(); i++)
            {
                string line = Slines[i];
                Squads.Add(DataCenter.ReadSquadron(line));



            }
            for (int i = 0; i < Squads.Count(); i++)
            {
                for (int j = 0; j < Squads.Count(); j++)
                {

                    if (!(SquadListBox.Items.Contains(Squads[i].getSquadName())))
                    {
                        SquadListBox.Items.Add(Squads[i].getSquadName());

                    }

                }



                SquadListBox.SelectedIndex = 0;



            }
        }


        public ListForm()
        {
            InitializeComponent();
            Start();
        }

        private void PlaneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {//Amennyiben változik a comboboxban kiválasztott elem átírja az alatta írt repülőgép adatokat, illetve frissíti a nézetet. 
            int selected = PlaneListBox.SelectedIndex;
            

            IPName.Text = Planes[selected].getName();
            IPType.Text = Planes[selected].getType();
            IPLength.Text = Planes[selected].getLength() + " Méter";
            IPHeight.Text = Planes[selected].getHeight() + " Méter";
            IPCrew.Text = Planes[selected].getCrew() + " Fő";
            IPWingspan.Text = Planes[selected].getWingspan() + " Méter";

            Updates();
            
            
        }

        private void SquadListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Amennyiben változik a comboboxban kiválasztott elem átírja az alatta írt nevet, illetve frissíti a nézetet. 


            LSName.Text = SquadListBox.Text;

            Updates();
            

        }


        private void BAdd_Click(object sender, EventArgs e)
        {//Új repülőgép hozzáadására szolgáló windows formot nyit.
            AddForm addNew = new AddForm();
            addNew.ShowDialog();
        }

        
        private void BSquAdd_Click(object sender, EventArgs e)
        {//Új szakasz hozzáadására szolgáló windows formot nyit.
            AddSquadForm addNewSquad = new AddSquadForm();
            addNewSquad.ShowDialog();
        }

        private void Updates()
        {//Nézet frissítésére alkalmas függvény
            //Egy ciklussal bejárjuk a Squads listát és amennyiben a Squadson belüli gép neve egyezik a repülőgép nevével , kiírjuk hány ilyen típusú gép található a szakaszban.
            for (int i = 0; i < Squads.Count(); i++)
            {

                if (SquadListBox.Text == Squads[i].getSquadName() && PlaneListBox.Text == Squads[i].getPlaneName())
                {

                    ISPNumber.Text = Squads[i].getPlaneNumber() + " Darab";

                    break;
                }
                else//amennyiben nem találunk ilyen adatot kiírjuk hogy nincs
                {
                    ISPNumber.Text = "A szakasz nem tartalmaz ilyen típusú repülőgépet!";
                }
            }

        }

        private void UpdateCB()
        {//adatok újra feltöltésére alkalmas függvény

            //Kiürítjük a ComboBoxokat és a listáinkat.
            PlaneListBox.Items.Clear();
            Planes.Clear();
            Squads.Clear();
            SquadListBox.Items.Clear();

            //Újfent bevesszük a txt fileokból a az adatokat

            //Repülögép adatok bevétele
            List<string> Plines = DataCenter.ReadLinesFromFile("D:\\tanulmanyok\\csharp\\beadando\\IR97J8\\PlaneData.txt");

            for (int i = 0; i < Plines.Count(); i++)
            {
                string line = Plines[i];
                Planes.Add(DataCenter.ReadPlane(line));



            }
            for (int i = 0; i < Planes.Count(); i++)
            {
                PlaneListBox.Items.Add(Planes[i].getName());


            }
            PlaneListBox.SelectedIndex = 0;

            //Szakasz adatok bevétele
            List<string> Slines = DataCenter.ReadLinesFromFile("D:\\tanulmanyok\\csharp\\beadando\\IR97J8\\SquadronData.txt");

            for (int i = 0; i < Slines.Count(); i++)
            {
                string line = Slines[i];
                Squads.Add(DataCenter.ReadSquadron(line));



            }
            for (int i = 0; i < Squads.Count(); i++)
            {
                for (int j = 0; j < Squads.Count(); j++)
                {

                    if (!(SquadListBox.Items.Contains(Squads[i].getSquadName())))
                    {
                        SquadListBox.Items.Add(Squads[i].getSquadName());

                    }

                }
            }
            SquadListBox.SelectedIndex = 0;


        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            UpdateCB();//A frissítés gombra kattintva újra bevesszük az adatainkat és alap helyzetbe állítjuk a programot. Erre azért van szükség mert új adat bevitelekor a program automatikusan nem frissül.
                       
                       }
    }
}

