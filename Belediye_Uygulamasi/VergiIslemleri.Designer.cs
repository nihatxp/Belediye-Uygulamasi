namespace Belediye_Uygulamasi
{
    partial class VergiIslemleri
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnUygula = new Guna.UI2.WinForms.Guna2Button();
            this.TextBVergiNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBTC = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBBorcMiktari = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.listView1.ForeColor = System.Drawing.SystemColors.Info;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 258);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1160, 408);
            this.listView1.TabIndex = 82;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnUygula
            // 
            this.btnUygula.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUygula.Animated = true;
            this.btnUygula.BorderRadius = 5;
            this.btnUygula.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUygula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUygula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUygula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUygula.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.btnUygula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUygula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnUygula.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(150)))));
            this.btnUygula.Location = new System.Drawing.Point(596, 157);
            this.btnUygula.Margin = new System.Windows.Forms.Padding(4);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(519, 49);
            this.btnUygula.TabIndex = 94;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // TextBVergiNo
            // 
            this.TextBVergiNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBVergiNo.Animated = true;
            this.TextBVergiNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.TextBVergiNo.BorderRadius = 5;
            this.TextBVergiNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBVergiNo.DefaultText = "";
            this.TextBVergiNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBVergiNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBVergiNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBVergiNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBVergiNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.TextBVergiNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBVergiNo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.TextBVergiNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.TextBVergiNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.TextBVergiNo.Location = new System.Drawing.Point(596, 98);
            this.TextBVergiNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBVergiNo.Name = "TextBVergiNo";
            this.TextBVergiNo.PasswordChar = '\0';
            this.TextBVergiNo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.TextBVergiNo.PlaceholderText = "Vergi No";
            this.TextBVergiNo.SelectedText = "";
            this.TextBVergiNo.Size = new System.Drawing.Size(519, 49);
            this.TextBVergiNo.TabIndex = 106;
            // 
            // textBTC
            // 
            this.textBTC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBTC.Animated = true;
            this.textBTC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBTC.BorderRadius = 5;
            this.textBTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBTC.DefaultText = "";
            this.textBTC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBTC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBTC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBTC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBTC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBTC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBTC.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBTC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBTC.Location = new System.Drawing.Point(39, 98);
            this.textBTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBTC.Name = "textBTC";
            this.textBTC.PasswordChar = '\0';
            this.textBTC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBTC.PlaceholderText = "TC";
            this.textBTC.ReadOnly = true;
            this.textBTC.SelectedText = "";
            this.textBTC.Size = new System.Drawing.Size(527, 49);
            this.textBTC.TabIndex = 105;
            this.textBTC.TextChanged += new System.EventHandler(this.textBTC_TextChanged);
            // 
            // textBBorcMiktari
            // 
            this.textBBorcMiktari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBBorcMiktari.Animated = true;
            this.textBBorcMiktari.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBBorcMiktari.BorderRadius = 5;
            this.textBBorcMiktari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBBorcMiktari.DefaultText = "";
            this.textBBorcMiktari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBBorcMiktari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBBorcMiktari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBBorcMiktari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBBorcMiktari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBBorcMiktari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBBorcMiktari.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBBorcMiktari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBBorcMiktari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBBorcMiktari.Location = new System.Drawing.Point(39, 157);
            this.textBBorcMiktari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBBorcMiktari.Name = "textBBorcMiktari";
            this.textBBorcMiktari.PasswordChar = '\0';
            this.textBBorcMiktari.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBBorcMiktari.PlaceholderText = "Borc Miktari";
            this.textBBorcMiktari.SelectedText = "";
            this.textBBorcMiktari.Size = new System.Drawing.Size(527, 49);
            this.textBBorcMiktari.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1104, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Toplam :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.label2.Location = new System.Drawing.Point(306, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 110;
            this.label2.Text = "Filtrele";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(385, 16);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(376, 36);
            this.guna2ComboBox1.TabIndex = 108;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // VergiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBBorcMiktari);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBVergiNo);
            this.Controls.Add(this.textBTC);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1104, 670);
            this.Name = "VergiIslemleri";
            this.Size = new System.Drawing.Size(1169, 670);
            this.Load += new System.EventHandler(this.VergiIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Button btnUygula;
        private Guna.UI2.WinForms.Guna2TextBox TextBVergiNo;
        private Guna.UI2.WinForms.Guna2TextBox textBTC;
        private Guna.UI2.WinForms.Guna2TextBox textBBorcMiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}
