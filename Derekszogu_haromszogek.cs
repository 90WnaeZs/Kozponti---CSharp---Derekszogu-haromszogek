using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszogek
{
    public partial class Derekszogu_haromszogek : Form
    {
        List<DHaromszog> derekszogu = new List<DHaromszog>();
        public Derekszogu_haromszogek()
        {
            InitializeComponent();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "";
                string sorszam = "";
                int counter = 0;

                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    filePath = ofd.FileName;
                }
                
                if(!String.IsNullOrEmpty(filePath))
                {
                    derekszogu.Clear();

                    list_Derekszogu.Items.Clear();
                    list_Hiba.Items.Clear();
                    list_Kivalasztott.Items.Clear();

                    var fileOpen = File.OpenRead(filePath);

                    using (StreamReader SR = new StreamReader(fileOpen, Encoding.UTF8))
                    {
                        while (SR.ReadLine() != null)
                        {
                            try
                            {
                                counter++;

                                string s = SR.ReadLine();
                                string[] oldalak = s.Split(' ');

                                DHaromszog dh = new DHaromszog(s, counter);

                                derekszogu.Add(dh);

                                sorszam = dh.SorSzama.ToString();

                                list_Derekszogu.Items.Add(sorszam + ". sor: a="+dh.a+" b="+dh.b+" c="+dh.c);
                            }
                            catch (Exception err)
                            {
                                list_Hiba.Items.Add(sorszam + ". sor: " + err.Message);
                            }
                        }
                    }
                    counter = 0;
                }
            }
            catch (Exception olvasas_err)
            {
                MessageBox.Show(olvasas_err.Message);
            }
            
        }

        private void list_Derekszogu_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_Kivalasztott.Items.Clear();

            string str_a = "";
            string str_b = "";
            string str_c = "";

            double a = 0;
            double b = 0;
            double c = 0;
            int sorszam = 0;

            string[] sorsz = list_Derekszogu.SelectedItem.ToString().Split('.');
            sorszam = Convert.ToInt32(sorsz[0]);

            string[] tomb1 = list_Derekszogu.SelectedItem.ToString().Split(new string[] { "=" }, StringSplitOptions.None);

            str_a = tomb1[1].Replace("b","");
            a = Convert.ToDouble(str_a.Replace(" ", ""));

            str_b = tomb1[2].Replace("c", "");
            b = Convert.ToDouble(str_b.Replace(" ", ""));

            str_c = tomb1[3];
            c = Convert.ToDouble(str_c.Replace(" ", ""));

            DHaromszog dh = new DHaromszog(a+" "+b+" "+c, sorszam);

            list_Kivalasztott.Items.Add("Kerület = "+dh.Kerulet.ToString());
            list_Kivalasztott.Items.Add("Terület = " + dh.Terulet.ToString());
        }
    }
}
