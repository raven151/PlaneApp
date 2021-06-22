using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IR97J8
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            this.Close();//Bezárjuk az ablakot
        }

        private void BSave_Click(object sender, EventArgs e)
        {//A mentés gombra kattintva
            string line = "";//Egy üres sort hozunk létre később ebből áll majd a mentett adat.
            string name = TBName.Text;
            string type = TBType.Text;
            string length = TBLength.Text;
            string height = TBHeight.Text;
            string crew = TBCrew.Text;
            string wingspan = TBWingspan.Text;
            //Változókban eltároljuk a mezők tartalmát.
            line = name + ";" + type + ";" + length + ";" + height + ";" + crew + ";" + wingspan;//Egy sort alkotunk belőlük és ;-el elválasztva eltároljuk egy sor változóban hogy a mentett adatok később megkülönböztethetők legyenek.

            DataCenter.TextWriterAsync(line);//A fileba beírjuk a sort.
            LSaved.Visible = true;//Megjelenítjük az elmentve feliratot.

            var t = new Timer();
            t.Interval = 3000; //A program 3 másodpercig vár
            t.Tick += (s, e) =>
            {
                LSaved.Hide();//eltüntetjük a feliratot
                t.Stop();//Megállítjuk az időzítőt
            };
            t.Start();

            TBName.Text = "";
            TBType.Text = "";
            TBLength.Text = "";
            TBHeight.Text = "";
            TBCrew.Text = "";
            TBWingspan.Text = "";

            //Alaphelyzetbe állítjuk a beviteli mezőket.
        }
    }
}
