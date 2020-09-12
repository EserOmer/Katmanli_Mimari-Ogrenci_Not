namespace Ogrencı_Not
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.Baslik = new System.Windows.Forms.Label();
            this.ogrlst = new System.Windows.Forms.Button();
            this.klplst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Baslik
            // 
            this.Baslik.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslik.Location = new System.Drawing.Point(9, 7);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(325, 95);
            this.Baslik.TabIndex = 0;
            this.Baslik.Text = "Ogrenci Otomasyonuna Hos Geldiniz";
            this.Baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogrlst
            // 
            this.ogrlst.Location = new System.Drawing.Point(73, 118);
            this.ogrlst.Name = "ogrlst";
            this.ogrlst.Size = new System.Drawing.Size(191, 38);
            this.ogrlst.TabIndex = 1;
            this.ogrlst.Text = "OgrenciListesi";
            this.ogrlst.UseVisualStyleBackColor = true;
            this.ogrlst.Click += new System.EventHandler(this.ogrlst_Click);
            // 
            // klplst
            // 
            this.klplst.Location = new System.Drawing.Point(73, 226);
            this.klplst.Name = "klplst";
            this.klplst.Size = new System.Drawing.Size(191, 38);
            this.klplst.TabIndex = 2;
            this.klplst.Text = "KulupListesi";
            this.klplst.UseVisualStyleBackColor = true;
            this.klplst.Click += new System.EventHandler(this.klplst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ogrenci Not";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.klplst);
            this.Controls.Add(this.ogrlst);
            this.Controls.Add(this.Baslik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "OgrenciOtomasyonu";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Baslik;
        private System.Windows.Forms.Button ogrlst;
        private System.Windows.Forms.Button klplst;
        private System.Windows.Forms.Button button1;
    }
}

