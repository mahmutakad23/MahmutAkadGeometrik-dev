using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahmutAkadGeometrikÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSekil.Items.Add("Seçiniz--");
            cmbSekil.Items.Add("Kare");
            cmbSekil.Items.Add("DikDörtgen");
            cmbSekil.Items.Add("EşkenarÜçgen");
            cmbSekil.Items.Add("DikÜçgen");
            cmbSekil.Items.Add("Daire");
            cmbSekil.SelectedIndex = 0;
            panelKare.Visible = false;
            panelDortgen.Visible = false;
            panelEşkenar.Visible = true;
            panelDikUcgen.Visible = false;
            panelDaire.Visible = false;
            panelKare.Location = new System.Drawing.Point(270, 133);
            panelDortgen.Location = new System.Drawing.Point(270, 133);
            panelEşkenar.Location = new System.Drawing.Point(270, 133);
            panelDikUcgen.Location = new System.Drawing.Point(270, 133);
            panelDaire.Location = new System.Drawing.Point(270, 133);
        }

        private void cmbSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelKare.Visible = false;
            panelDortgen.Visible = false;
            panelEşkenar.Visible = false;
            panelDikUcgen.Visible = false;
            if (cmbSekil.SelectedIndex == 1)
            {
                panelKare.Visible = true;
            }
            else if (cmbSekil.SelectedIndex == 2)
            {
                panelDortgen.Visible = true;
            }
            else if (cmbSekil.SelectedIndex == 3)
            {
                panelEşkenar.Visible = true;
                label8.Visible = true;
                textBox2.Visible = true;
            }
            else if (cmbSekil.SelectedIndex == 4)
            {
                panelDikUcgen.Visible = true;
            }
            else if (cmbSekil.SelectedIndex == 5)
            {
                panelDaire.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            if (cmbSekil.SelectedIndex != 0 && cmbHesapla.SelectedIndex != 0)
            {
                if (cmbSekil.SelectedIndex == 1)
                {
                    if (cmbHesapla.SelectedIndex == 1)
                    {
                        Kare kare = new Kare();
                        kare.UzunKenar = Convert.ToDouble(textBox1.Text);
                        sonuc = kare.DortgenAlanHesapla();
                        label9.Text = sonuc.ToString();
                    }
                    if (cmbHesapla.SelectedIndex == 2)
                    {
                        Kare kare = new Kare();
                        kare.UzunKenar = Convert.ToDouble(textBox1.Text);
                        sonuc = kare.DortgenCevreHesapla();
                        label9.Text = sonuc.ToString();
                    }
                }
                if (cmbSekil.SelectedIndex == 2)
                {
                    if (cmbHesapla.SelectedIndex == 1)
                    {
                        Dikdörtgen dortgen = new Dikdörtgen();
                        dortgen.UzunKenar = Convert.ToDouble(tbUzunKenar.Text);
                        dortgen.KısaKenar = Convert.ToDouble(tbKısaKenar.Text);
                        sonuc = dortgen.DortgenAlanHesapla();
                        label9.Text = sonuc.ToString();
                    }
                    if (cmbHesapla.SelectedIndex == 2)
                    {
                        Dikdörtgen dortgen = new Dikdörtgen();
                        dortgen.UzunKenar = Convert.ToDouble(tbUzunKenar.Text);
                        dortgen.KısaKenar = Convert.ToDouble(tbKısaKenar.Text);
                        sonuc = dortgen.DortgenCevreHesapla();
                        label9.Text = sonuc.ToString();
                    }
                }
                if (cmbSekil.SelectedIndex == 3)
                {
                    if (cmbHesapla.SelectedIndex == 1)
                    {
                        EskenarUcgen eskenarUcgen = new EskenarUcgen();
                        eskenarUcgen.TabanKenar = Convert.ToDouble(textBox2.Text);
                        sonuc = eskenarUcgen.UcgenAlanHesapla();
                        label9.Text = sonuc.ToString();
                    }
                    if (cmbHesapla.SelectedIndex == 2)
                    {
                        EskenarUcgen eskenarUcgen = new EskenarUcgen();
                        eskenarUcgen.TabanKenar = Convert.ToDouble(textBox2.Text);
                        sonuc = eskenarUcgen.UcgenCevreHesapla();
                        label9.Text = sonuc.ToString();
                    }
                }
                if (cmbSekil.SelectedIndex == 4)
                {
                    if (cmbHesapla.SelectedIndex == 1)
                    {
                        DikUcgen dikUcgen = new DikUcgen();
                        dikUcgen.TabanKenar = Convert.ToDouble(tbTaban.Text);
                        dikUcgen.Yükseklik = Convert.ToDouble(tbYukseklık.Text);
                        sonuc = dikUcgen.UcgenAlanHesapla();
                        label9.Text = sonuc.ToString();
                    }
                    if (cmbHesapla.SelectedIndex == 2)
                    {
                        DikUcgen dikUcgen = new DikUcgen();
                        dikUcgen.TabanKenar = Convert.ToDouble(tbTaban.Text);
                        dikUcgen.Yükseklik = Convert.ToDouble(tbYukseklık.Text);
                        sonuc = dikUcgen.UcgenCevreHesapla();
                        label9.Text = sonuc.ToString();
                    }

                }
                if (cmbSekil.SelectedIndex == 5)
                {
                    if (cmbHesapla.SelectedIndex == 1)
                    {
                        Daire daire = new Daire();
                        daire.YarıCap = Convert.ToDouble(textBox3.Text);
                        sonuc = daire.AlanHesapla();
                        label9.Text = sonuc.ToString();
                    }
                    if (cmbHesapla.SelectedIndex == 2)
                    {
                        Daire daire = new Daire();
                        daire.YarıCap = Convert.ToDouble(textBox3.Text);
                        sonuc = daire.CevreHesapla();
                        label9.Text = sonuc.ToString();
                    }

                }
            }
        }
    }
}
