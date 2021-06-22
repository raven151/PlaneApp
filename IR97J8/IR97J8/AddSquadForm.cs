using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IR97J8
{
    public partial class AddSquadForm : Form
    {
        List<Plane> Planes = new List<Plane>();//csinálunk egy gépek listát hogy legördülő menüből választhatóka legyenek a repülő gépek.
        void Start()
        {

            List<string> Plines = DataCenter.ReadLinesFromFile("D:\\tanulmanyok\\csharp\\beadando\\IR97J8\\PlaneData.txt");//Beolvassuk a gépeket a fileból

            for (int i = 0; i < Plines.Count(); i++)
            {
                string line = Plines[i];
                Planes.Add(DataCenter.ReadPlane(line));



            }
            for (int i = 0; i < Planes.Count(); i++)
            {
                CBPName.Items.Add(Planes[i].getName());


            }

            CBPName.SelectedIndex = 0;

        }
        public AddSquadForm()
        {
            InitializeComponent();
            Start();
        }

        private void LSquadron_Click(object sender, EventArgs e)
        {

        }
        //Mentés gombnyomásra
        private void BAdd_Click(object sender, EventArgs e)
        {
            string line = "";//Létrehozunk egy üres szöveget.
            string name = TBName.Text;
            string PName = CBPName.Text;
            string SNumber = TBNumber.Text;
            //Beolvassuk a beadott adatokat
            line = name + ";" + PName + ";" + SNumber; // Egy sorrá illesztjük őket és ;-vel elválasztjuk hogy a gép lássa hogy hol választodnak el.

            DataCenter.TextWriterSquadAsync(line);//Beírjuk a file végére sortöréssel
            LSaved.Visible = true;//Az elmentve feliratot megjelenítjük

            var t = new Timer();
            t.Interval = 3000; // 3 másodpercig vár
            t.Tick += (s, e) =>
            {
                LSaved.Hide();//A feliratot eltüntetjuk az idő eltelte után
                t.Stop();//leállítjuk az időzítőt.
            };
            t.Start();

            TBName.Text = "";
            CBPName.Text = Planes[0].getName();
            TBNumber.Text = "";
            //A mezőket alaphelyzetbe állítjuk.
            
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            this.Close();//Bezárjuk az ablakot
        }
    }
}
