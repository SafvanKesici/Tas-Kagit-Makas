using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;//www.gorselprogramlama.com

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

namespace Tas___Kagit___Makas

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }

        Random r = new Random();

        string Oyuncu1 = "", Oyuncu2 = "";

        private string RasgeleArac(PictureBox pBox)

        {

            int rasgeleArac = r.Next(0, 3);

            string aracAdi = "-";

            switch (rasgeleArac)//www.gorselprogramlama.com

            {

                case 0: aracAdi = "Taş"; break;

                case 1: aracAdi = "Kağıt"; break;

                case 2: aracAdi = "Makas"; break;

            }

            if (aracAdi.Equals("Taş"))

            {

                pBox.Image = Properties.Resources.tas;

            }

            else if (aracAdi.Equals("Kağıt"))//www.gorselprogramlama.com

            {

                pBox.Image = Properties.Resources.kagit;

            }

            else // Makas

            {

                pBox.Image = Properties.Resources.makas;

            }

            return aracAdi;

        }

        private void KazanmaDurumu()

        {

            string Durum = "";

            if (Oyuncu1 == "Taş" && Oyuncu2 == "Makas")

            {

                Durum = "Taş, Makas'ı kırar. Oyuncu 1 kazandı.";

            }

            else if (Oyuncu1 == "Makas" && Oyuncu2 == "Taş")

            {

                Durum = "Taş, Makas'ı kırar. Oyuncu 2 kazandı.";

            }

            else if (Oyuncu1 == "Kağıt" && Oyuncu2 == "Taş")//www.gorselprogramlama.com

            {

                Durum = "Kağıt, Taş'ı sarar. Oyuncu 1 kazandı.";

            }

            else if (Oyuncu1 == "Taş" && Oyuncu2 == "Kağıt")

            {

                Durum = "Kağıt, Taş'ı sarar. Oyuncu 2 kazandı.";

            }

            else if (Oyuncu1 == "Makas" && Oyuncu2 == "Kağıt")

            {

                Durum = "Makas, Kağıdı keser. Oyuncu 1 kazandı.";

            }

            else if (Oyuncu1 == "Kağıt" && Oyuncu2 == "Makas")

            {

                Durum = "Makas, Kağıdı keser. Oyuncu 2 kazandı.";

            }

            else if (Oyuncu1 == Oyuncu2)

            {

                Durum = "Berabere";

            }

            lblDurum.Text = Durum;

        }//www.gorselprogramlama.com

        private void btnOy1_Click(object sender, EventArgs e)

        {

            Oyuncu1 = RasgeleArac(pbOy1);

            btnOy1.Enabled = false;

        }

        private void btnOy2_Click(object sender, EventArgs e)

        {

            if (!btnOy1.Enabled)

            {

                Oyuncu2 = RasgeleArac(pbOy2);

                KazanmaDurumu();

                btnOy2.Enabled = false;//www.gorselprogramlama.com

            }

            else

            {

                MessageBox.Show("Önce birinci oyuncu oynamalıdır.", "Dikkat");

            }

        }

        private void btnYeniOyun_Click(object sender, EventArgs e)

        {

            btnOy1.Enabled = true;

            btnOy2.Enabled = true;

            Oyuncu1 = ""; Oyuncu2 = "";

            lblDurum.Text = "";

            pbOy1.Image = null; pbOy2.Image = null;//www.gorselprogramlama.com

        }

    }

}

