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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }
        void OgrenciListesi()
        {
            //Öğrencileri DataGridView ögesinde göstermek için formumuza tanıtıyoruz.
            List<ENTITYOGRENCI> OgrList = BLLOGRENCI.LISTELE();
            dataGridView1.DataSource = OgrList;
        }
        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            
            //form açıldığında otomatik olarak Notları gösterecektir.
            OgrenciListesi();
            List<ENTITIYKULUP> KlpLst = BLLKULUP.LISTELE();
            cmbkulup.DisplayMember = "KULUPAD";
            cmbkulup.ValueMember = "KULUPID";
            cmbkulup.DataSource = KlpLst;
        }
        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            //ENTITYOGRENCI sınıfından oluşturduğumuz ent nesnesi, doldurulan ilgili alanlardaki verileri, hafızaya alıp veri tabanına işlenmesi için BLL katmanı üzerinden, gerekli koşulların sağlanması durumunda FACADE katmanına gönderiyor.
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = txtad.Text;
            ent.SOYAD = txtsoyad.Text;
            ent.FOTOGRAF = txtfotograf.Text;
            ent.KULUPID = Convert.ToInt16(cmbkulup.SelectedValue);
            BLLOGRENCI.EKLE(ent);
            MessageBox.Show("Ogrenci Kaydi Yapildi");
            OgrenciListesi();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView üzerindeki satırlara tıklandığı zaman form üzerindeki gerekli bölümlere bu veriler yazılacaktır.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtfotograf.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbkulup.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //Ogrencileri listeler.
            OgrenciListesi();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //ENTITYOGRENCI sınıfından oluşturduğumuz ent nesnesi, doldurulan ilgili alanlardaki verileri, hafızaya alıp veri tabanına işlenmesi için BLL katmanı üzerinden, gerekli koşulların sağlanması durumunda FACADE katmanına gönderiyor.
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = txtad.Text;
            ent.SOYAD = txtsoyad.Text;
            ent.FOTOGRAF = txtfotograf.Text;
            ent.KULUPID = Convert.ToInt16(cmbkulup.SelectedValue);
            ent.ID = Convert.ToInt16(txtid.Text);
            BLLOGRENCI.GUNCELLE(ent);
            MessageBox.Show("Ogrenci Bilgileri Guncellendi");
            OgrenciListesi();

        }

        private void cmbkulup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
