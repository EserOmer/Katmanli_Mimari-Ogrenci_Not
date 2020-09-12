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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        //Öğrenci Listeleme formunu çağırıyoruz.
        private void ogrlst_Click(object sender, EventArgs e)
        {
            OgrenciForm goster = new OgrenciForm();
            goster.Show();
        }

        //Klup Listeleme formunu çağırıyoruz.
        private void klplst_Click(object sender, EventArgs e)
        {
            KulupForm goster = new KulupForm();
            goster.Show();
        }

        //Notlar formunu çağırıyoruz.
        private void button1_Click(object sender, EventArgs e)
        {
            NotForm goster = new NotForm();
            goster.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

    }
}
