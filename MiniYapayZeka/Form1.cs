using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Media;
using System.Linq;
using System.Threading;
using Mini_Yapayzeka_DAL.data;
using Mini_Yapayzeka_Entity;

namespace MiniYapayZeka
{
    public partial class Form1 : Form
    {
        string gelensoru;
        //string _cevap = "Bunun cevab�n� hen�z bilmiyorum.. ��retmek ister misin?";
        //string u�cevap;
        DataContext db = new DataContext();

        Learning_Data data = new Learning_Data();
        public Form1()
        {

            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += Form1_KeyDown;


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    gelensoru = ric_gelensoru.Text;
                    var gelen = db._Datas.FirstOrDefault(i => i.question == gelensoru);

                    if (gelen != null)
                    {
                        ric_gelensoru.Text = "";
                        if (gelen.answer != null)
                        {
                            ric_gelensoru.Text = "";
                            lbl_Ekran.Text = "Bunun i�in ne cevap verece�imi bilmiyorum..! Acaba bana ��retmek istemisin?";

                            if (ric_gelensoru.Text == "Evet".ToLower())
                            {
                                ric_gelensoru.Text = "";
                                lbl_Ekran.Text = "Peki ne s�ylemem gerek?";
                                if (ric_gelensoru.Text != null)
                                {
                                    data.question = gelensoru;
                                    data.answer = ric_gelensoru.Text;

                                    db._Datas.Add(data);
                                    db.SaveChanges();

                                    ric_gelensoru.Text = "";
                                    lbl_Ekran.Text = "Bilgi i�in te�ekk�rler!:D Bana �ok faydal� olaca��na eminim!";
                                }
                            }
                            else if (ric_gelensoru.Text == "Hay�r".ToLower())
                            {
                                ric_gelensoru.Text = "";
                                lbl_Ekran.Text = "Bu durumda size daha fazla yard�mc� olamam! Ho��akal�n.!";

                                Thread.Sleep(3000);

                                Application.Exit();
                            }
                        }
                    }
                    else
                    {
                        ric_gelensoru.Text = "";
                        lbl_Ekran.Text = "Bunun cevab�n� hen�z bilmiyorum.. ��retmek ister misin?";

                        if (ric_gelensoru.Text == "Evet".ToLower())
                        {
                            ric_gelensoru.Text = "";
                            lbl_Ekran.Text = "Peki cevap nedir?";
                            if (ric_gelensoru.Text != null)
                            {
                                data.question = gelensoru;
                                data.answer = ric_gelensoru.Text;

                                db._Datas.Add(data);
                                db.SaveChanges();

                                ric_gelensoru.Text = "";
                                lbl_Ekran.Text = "Bilgi i�in te�ekk�rler!:D Bana �ok faydal� olaca��na eminim!";
                            }

                        }
                    }
                }
                catch (Exception ex)
                {

                    lbl_Ekran.Text = "Hata!" + ex.Message;
                }
            }


        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {

                var gelen = db._Datas.Where(i => i.question == ric_gelensoru.Text).FirstOrDefault();

                if (gelen != null)
                {
                    lbl_Ekran.Text = gelen.answer.ToString();
                }
            }
            catch (Exception ex)
            {

                lbl_Ekran.Text = "Hata!" + ex.Message;
            }
        }
    }
}