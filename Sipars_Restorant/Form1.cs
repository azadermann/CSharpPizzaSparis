using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipars_Restorant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SiparisButton.Enabled = false;
        }
        public static string pizaboy, pizzatur, icecek,masano,adet;


        
        private void button1_Click(object sender, EventArgs e)
        {
            pizaboy = PizzaBoyCombo.Text;
            pizzatur = PizzaTurCombo.Text;
            icecek = IcecekCombo.Text;
            masano = MasaNotext.Text;
            adet = AdetCombo.Text;

            SiparisButton.Enabled = true;

            Form2 frm2 = new Form2();

            if (PizzaBoyCombo.SelectedItem.ToString() == "Küçük")
            {
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 35 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 40 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 45 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 35 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 40 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 45 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 35 + 4).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 40 + 4).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 45 + 4).ToString();
                    }
                }
               
                
                
            }
            else if (PizzaBoyCombo.SelectedItem.ToString()=="Orta")
            {
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 45 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 50 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 52 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 45 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 50 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 52 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 45 + 4).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 50 + 4).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 52 + 4).ToString();
                    }
                }

            }
            else if (PizzaBoyCombo.SelectedItem.ToString() == "Büyük")
            {
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 50+ 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 55 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Kola")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 56 + 4.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 50 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 55 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Ayran")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 56 + 3.5).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Karışık")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 50 + 4).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Sucuklu")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 55 + 4).ToString();
                    }
                }
                if (PizzaTurCombo.SelectedItem.ToString() == "Mantarlı")
                {
                    if (IcecekCombo.SelectedItem.ToString() == "Fanta")
                    {
                        Fiyatlabel.Text = (double.Parse(AdetCombo.Text) * 56 + 4).ToString();
                    }
                }

            }
            

        }

        private void SiparisButton_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.dataGridView1.Rows.Add(MasaNotext.Text, PizzaBoyCombo.Text, PizzaTurCombo.Text, AdetCombo.Text, IcecekCombo.Text);
            frm2.Show();
            MasaNotext.Clear();
            PizzaBoyCombo.Text = " ";
            PizzaTurCombo.Text = " ";
            AdetCombo.Text = " ";
            IcecekCombo.Text = " ";
            Fiyatlabel.Text = "Fiyat";




        }
    }
}

