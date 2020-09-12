using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using FACADELAYER;
using BUSINESSLOGICLAYER;

namespace Ogrencı_Not
{
    public partial class NotForm : Form
    {
        public NotForm()
        {
            InitializeComponent();
        }
        void NotListesi()
        {
            //Notları DataGridView ögesinde göstermek için formumuza tanıtıyoruz.
            List<ENTITYNOTLAR> EntNot = BLLNOTLAR.LISTELE();
            dataGridView1.DataSource = EntNot;
        }
        private void NotForm_Load(object sender, EventArgs e)
        {
            //form açıldığında otomatik olarak Notları gösterecektir.
            NotListesi();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView üzerindeki satırlara tıklandığı zaman form üzerindeki gerekli bölümlere bu veriler yazılacaktır.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtOgrId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtS1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtS2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtS3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtOrt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {
            //Notları listeler.
            NotListesi();
        }

        private void BtnNotGuncelle_Click(object sender, EventArgs e)
        {
            //ENTITYNOTLAR sınıfından oluşturduğumuz ent nesnesi, doldurulan ilgili alanlardaki verileri, hafızaya alıp veri tabanına işlenmesi için BLL katmanı üzerinden, gerekli koşulların sağlanması durumunda FACADE katmanına gönderiyor.
            ENTITYNOTLAR ent = new ENTITYNOTLAR();
            ent.OGRENCIID = Convert.ToInt16(TxtOgrId.Text);
            ent.SINAV1 = Convert.ToInt16(TxtS1.Text);
            ent.SINAV2 = Convert.ToInt16(TxtS2.Text);
            ent.SINAV3 = Convert.ToInt16(TxtS3.Text);
            ent.PROJE = Convert.ToInt16(TxtProje.Text);
            ent.ORTALAMA = Convert.ToInt16(TxtOrt.Text);
            ent.DURUM = TxtDurum.Text;
            BLLNOTLAR.GUNCELLE(ent);
            MessageBox.Show("Notlar Guncellendi");
            NotListesi();
        }

        private void TxtHeaspla_Click(object sender, EventArgs e)
        {
            //Girilen değerleri int türüne çevirerek, ders durumunu güncelliyor.
            int s1, s2, s3, proje;
            double ortalama;
            string durum;
            s1 = Convert.ToInt16(TxtS1.Text);
            s2 = Convert.ToInt16(TxtS2.Text);
            s3 = Convert.ToInt16(TxtS3.Text);
            proje = Convert.ToInt16(TxtProje.Text);
            ortalama = (s1 + s2 + s3 + proje) / 4;
            TxtOrt.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            TxtDurum.Text = durum;
        }

    }
}
