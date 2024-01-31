using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film_fragman_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU PROJE ÖMER GÜLSEVER TARAFINDAN HAZIRLANMIŞTIR","HAKKIMDA",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void mAVİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void gRİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void tURUNCUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Orange;
        }

        private void sARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void sİYAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void kIRMIZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Red;
        }

        private void mADMAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "MAD MAX";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
        }

        private void sOYSUZLARÇETESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "SOYSUZLAR ÇETESİ";
            webBrowser1.Navigate("https://youtu.be/WU9w4Bxp2wg?si=GXdiR2d2D1Dawze7");
        }

        private void jHONWİCKCHAPTER4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "JHON WİCK CHAPTER 4";
            webBrowser1.Navigate("https://youtu.be/BS_DuNE8qRQ?si=irQ-xQy7hvVuIyEH");
        }

        private void kOLPAÇİNO44LÜKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "KOLPAÇİNO 4'4 LÜK";
            webBrowser1.Navigate("https://youtu.be/OXyUcufmEJg?si=eVl607JGr1suJK0l");
        }

        private void öLÜMLÜDÜNYA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "ÖLÜMLÜ DÜNYA 2";
            webBrowser1.Navigate("https://youtu.be/pCSgerDxWew?si=sF2JSnMKY1PWy0jN");
        }

        private void cENAZEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg3.stockfresh.com%2Ffiles%2Fp%2Fpikepicture%2Fm%2F75%2F8423441_stock-vector-test-color-glitch-screen.jpg&tbnid=Dod7QD0oM4V6aM&vet=12ahUKEwi7qo6hnv-BAxXYhaQKHeSQDJsQMygIegQIARBk..i&imgrefurl=https%3A%2F%2Ftr.stockfresh.com%2Fimage%2F8423441%2Ftest-color-glitch-screen&docid=BUtCy5w6msdAfM&w=600&h=337&q=BOZUK%20TV&hl=tr&client=opera-gx&ved=2ahUKEwi7qo6hnv-BAxXYhaQKHeSQDJsQMygIegQIARBk");
        }

        private void dELİBALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "DELİBAL";
            webBrowser1.Navigate("https://youtu.be/_A-k9FYBF5g?si=1NCkMsIYeOurWYxt");
        }

        private void iNCİRREÇELİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "İNCİR REÇELİ";
            webBrowser1.Navigate("https://youtu.be/uUSrHisXjVw?si=qZdTV0lzXDLy_r8l");
        }

        private void sELVİBOYLUMALYAZMALIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "SELVİ BOYLUM AL YAZMALIM";
            webBrowser1.Navigate("https://youtu.be/MGYfWv6jt0A?si=4xnlMrDCOreJLX_0");
        }

        private void dABBECİNÇARPMASIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "DABBE 4: CİN ÇARPMASI";
            MessageBox.Show("REENKARNASYON CİN ÇARPMASIDIR");
            webBrowser1.Navigate("https://youtu.be/oFAHTz01f7g?si=6Xu4AZr6MtM8WR8Y");
        }

        private void sİCCİN6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "SİCCİN 6";
            webBrowser1.Navigate("https://youtu.be/pSobZRBIL9g?si=scSVSYBuAUk3t5u1");
        }

        private void sAWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "SAW";
            webBrowser1.Navigate("https://youtu.be/pSobZRBIL9g?si=scSVSYBuAUk3t5u1");
        }
    }
}
