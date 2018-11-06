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

namespace AlgorytmySzkolne.ContentUCs
{
    public partial class SystemyLiczbowe : UserControl
    {
        public AlgorytmyUC algorytmyUC;

        public void SetUC(AlgorytmyUC algorytmyUC)
        {
            this.algorytmyUC = algorytmyUC;
        }

        public void SetResult(string wynik)
        {
            ResultBox.Text = wynik;
        }

        public SystemyLiczbowe()
        {
            InitializeComponent();
        }

        private void SystemyLiczbowe_Load(object sender, EventArgs e)
        {
        }

        private void ObliczButton_Click(object sender, EventArgs e)
        {
            string argument1 = GivenBox.Text;
            string argument2 = TargetBox.Text;
            string argument3 = NumberBox.Text;

            try
            {
                RunAlgorithms.Run(this, argument1, argument2, argument3);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Zbyt duża podstawa systemu liczbowego!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Błąd argumentu/ów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}