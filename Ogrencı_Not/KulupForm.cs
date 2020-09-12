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
    public partial class KulupForm : Form
    {
        public KulupForm()
        {
            InitializeComponent();
        }
        void KulupListesi()
        {
            //Klüp listesini DataGridView ögesinde göstermek için formumuza tanıtıyoruz.
            List<ENTITIYKULUP> KlpLst = BLLKULUP.LISTELE();
            dataGridView1.DataSource = KlpLst;
        }
        private void KulupForm_Load(object sender, EventArgs e)
        {
            //form açıldığında otomatik olarak klup listesi açılacaktır.
            KulupListesi();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView üzerindeki satırlara tıklandığı zaman form üzerindeki gerekli bölümlere bu veriler yazılacaktır.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKulupId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKulupAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnKulupListele_Click(object sender, EventArgs e)
        {
            //Klupleri listeler.
            KulupListesi();
        }

        private void BtnKulupKaydet_Click(object sender, EventArgs e)
        {
            //ENTITYKULUP sınıfından oluşturduğumuz ent nesnesi, doldurulan ilgili alanlardaki verileri, hafızaya alıp veri tabanına işlenmesi için BLL katmanı üzerinden, gerekli koşulların sağlanması durumunda FACADE katmanına gönderiyor.
            ENTITIYKULUP ent = new ENTITIYKULUP();
            ent.KULUPAD = TxtKulupAd.Text;
            BLLKULUP.EKLE(ent);
            KulupListesi();
        }

        private void BtnKulupSil_Click(object sender, EventArgs e)
        {
            //ENTITYKULUP sınıfından oluşturduğumuz ent nesnesi, doldurulan ilgili alanlardaki verileri, hafızaya alıp veri tabanına işlenmesi için BLL katmanı üzerinden, gerekli koşulların sağlanması durumunda FACADE katmanına gönderiyor.
            ENTITIYKULUP ent = new ENTITIYKULUP();
            ent.KULUPID = Convert.ToInt16(TxtKulupId.Text);
            BLLKULUP.SIL(ent.KULUPID);
            KulupListesi();
        }

        private void BtnKulupGuncelle_Click(object sender, EventArgs e)
        {
            //ENTITYKULUP sınıfından oluşturduğumuz ent nesnesi, doldurulan ilgili alanlardaki verileri, hafızaya alıp veri tabanına işlenmesi için BLL katmanı üzerinden, gerekli koşulların sağlanması durumunda FACADE katmanına gönderiyor.
            ENTITIYKULUP ent = new ENTITIYKULUP();
            ent.KULUPAD = TxtKulupAd.Text;
            ent.KULUPID = Convert.ToInt16(TxtKulupId.Text);
            BLLKULUP.GUNCELLE(ent);
            KulupListesi();
        }
    }
}
