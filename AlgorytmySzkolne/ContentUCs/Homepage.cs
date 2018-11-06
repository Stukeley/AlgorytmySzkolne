using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorytmySzkolne.ContentUCs;
using AlgorytmySzkolne;

namespace AlgorytmySzkolne.ContentUCs
{
    public partial class Homepage : UserControl
    {
        private AlgorytmyUC algorytmyUC;//ale ja jestem kurwa mądry

        public void SetUC(AlgorytmyUC algorytmyUC)//o bosz ale ja jestem mądry
        {
            this.algorytmyUC = algorytmyUC;
        }

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            if (AlgorytmyUC.PreviousList.Count == 0)
            {
                AlgorytmyUC.PreviousList.Add(Nazwy.strGlowna, this);
            }
        }

        private void KlasyczneButton_Click(object sender, EventArgs e)
        {
            algorytmyUC.SetTitle(Nazwy.strKlasyczne);
            var klasyczne = new Klasyczne();
            AlgorytmyUC.AddToList(Nazwy.strKlasyczne, klasyczne);
            klasyczne.SetUC(this.algorytmyUC);
            algorytmyUC.SetPanel(klasyczne);
        }

        private void ZachlanneButton_Click(object sender, EventArgs e)
        {
            algorytmyUC.SetTitle(Nazwy.strZachlanne);
            var zachlanne = new Zachlanne();
            AlgorytmyUC.AddToList(Nazwy.strZachlanne, zachlanne);
            zachlanne.SetUC(this.algorytmyUC);
            algorytmyUC.SetPanel(zachlanne);
        }

        private void SystemyButton_Click(object sender, EventArgs e)
        {
            algorytmyUC.SetTitle(Nazwy.strSystemy);
            var systemy = new SystemyLiczbowe();
            AlgorytmyUC.AddToList(Nazwy.strSystemy, systemy);
            systemy.SetUC(this.algorytmyUC);
            algorytmyUC.SetPanel(systemy);
        }

        private void ONPButton_Click(object sender, EventArgs e)
        {
            algorytmyUC.SetTitle(Nazwy.strONP);
            var ONP = new ONPUC();
            AlgorytmyUC.AddToList(Nazwy.strONP, ONP);
            ONP.SetUC(this.algorytmyUC);
            algorytmyUC.SetPanel(ONP);
        }

        private void ProjektyButton_Click(object sender, EventArgs e)
        {
            algorytmyUC.SetTitle(Nazwy.strProjekty);
            var projekty = new Projekty();
            AlgorytmyUC.AddToList(Nazwy.strProjekty, projekty);
            //projekty.SetUC(this.algorytmyUC);//potrzebne??
            algorytmyUC.SetPanel(projekty);
        }

        private void SPOJButton_Click(object sender, EventArgs e)
        {
            var spoj = new SPOJ();
            spoj.Show();
        }
    }
}