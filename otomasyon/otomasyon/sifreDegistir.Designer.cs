namespace otomasyon
{
    partial class sifreDegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_guvenliksoru = new System.Windows.Forms.GroupBox();
            this.btn_sorgu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_cevap = new System.Windows.Forms.TextBox();
            this.txt_ka2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_kodsorgu = new System.Windows.Forms.GroupBox();
            this.btn_kodgonder = new System.Windows.Forms.Button();
            this.btn_kodsorgula = new System.Windows.Forms.Button();
            this.txt_kod = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_sifredegistir = new System.Windows.Forms.GroupBox();
            this.sifreDegis = new System.Windows.Forms.Button();
            this.txt_yenisifretekrar = new System.Windows.Forms.TextBox();
            this.txt_yenisifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_guvenliksoru.SuspendLayout();
            this.gb_kodsorgu.SuspendLayout();
            this.gb_sifredegistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_guvenliksoru
            // 
            this.gb_guvenliksoru.Controls.Add(this.btn_sorgu);
            this.gb_guvenliksoru.Controls.Add(this.label3);
            this.gb_guvenliksoru.Controls.Add(this.label2);
            this.gb_guvenliksoru.Controls.Add(this.comboBox1);
            this.gb_guvenliksoru.Controls.Add(this.txt_cevap);
            this.gb_guvenliksoru.Controls.Add(this.txt_ka2);
            this.gb_guvenliksoru.Controls.Add(this.label1);
            this.gb_guvenliksoru.Location = new System.Drawing.Point(22, 16);
            this.gb_guvenliksoru.Name = "gb_guvenliksoru";
            this.gb_guvenliksoru.Size = new System.Drawing.Size(388, 411);
            this.gb_guvenliksoru.TabIndex = 0;
            this.gb_guvenliksoru.TabStop = false;
            this.gb_guvenliksoru.Text = "Güvenlik Soru Yönetimi";
            this.gb_guvenliksoru.Enter += new System.EventHandler(this.gb_guvenliksoru_Enter);
            // 
            // btn_sorgu
            // 
            this.btn_sorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgu.Location = new System.Drawing.Point(12, 201);
            this.btn_sorgu.Name = "btn_sorgu";
            this.btn_sorgu.Size = new System.Drawing.Size(311, 36);
            this.btn_sorgu.TabIndex = 3;
            this.btn_sorgu.Text = "Sorgula";
            this.btn_sorgu.UseVisualStyleBackColor = true;
            this.btn_sorgu.Click += new System.EventHandler(this.btn_sorgu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soru Cevabı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güvenlik Sorusu:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // txt_cevap
            // 
            this.txt_cevap.Location = new System.Drawing.Point(172, 150);
            this.txt_cevap.Name = "txt_cevap";
            this.txt_cevap.Size = new System.Drawing.Size(151, 22);
            this.txt_cevap.TabIndex = 2;
            this.txt_cevap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_ka2
            // 
            this.txt_ka2.Location = new System.Drawing.Point(172, 39);
            this.txt_ka2.Name = "txt_ka2";
            this.txt_ka2.Size = new System.Drawing.Size(151, 22);
            this.txt_ka2.TabIndex = 0;
            this.txt_ka2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // gb_kodsorgu
            // 
            this.gb_kodsorgu.Controls.Add(this.btn_kodgonder);
            this.gb_kodsorgu.Controls.Add(this.btn_kodsorgula);
            this.gb_kodsorgu.Controls.Add(this.txt_kod);
            this.gb_kodsorgu.Controls.Add(this.txt_email);
            this.gb_kodsorgu.Controls.Add(this.label4);
            this.gb_kodsorgu.Controls.Add(this.label5);
            this.gb_kodsorgu.Location = new System.Drawing.Point(416, 16);
            this.gb_kodsorgu.Name = "gb_kodsorgu";
            this.gb_kodsorgu.Size = new System.Drawing.Size(388, 214);
            this.gb_kodsorgu.TabIndex = 1;
            this.gb_kodsorgu.TabStop = false;
            this.gb_kodsorgu.Text = "Email ve Kod Doğrulama";
            // 
            // btn_kodgonder
            // 
            this.btn_kodgonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kodgonder.Location = new System.Drawing.Point(268, 92);
            this.btn_kodgonder.Name = "btn_kodgonder";
            this.btn_kodgonder.Size = new System.Drawing.Size(111, 28);
            this.btn_kodgonder.TabIndex = 3;
            this.btn_kodgonder.Text = "Gönder";
            this.btn_kodgonder.UseVisualStyleBackColor = true;
            this.btn_kodgonder.Click += new System.EventHandler(this.btn_kodgonder_Click);
            // 
            // btn_kodsorgula
            // 
            this.btn_kodsorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kodsorgula.Location = new System.Drawing.Point(268, 177);
            this.btn_kodsorgula.Name = "btn_kodsorgula";
            this.btn_kodsorgula.Size = new System.Drawing.Size(111, 28);
            this.btn_kodsorgula.TabIndex = 3;
            this.btn_kodsorgula.Text = "Sorgula";
            this.btn_kodsorgula.UseVisualStyleBackColor = true;
            this.btn_kodsorgula.Click += new System.EventHandler(this.btn_kodsorgula_Click);
            // 
            // txt_kod
            // 
            this.txt_kod.Location = new System.Drawing.Point(173, 138);
            this.txt_kod.Name = "txt_kod";
            this.txt_kod.Size = new System.Drawing.Size(206, 22);
            this.txt_kod.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(176, 55);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(206, 22);
            this.txt_email.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğrulama Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Adresiniz:";
            // 
            // gb_sifredegistir
            // 
            this.gb_sifredegistir.Controls.Add(this.sifreDegis);
            this.gb_sifredegistir.Controls.Add(this.txt_yenisifretekrar);
            this.gb_sifredegistir.Controls.Add(this.txt_yenisifre);
            this.gb_sifredegistir.Controls.Add(this.label6);
            this.gb_sifredegistir.Controls.Add(this.label7);
            this.gb_sifredegistir.Location = new System.Drawing.Point(416, 236);
            this.gb_sifredegistir.Name = "gb_sifredegistir";
            this.gb_sifredegistir.Size = new System.Drawing.Size(379, 191);
            this.gb_sifredegistir.TabIndex = 3;
            this.gb_sifredegistir.TabStop = false;
            this.gb_sifredegistir.Text = "Şifre Değiştirme";
            // 
            // sifreDegis
            // 
            this.sifreDegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreDegis.Location = new System.Drawing.Point(268, 143);
            this.sifreDegis.Name = "sifreDegis";
            this.sifreDegis.Size = new System.Drawing.Size(105, 28);
            this.sifreDegis.TabIndex = 2;
            this.sifreDegis.Text = "Değiştir";
            this.sifreDegis.UseVisualStyleBackColor = true;
            this.sifreDegis.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_yenisifretekrar
            // 
            this.txt_yenisifretekrar.Location = new System.Drawing.Point(173, 103);
            this.txt_yenisifretekrar.Name = "txt_yenisifretekrar";
            this.txt_yenisifretekrar.Size = new System.Drawing.Size(200, 22);
            this.txt_yenisifretekrar.TabIndex = 1;
            // 
            // txt_yenisifre
            // 
            this.txt_yenisifre.Location = new System.Drawing.Point(172, 62);
            this.txt_yenisifre.Name = "txt_yenisifre";
            this.txt_yenisifre.Size = new System.Drawing.Size(201, 22);
            this.txt_yenisifre.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yeni Şifre Tekrar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yeni Şifre:";
            // 
            // sifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 435);
            this.Controls.Add(this.gb_sifredegistir);
            this.Controls.Add(this.gb_kodsorgu);
            this.Controls.Add(this.gb_guvenliksoru);
            this.Name = "sifreDegistir";
            this.Text = "sifreDegistir";
            this.Load += new System.EventHandler(this.sifreDegistir_Load);
            this.gb_guvenliksoru.ResumeLayout(false);
            this.gb_guvenliksoru.PerformLayout();
            this.gb_kodsorgu.ResumeLayout(false);
            this.gb_kodsorgu.PerformLayout();
            this.gb_sifredegistir.ResumeLayout(false);
            this.gb_sifredegistir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_guvenliksoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_ka2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cevap;
        private System.Windows.Forms.Button btn_sorgu;
        private System.Windows.Forms.GroupBox gb_kodsorgu;
        private System.Windows.Forms.Button btn_kodgonder;
        private System.Windows.Forms.Button btn_kodsorgula;
        private System.Windows.Forms.TextBox txt_kod;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_sifredegistir;
        private System.Windows.Forms.Button sifreDegis;
        private System.Windows.Forms.TextBox txt_yenisifretekrar;
        private System.Windows.Forms.TextBox txt_yenisifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}