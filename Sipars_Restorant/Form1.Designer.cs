namespace Sipars_Restorant
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MasaNotext = new System.Windows.Forms.TextBox();
            this.PizzaBoyCombo = new System.Windows.Forms.ComboBox();
            this.PizzaTurCombo = new System.Windows.Forms.ComboBox();
            this.IcecekCombo = new System.Windows.Forms.ComboBox();
            this.SiparisButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Fiyatlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AdetCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza Boyu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pizza Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "İçecek : ";
            // 
            // MasaNotext
            // 
            this.MasaNotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MasaNotext.Location = new System.Drawing.Point(160, 16);
            this.MasaNotext.Name = "MasaNotext";
            this.MasaNotext.Size = new System.Drawing.Size(127, 26);
            this.MasaNotext.TabIndex = 7;
            // 
            // PizzaBoyCombo
            // 
            this.PizzaBoyCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PizzaBoyCombo.FormattingEnabled = true;
            this.PizzaBoyCombo.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.PizzaBoyCombo.Location = new System.Drawing.Point(160, 48);
            this.PizzaBoyCombo.Name = "PizzaBoyCombo";
            this.PizzaBoyCombo.Size = new System.Drawing.Size(127, 28);
            this.PizzaBoyCombo.TabIndex = 8;
            // 
            // PizzaTurCombo
            // 
            this.PizzaTurCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PizzaTurCombo.FormattingEnabled = true;
            this.PizzaTurCombo.Items.AddRange(new object[] {
            "Karışık",
            "Sucuklu",
            "Mantarlı"});
            this.PizzaTurCombo.Location = new System.Drawing.Point(160, 82);
            this.PizzaTurCombo.Name = "PizzaTurCombo";
            this.PizzaTurCombo.Size = new System.Drawing.Size(127, 28);
            this.PizzaTurCombo.TabIndex = 9;
            // 
            // IcecekCombo
            // 
            this.IcecekCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IcecekCombo.FormattingEnabled = true;
            this.IcecekCombo.Items.AddRange(new object[] {
            "Kola",
            "Fanta",
            "Ayran"});
            this.IcecekCombo.Location = new System.Drawing.Point(160, 147);
            this.IcecekCombo.Name = "IcecekCombo";
            this.IcecekCombo.Size = new System.Drawing.Size(127, 28);
            this.IcecekCombo.TabIndex = 11;
            // 
            // SiparisButton
            // 
            this.SiparisButton.BackColor = System.Drawing.Color.White;
            this.SiparisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisButton.ForeColor = System.Drawing.Color.Red;
            this.SiparisButton.Location = new System.Drawing.Point(160, 181);
            this.SiparisButton.Name = "SiparisButton";
            this.SiparisButton.Size = new System.Drawing.Size(127, 44);
            this.SiparisButton.TabIndex = 12;
            this.SiparisButton.Text = "Sipariş Ver";
            this.SiparisButton.UseVisualStyleBackColor = false;
            this.SiparisButton.Click += new System.EventHandler(this.SiparisButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(10, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Fiyat Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fiyatlabel
            // 
            this.Fiyatlabel.AutoSize = true;
            this.Fiyatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyatlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fiyatlabel.Location = new System.Drawing.Point(179, 250);
            this.Fiyatlabel.Name = "Fiyatlabel";
            this.Fiyatlabel.Size = new System.Drawing.Size(48, 20);
            this.Fiyatlabel.TabIndex = 14;
            this.Fiyatlabel.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adet  :";
            // 
            // AdetCombo
            // 
            this.AdetCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdetCombo.FormattingEnabled = true;
            this.AdetCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.AdetCombo.Location = new System.Drawing.Point(160, 113);
            this.AdetCombo.Name = "AdetCombo";
            this.AdetCombo.Size = new System.Drawing.Size(127, 28);
            this.AdetCombo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(327, 307);
            this.Controls.Add(this.AdetCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Fiyatlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SiparisButton);
            this.Controls.Add(this.IcecekCombo);
            this.Controls.Add(this.PizzaTurCombo);
            this.Controls.Add(this.PizzaBoyCombo);
            this.Controls.Add(this.MasaNotext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SiparisButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Fiyatlabel;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox MasaNotext;
        public System.Windows.Forms.ComboBox PizzaBoyCombo;
        public System.Windows.Forms.ComboBox PizzaTurCombo;
        public System.Windows.Forms.ComboBox IcecekCombo;
        public System.Windows.Forms.ComboBox AdetCombo;
    }
}

