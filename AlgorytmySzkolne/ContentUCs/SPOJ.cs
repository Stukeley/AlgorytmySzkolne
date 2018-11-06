using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
    public partial class SPOJ : Form
    {
        private static string[] Algorytm;

        private static string Przchowalnia = "";

        public SPOJ()
        {
            InitializeComponent();

            try
            {
                Algorytm = File.ReadAllLines("Resources\\AlgorytmySPOJ.txt");
                foreach (string line in Algorytm)
                {
                    Przchowalnia = Przchowalnia + line + "\n";
                }
            }
            catch (FileNotFoundException)//debug only
            {
                MessageBox.Show("Nie ma pliku");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AlgorytmChoiceBox_SelectionChangeCommitted(object sender, EventArgs e)//chyba works, sprawdzić release
        {
            OutputBox.Text = "";
            var content = AlgorytmChoiceBox.GetItemText(AlgorytmChoiceBox.SelectedItem);

            OutputBox.Text = Przchowalnia;

            int j = OutputBox.Text.IndexOf(String.Format("//Name: " + content));
            if (j != -1)
            {
                OutputBox.Text = OutputBox.Text.Remove(0, j);
            }
            j = OutputBox.Text.IndexOf("//end");
            if (j != -1)
            {
                OutputBox.Text = OutputBox.Text.Remove(j, OutputBox.Text.Length - j - 1);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputBox.Text);
        }
    }
}