namespace otomasyon
{
    partial class urunAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunAdmin));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_kg = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.olusmatarih = new System.Windows.Forms.MaskedTextBox();
            this.guncellenmetarih = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketDataSet6 = new otomasyon.marketDataSet6();
            this.urunBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.marketDataSet5 = new otomasyon.marketDataSet5();
            this.urunBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter4 = new otomasyon.marketDataSet5TableAdapters.UrunTableAdapter();
            this.urunTableAdapter = new otomasyon.marketDataSet6TableAdapters.UrunTableAdapter();
            this.marketDataSet7 = new otomasyon.marketDataSet7();
            this.urunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter1 = new otomasyon.marketDataSet7TableAdapters.UrunTableAdapter();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "Hopstarter-Sleek-Xp-Basic-Add.ico";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(192, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ürün Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "Awicons-Vista-Artistic-Delete.ico";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(384, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ürün Sil";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(572, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "İD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(644, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güncellenme Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Adı:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(644, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Olusturulma Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(308, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kilo Fiyat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(308, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mevcut Kilogram:";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(120, 277);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(167, 22);
            this.txt_id.TabIndex = 5;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(120, 321);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(167, 22);
            this.txt_barkod.TabIndex = 6;
            this.txt_barkod.TextChanged += new System.EventHandler(this.txt_barkod_TextChanged);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(120, 362);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(167, 22);
            this.txt_ad.TabIndex = 7;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // txt_kg
            // 
            this.txt_kg.Location = new System.Drawing.Point(482, 279);
            this.txt_kg.Name = "txt_kg";
            this.txt_kg.Size = new System.Drawing.Size(156, 22);
            this.txt_kg.TabIndex = 8;
            this.txt_kg.TextChanged += new System.EventHandler(this.txt_kg_TextChanged);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(482, 321);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(156, 22);
            this.txt_fiyat.TabIndex = 9;
            this.txt_fiyat.TextChanged += new System.EventHandler(this.txt_fiyat_TextChanged);
            // 
            // olusmatarih
            // 
            this.olusmatarih.Location = new System.Drawing.Point(858, 275);
            this.olusmatarih.Mask = "0/00/0000 90:00";
            this.olusmatarih.Name = "olusmatarih";
            this.olusmatarih.Size = new System.Drawing.Size(135, 22);
            this.olusmatarih.TabIndex = 10;
            this.olusmatarih.ValidatingType = typeof(System.DateTime);
            this.olusmatarih.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.olusmatarih_MaskInputRejected);
            this.olusmatarih.TextChanged += new System.EventHandler(this.olusmatarih_TextChanged);
            // 
            // guncellenmetarih
            // 
            this.guncellenmetarih.Location = new System.Drawing.Point(858, 319);
            this.guncellenmetarih.Mask = "0/00/0000 90:00";
            this.guncellenmetarih.Name = "guncellenmetarih";
            this.guncellenmetarih.Size = new System.Drawing.Size(135, 22);
            this.guncellenmetarih.TabIndex = 11;
            this.guncellenmetarih.ValidatingType = typeof(System.DateTime);
            this.guncellenmetarih.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.guncellenmetarih_MaskInputRejected);
            this.guncellenmetarih.TextChanged += new System.EventHandler(this.guncellenmetarih_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(308, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ciro:";
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(482, 364);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(156, 22);
            this.txt_ciro.TabIndex = 12;
            this.txt_ciro.TextChanged += new System.EventHandler(this.txt_ciro_TextChanged);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 3);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(1002, 255);
            this.data.TabIndex = 13;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.marketDataSet6;
            // 
            // marketDataSet6
            // 
            this.marketDataSet6.DataSetName = "marketDataSet6";
            this.marketDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marketDataSet5
            // 
            this.marketDataSet5.DataSetName = "marketDataSet5";
            this.marketDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource7
            // 
            this.urunBindingSource7.DataMember = "Urun";
            this.urunBindingSource7.DataSource = this.marketDataSet5;
            // 
            // urunTableAdapter4
            // 
            this.urunTableAdapter4.ClearBeforeFill = true;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // marketDataSet7
            // 
            this.marketDataSet7.DataSetName = "marketDataSet7";
            this.marketDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource1
            // 
            this.urunBindingSource1.DataMember = "Urun";
            this.urunBindingSource1.DataSource = this.marketDataSet7;
            // 
            // urunTableAdapter1
            // 
            this.urunTableAdapter1.ClearBeforeFill = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hopstarter-Sleek-Xp-Basic-Add.ico");
            this.ımageList1.Images.SetKeyName(1, "Awicons-Vista-Artistic-Delete.ico");
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // urunAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1015, 537);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txt_ciro);
            this.Controls.Add(this.guncellenmetarih);
            this.Controls.Add(this.olusmatarih);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_kg);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "urunAdmin";
            this.Text = "urunAdmin";
            this.Load += new System.EventHandler(this.urunAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_kg;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.MaskedTextBox olusmatarih;
        private System.Windows.Forms.MaskedTextBox guncellenmetarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.BindingSource urunBindingSource6;
        private marketDataSet5 marketDataSet5;
        private System.Windows.Forms.BindingSource urunBindingSource7;
        private marketDataSet5TableAdapters.UrunTableAdapter urunTableAdapter4;
        private marketDataSet6 marketDataSet6;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private marketDataSet6TableAdapters.UrunTableAdapter urunTableAdapter;
        private marketDataSet7 marketDataSet7;
        private System.Windows.Forms.BindingSource urunBindingSource1;
        private marketDataSet7TableAdapters.UrunTableAdapter urunTableAdapter1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}