using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Ödev2
{
	public partial class Form1 : Form
	{
		TextBox txtSayi = new TextBox();
		Label lblYazi = new Label();
		Button btnHesapla = new Button();
		public Form1()
		{
			InitializeComponent();
			//TEXTBOX
			txtSayi.Left = 245;
			txtSayi.Top = 140;
			this.Controls.Add(txtSayi);
			//
			// LABEL
			//
			
			lblYazi.Top = 190;
			lblYazi.Left = 245;
			lblYazi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			lblYazi.AutoSize = true;
			lblYazi.Width = 100;
		
			this.Controls.Add(lblYazi);

			//BUTTON
			btnHesapla.Text = "Hesapla";
			btnHesapla.Top = 250;
			btnHesapla.Left = 245;
			btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;

			this.Controls.Add(btnHesapla);
			btnHesapla.Click += new EventHandler(Hesapla);
		}

		public void Hesapla(object sender, EventArgs e)
		{
		
		

			string Binler = "";
			string Yüzler = "";
			string Onlar = "";
			string Birler = "";
			string ONBİNLER="";


			int GirilenSayi;

			GirilenSayi = Convert.ToInt32(txtSayi.Text);

			
			string sonuc="";
			string sonuc0="";
			string sonuc1="";
			string sonuc2="";
			string sonuc3="";
			string sonuc4="";
		

			switch (GirilenSayi / 10000)
			{
				case 9: 
					ONBİNLER = ("DOKSAN "); break;
				case 8:
					ONBİNLER = ("SEKSEN  "); break;
				case 7:
					ONBİNLER = ("YETMİŞ "); break;
				case 6:
					ONBİNLER = ("ALTMIŞ "); break;
				case 5:
					ONBİNLER = ("ELLİ "); break;
				case 4:
					ONBİNLER = ("KIRK "); break;
				case 3:
					ONBİNLER = ("OTUZ "); break;
				case 2:
					ONBİNLER = ("YİRMİ "); break;
				case 1:
					ONBİNLER = ("ON "); break;
				default:break;
			}
			sonuc0 =ONBİNLER;


			switch (GirilenSayi%10000 / 1000)
			{
				case 9: 
					Binler = ("DOKUZ BİN "); break;
				case 8:
					Binler = ("SEKİZ BİN "); break;
				case 7:
					Binler = ("YEDİ BİN"); break;
				case 6:
					Binler = ("ALTI BİN"); break;
				case 5:
					Binler = ("BEŞ BİN"); break;
				case 4:
					Binler = ("DÖRT BİN"); break;
				case 3:
					Binler = ("ÜÇ BİN"); break;
				case 2:
					Binler = ("İKİ BİN"); break;
				case 1:
					Binler = ("BİN"); break;
				default:break;
			}
			sonuc1 =Binler;
			switch (GirilenSayi % 1000 / 100)
			{
				case 9:
					Yüzler = ("DOKUZ YÜZ"); break;
				case 8:
					Yüzler = ("SEKİZ YÜZ"); break;
				case 7:
					Yüzler = ("YEDİ YÜZ"); break;
				case 6:
					Yüzler = ("ALTI YÜZ"); break;
				case 5:
					Yüzler = ("BEŞ YÜZ"); break;
				case 4:
					Yüzler = ("DÖRT YÜZ"); break;
				case 3:
					Yüzler = ("ÜÇ YÜZ"); break;
				case 2:
					Yüzler = ("İKİ YÜZ"); break;
				case 1:
					Yüzler = ("YÜZ"); break;
					default :break;
			}
			sonuc2 = Yüzler;
			switch (GirilenSayi % 100 / 10)
			{
				case 9: 
					Onlar = ("DOKSAN"); break;
				case 8:
					Onlar = ("SEKSEN"); break;
				case 7:
					Onlar = ("YETMİŞ"); break;
				case 6:
					Onlar = ("ALTMIŞ"); break;
				case 5:
					Onlar = ("ELLİ"); break;
				case 4:
					Onlar = ("KIRK"); break;
				case 3:
					Onlar = ("OTUZ"); break;
				case 2:
					Onlar = ("YİRMİ"); break;
				case 1:
					Onlar = ("ON"); break;
					default:break;
			}
			sonuc3=Onlar;

			switch (GirilenSayi % 10)
			{
				case 9:
					Birler = ("DOKUZ"); break;
				case 8:
					Birler = ("SEKİZ"); break;
				case 7:
					Birler = ("YEDİ"); break;
				case 6:
					Birler = ("ALTI"); break;
				case 5:
					Birler = ("BEŞ"); break;
				case 4:
					Birler = ("DÖRT"); break;
				case 3:
					Birler = ("ÜÇ"); break;
				case 2:
					Birler = ("İKİ"); break;
				case 1:
					Birler = ("BİR"); break;
					default :break;
			}
			sonuc4=Birler;
			if (GirilenSayi == 0)
			{
				Console.WriteLine("SIFIR");
			}

			sonuc=sonuc0+" "+sonuc1+" "+sonuc2+" "+sonuc3+" "+sonuc4+" "+"TL";
			lblYazi.Text =sonuc;



		}
		  
	}
}
		

        

       
