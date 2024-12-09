using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp114
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> lst = new List<string>();
        Label l0 = new Label(); Button bEVET = new Button(); Button bHAYIR = new Button();
        RadioButton r = new RadioButton(); RadioButton r2 = new RadioButton(); RadioButton r3 = new RadioButton();
        Label l1 = new Label(); Button b1 = new Button();
        Label l2 = new Label(); Button b2 = new Button();
        Label l3 = new Label(); Button b3 = new Button();
        Label l4 = new Label(); Button b4 = new Button();
        Label l5 = new Label(); Button b5 = new Button();
        Label l6 = new Label(); Button b6 = new Button();
        List<string> list = new List<string>()
        {
"ANKETE BAŞLAMAK İSTER MİSİNİZ?","SOSYAL MEDYADA ÇOK ZAMAN GEÇİRİYORUM","SOSYAL MEDYAYI SADECE HABER ALMAK İÇİN KULLANIYORUM",
"SOSYAL MEDYA İLETİŞİMİNİ YÜZ YÜZE İLETİŞİME TERCİH EDERİM","SOSYAL MEDYA AKADEMİK BAŞARIMI OLUMSUZ ETKİLER",
"SOSYAL MEDYADA TANIMADIĞIM KİŞİLERİN İSTEĞİNİ KABUL EDERİM", "SOSYAL MEDYADA GÖRDÜĞÜM BİR HABERİN DOĞRULUĞUNU ARAŞTIRIRIM"
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            
            l0.Text = list[0];
            LabelKonum(l0);
            bEVET.Text = "EVET"; bEVET.Location = new Point(150, 100); bEVET.Size = new Size(50, 50);
            this.Controls.Add(bEVET);
            bHAYIR.Text = "HAYIR"; bHAYIR.Location = new Point(250, 100); bHAYIR.Size = new Size(50, 50);
            this.Controls.Add(bHAYIR);
            Label label = new Label(); Label label2 = new Label();
            label.Text = "DİKKAT ! CEVAPLAR SADECE 1 KERE İŞARETLENEBİLİR. SONRADAN DEĞİŞMEK MÜMKÜN DEĞİLDİR.";
            label.Location = new Point(10, 200);
            label.Size = new Size(1000, 20);
            this.Controls.Add(label);
            label2.Text = "LÜTFEN DİKKATLİ OKUYUNUZ...";
            label2.Location = new Point(170, 220);
            label2.Size = new Size(1000, 20);
            this.Controls.Add(label2);
        }
        private void BenimMetotum(object sender, EventArgs e)
        {
            this.Close();
        }
        string dg = "";
        private void BenimMetotum1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Text = "SORU 1";
            l1.Text = list[1];
            LabelKonum(l1);
            RBkonum(r, r2, r3);
            ButonEkle(b1);
        }
        private void BenimMetotum2(object sender, EventArgs e)
        {
            this.Controls.Clear(); this.Text = "SORU 2";
            l2.Text = list[2];
            LabelKonum(l2);
            RBkonum(r, r2, r3);
            ButonEkle(b2);
            if (r.Checked)
                lst.Add("EVET");
        }
        private void BenimMetotum3(object sender, EventArgs e)
        {
            this.Controls.Clear(); this.Text = "SORU 3";
            l3.Text = list[3];
            LabelKonum(l3);
            RBkonum(r, r2, r3);
            ButonEkle(b3);
        }
        private void BenimMetotum4(object sender, EventArgs e)
        {
            this.Controls.Clear(); this.Text = "SORU 4";
            l4.Text = list[4];
            LabelKonum(l4);
            RBkonum(r, r2, r3);
            ButonEkle(b4);
        }
        private void BenimMetotum5(object sender, EventArgs e)
        {
            this.Controls.Clear(); this.Text = "SORU 5";
            l5.Text = list[5];
            LabelKonum(l5);
            RBkonum(r, r2, r3);
            ButonEkle(b5);
        }
        private void BenimMetotum6(object sender, EventArgs e)
        {
            this.Controls.Clear(); this.Text = "SORU 6";
            l6.Text = list[6];
            LabelKonum(l6);
            RBkonum(r, r2, r3);
            ButonEkle(b6);
            b6.Text = "BİTİR";
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            bHAYIR.Click += new EventHandler(BenimMetotum);
            bEVET.Click += new EventHandler(BenimMetotum1);
            b1.Click += new EventHandler(BenimMetotum2);
            b2.Click += new EventHandler(BenimMetotum3);
            b3.Click += new EventHandler(BenimMetotum4);
            b4.Click += new EventHandler(BenimMetotum5);
            b5.Click += new EventHandler(BenimMetotum6);
            b6.Click += new EventHandler(Bitis);
            r.CheckedChanged += new EventHandler(cc);
            r2.CheckedChanged += new EventHandler(cc);
            r3.CheckedChanged += new EventHandler(cc);
            this.TextChanged += new EventHandler(rbe);
        }
        private void Bitis(object sender, EventArgs e)
        {
          DialogResult dr=  MessageBox.Show("ANKET TAMAMLANDI.CEVAPLARINIZ GÖNDERİELECEK. ONAYLIYOR MUSUNUZ?","DİKKAT",MessageBoxButtons.YesNo);
            if(dr==DialogResult.Yes)
            {
                MessageBox.Show("CEVAPLARINIZ GÖNDERİLDİ.");
                MessageBox.Show(lst.Count.ToString());
                foreach (string s in lst) MessageBox.Show(s); 
                this.Close(); 
            }
            else
            {
                MessageBox.Show("ANKET İPTAL EDİLDİ"); this.Close();
            }
        }
        private void ButonEkle(Button bt)
        {
            bt.Text = "SONRAKİ SORU";
            bt.Size = new Size(75, 50);
            bt.Location = new Point(220, 280);
            bt.Enabled = false;
            this.Controls.Add(bt);
        }
        private void LabelKonum(Label l)
        {
            l.Size = new Size(600, 20);
            l.Location = new Point(150, 50);
            this.Controls.Add(l);
        }
        private void RBkonum(RadioButton rb1, RadioButton rb2, RadioButton rb3)
        {
            rb1.Checked = false; rb2.Checked = false; rb3.Checked = false;
            rb1.Text = "EVET";
            rb2.Text = "KARARSIZIM";
            rb3.Text = "HAYIR";
            rb1.Size = new Size(100, 40); rb2.Size = new Size(100, 40); rb3.Size = new Size(100, 40);
            rb1.Location = new Point(220, 100);
            rb2.Location = new Point(220, 150);
            rb3.Location = new Point(220, 200);
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(rb3);
        }
        private void cc(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button) { c.Enabled = true;   }
                if (c is RadioButton) c.Enabled = false;
            }
        }
        private void rbe(object sender, EventArgs e)
        {
            r.Enabled = true; r2.Enabled = true; r3.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }
    }
}
