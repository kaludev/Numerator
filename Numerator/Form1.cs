using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
namespace Numerator
{
    public partial class Form1 : Form
    {
        List<List<String>> Data = new List<List<String>>();
        bool MoreSettings = false;
        int max = 0;
        List<String> lines = new List<String>();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {

                MoreSettings = true;
            }
            else
            {
                MoreSettings = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MoreSettings)
            {

            }
            else
            {
                for (int i = 0; i < (int)NumberNumerator.Value; i++)
                {
                    Data.Add(new List<String>());
                    Data.ElementAt(i).Add("Broj" + (i + 1).ToString());
                    Console.WriteLine("Broj" + (i + 1).ToString());
                    for (int j = i*(int)Step.Value + (int)PocetniBrojValue.Value ; j <= i + 1 + (int)ZadnjibrojValue.Value - (int)NumberNumerator.Value; j += (int)(Step.Value * NumberNumerator.Value))
                    {
                        Data.ElementAt(i).Add(j.ToString());
                    }
                    if (max < Data[i].Count) max = Data[i].Count;

                }
            }
            for(int i = 0; i < max; i++)
            {
                String line = "";
                for(int j = 0; j < Data.Count; j++)
                {
                    if (Data[j].Count > i)
                    {
                        line += Data[j][i].ToString();
                        if (j != Data.Count - 1) line += "\t";
                    }
                }
                lines.Add(line);
            }
            File.WriteAllLines("output.txt", lines);
            Data.Clear();
            lines.Clear();
        }
    }
}
