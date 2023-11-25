using System.Diagnostics.Eventing.Reader;
using System.Security;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double Birincisayi, Ikincisayi;
        bool Ekrantemizleme;
        string Islem;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
  

            private void Butonarti_Click(object sender, EventArgs e)
            {


                Islem = "+";
                Ekrantemizleme = true;

                Birincisayi = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + "+";


            }

            private void Butoneksi_Click(object sender, EventArgs e)
            {
                Islem = "-";
                Ekrantemizleme = true;

                Birincisayi = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + "-";

            }

            private void Butonesittir_Click(object sender, EventArgs e)
            {


                Label2.Text = "0";

                Ikincisayi = Convert.ToDouble(Label1.Text);

                if (Islem == "+")
                {
                    Label1.Text = Convert.ToString(Birincisayi + Ikincisayi);



                }


                Ikincisayi = Convert.ToDouble(Label1.Text);

                if (Islem == "-")
                {
                    Label1.Text = Convert.ToString(Birincisayi - Ikincisayi);



                }

                Ikincisayi = Convert.ToDouble(Label1.Text);

                if (Islem == "x")
                {
                    Label1.Text = Convert.ToString(Birincisayi * Ikincisayi);

                }

                Ikincisayi = Convert.ToDouble(Label1.Text);

                if (Islem == "/")
                {
                    Label1.Text = Convert.ToString(Birincisayi / Ikincisayi);

                }




                Ikincisayi = Convert.ToDouble(Label1.Text);

                if (Islem == "%")
                {

                    Label1.Text = Convert.ToString((Birincisayi * Ikincisayi) / 100);
                }





            }

            private void Butonyuzde_Click(object sender, EventArgs e)
            {
                Islem = "%";
                Ekrantemizleme = true;

                Birincisayi = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + "(%)";

            }

            private void Butoncarpi_Click(object sender, EventArgs e)
            {
                Islem = "x";
                Ekrantemizleme = true;

                Birincisayi = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + "x";

            }

            private void Butonbolme_Click(object sender, EventArgs e)
            {
                Islem = "/";
                Ekrantemizleme = true;

                Birincisayi = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + "/";

            }

            private void Rakam1_Click(object sender, EventArgs e)
            {

                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "1";

            }

            private void Rakam2_Click(object sender, EventArgs e)
            {

                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "2";

            }

            private void Rakam0_Click(object sender, EventArgs e)
            {


                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "0";

            }

            private void Rakam5_Click(object sender, EventArgs e)
            {
                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "5";

            }

            private void Rakam3_Click(object sender, EventArgs e)
            {
                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "3";

            }

            private void Rakam4_Click(object sender, EventArgs e)
            {
                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "4";

            }

            private void Rakam6_Click(object sender, EventArgs e)
            {

                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "6";

            }

            private void Rakam7_Click(object sender, EventArgs e)
            {

                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "7";

            }

            private void Rakam8_Click(object sender, EventArgs e)
            {

                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "8";

            }

            private void Rakam9_Click(object sender, EventArgs e)
            {

                if (Ekrantemizleme)
                {
                    Label1.Text = "";
                    Ekrantemizleme = false;
                }


                if (Label1.Text == "0") Label1.Text = "";

                Label1.Text += "9";

            }

            private void Karekök_Click(object sender, EventArgs e)
            {

                Ekrantemizleme = true;

                double Birincisayi = Convert.ToDouble(Label1.Text);

                Birincisayi = Math.Sqrt(Birincisayi);

                Label1.Text = Convert.ToString(Birincisayi);


            }

            private void Label1_Click(object sender, EventArgs e)
            {

            }

            private void Solokbuton_Click(object sender, EventArgs e)
            {
                if (Convert.ToDouble(Label1.Text) > 0)
                {
                    Label1.Text = Label1.Text.Remove(Label1.Text.Length - 1, 1);
                    if (Label1.Text.Length == 0)
                    {

                        Label1.Text = "0";

                    }



                }

            }

            private void Clear_Click(object sender, EventArgs e)
            {
                Label1.Text = "0";

                Label2.Text = "";


            }

            private void Label2_Click(object sender, EventArgs e)
            {

            }

            private void Uslu_Click(object sender, EventArgs e)
            {

                Ekrantemizleme = true;

                double Birincisayi = Convert.ToDouble(Label1.Text);

                Birincisayi = Math.Pow(Birincisayi, 2);

                Label1.Text = Convert.ToString(Birincisayi);

            }

            private void Tersinibulma_Click(object sender, EventArgs e)
            {


                Ekrantemizleme = true;

                double Birincisayi = Convert.ToDouble(Label1.Text);

                Birincisayi = 1 / (Birincisayi);

                Label1.Text = Convert.ToString(Birincisayi);

            }

            private void Pi_Click(object sender, EventArgs e)
            {
                Label1.Text = "3,1415926535897932384626433832795";

            }

            private void Loga_Click(object sender, EventArgs e)
            {

                double Birincisayi = Convert.ToDouble(Label1.Text);
                Birincisayi = Math.Log10(Birincisayi);
                Label1.Text = Convert.ToString(Birincisayi);

            }

            private void Noktabuton_Click(object sender, EventArgs e)
            {

                Label1.Text += ".";


            }


        private void Virgülbuton_Click(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
            {
                Label1.Text = "0";
            }
            else if (Ekrantemizleme)
            {
                Label1.Text = "0";
            }
            if (!Label1.Text.Contains(","))
            {
                Label1.Text += ",";
            }
            Ekrantemizleme = false;
        }





        private void Sinbut_Click(object sender, EventArgs e)
            {


                double Birincisayi = Convert.ToDouble(Label1.Text);
                Birincisayi = Math.Sin(Birincisayi);
                Label1.Text = Convert.ToString(Birincisayi);

            }

            private void Cosbut_Click(object sender, EventArgs e)
            {
                double Birincisayi = Convert.ToDouble(Label1.Text);
                Birincisayi = Math.Cos(Birincisayi);
                Label1.Text = Convert.ToString(Birincisayi);
            }

            private void Tanj_Click(object sender, EventArgs e)
            {
                double Birincisayi = Convert.ToDouble(Label1.Text);
                Birincisayi = Math.Tan(Birincisayi);
                Label1.Text = Convert.ToString(Birincisayi);
            }


        }
    }


   
