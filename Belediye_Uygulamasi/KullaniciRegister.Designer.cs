namespace Belediye_Uygulamasi
{
    partial class KullaniciRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciRegister));
            this.mainPNL = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBVergiNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBTamAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBCep = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBTC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBPasswordAgain = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainDRAG = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainPNL.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPNL
            // 
            this.mainPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.mainPNL.Controls.Add(this.guna2ImageButton1);
            this.mainPNL.Controls.Add(this.guna2ImageButton2);
            this.mainPNL.Controls.Add(this.guna2Panel1);
            this.mainPNL.Controls.Add(this.label10);
            this.mainPNL.Location = new System.Drawing.Point(0, 0);
            this.mainPNL.Margin = new System.Windows.Forms.Padding(4);
            this.mainPNL.Name = "mainPNL";
            this.mainPNL.Size = new System.Drawing.Size(1040, 700);
            this.mainPNL.TabIndex = 6;
            this.mainPNL.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPNL_Paint);
            this.mainPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPNL_MouseDown);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.Location = new System.Drawing.Point(960, 12);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.Size = new System.Drawing.Size(29, 31);
            this.guna2ImageButton1.TabIndex = 10;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton2.Location = new System.Drawing.Point(993, 12);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton2.Size = new System.Drawing.Size(29, 31);
            this.guna2ImageButton2.TabIndex = 9;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.textBVergiNo);
            this.guna2Panel1.Controls.Add(this.textBTamAd);
            this.guna2Panel1.Controls.Add(this.textBCep);
            this.guna2Panel1.Controls.Add(this.TextBTC);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.textBPasswordAgain);
            this.guna2Panel1.Controls.Add(this.guna2CheckBox1);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.textBPassword);
            this.guna2Panel1.Controls.Add(this.textBUsername);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(95, 107);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(845, 493);
            this.guna2Panel1.TabIndex = 1;
            // 
            // textBVergiNo
            // 
            this.textBVergiNo.Animated = true;
            this.textBVergiNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBVergiNo.BorderRadius = 5;
            this.textBVergiNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBVergiNo.DefaultText = "";
            this.textBVergiNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBVergiNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBVergiNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBVergiNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBVergiNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBVergiNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBVergiNo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBVergiNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBVergiNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBVergiNo.Location = new System.Drawing.Point(445, 154);
            this.textBVergiNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBVergiNo.Name = "textBVergiNo";
            this.textBVergiNo.PasswordChar = '\0';
            this.textBVergiNo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBVergiNo.PlaceholderText = "Vergi No (Varsa)";
            this.textBVergiNo.SelectedText = "";
            this.textBVergiNo.Size = new System.Drawing.Size(334, 49);
            this.textBVergiNo.TabIndex = 12;
            // 
            // textBTamAd
            // 
            this.textBTamAd.Animated = true;
            this.textBTamAd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBTamAd.BorderRadius = 5;
            this.textBTamAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBTamAd.DefaultText = "";
            this.textBTamAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBTamAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBTamAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBTamAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBTamAd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBTamAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBTamAd.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBTamAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBTamAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBTamAd.Location = new System.Drawing.Point(328, 95);
            this.textBTamAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBTamAd.Name = "textBTamAd";
            this.textBTamAd.PasswordChar = '\0';
            this.textBTamAd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBTamAd.PlaceholderText = "Tam Ad";
            this.textBTamAd.SelectedText = "";
            this.textBTamAd.Size = new System.Drawing.Size(451, 49);
            this.textBTamAd.TabIndex = 11;
            this.textBTamAd.TextChanged += new System.EventHandler(this.textBTamAd_TextChanged);
            // 
            // textBCep
            // 
            this.textBCep.Animated = true;
            this.textBCep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBCep.BorderRadius = 5;
            this.textBCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBCep.DefaultText = "";
            this.textBCep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBCep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBCep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBCep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBCep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBCep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBCep.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBCep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBCep.Location = new System.Drawing.Point(71, 272);
            this.textBCep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBCep.Name = "textBCep";
            this.textBCep.PasswordChar = '\0';
            this.textBCep.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBCep.PlaceholderText = "Cep Telefonu (Istege Bagli)";
            this.textBCep.SelectedText = "";
            this.textBCep.Size = new System.Drawing.Size(708, 49);
            this.textBCep.TabIndex = 10;
            // 
            // TextBTC
            // 
            this.TextBTC.Animated = true;
            this.TextBTC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.TextBTC.BorderRadius = 5;
            this.TextBTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBTC.DefaultText = "";
            this.TextBTC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBTC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBTC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBTC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBTC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.TextBTC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBTC.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.TextBTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.TextBTC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.TextBTC.Location = new System.Drawing.Point(71, 95);
            this.TextBTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBTC.MaxLength = 11;
            this.TextBTC.Name = "TextBTC";
            this.TextBTC.PasswordChar = '\0';
            this.TextBTC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.TextBTC.PlaceholderText = "TC";
            this.TextBTC.SelectedText = "";
            this.TextBTC.Size = new System.Drawing.Size(241, 49);
            this.TextBTC.TabIndex = 9;
            this.TextBTC.TextChanged += new System.EventHandler(this.TextBTC_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(419, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 8;
            // 
            // textBPasswordAgain
            // 
            this.textBPasswordAgain.Animated = true;
            this.textBPasswordAgain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBPasswordAgain.BorderRadius = 5;
            this.textBPasswordAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBPasswordAgain.DefaultText = "";
            this.textBPasswordAgain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBPasswordAgain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBPasswordAgain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBPasswordAgain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBPasswordAgain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBPasswordAgain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBPasswordAgain.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBPasswordAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBPasswordAgain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBPasswordAgain.Location = new System.Drawing.Point(405, 213);
            this.textBPasswordAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBPasswordAgain.Name = "textBPasswordAgain";
            this.textBPasswordAgain.PasswordChar = '\0';
            this.textBPasswordAgain.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBPasswordAgain.PlaceholderText = "Parolanız Tekrar";
            this.textBPasswordAgain.SelectedText = "";
            this.textBPasswordAgain.Size = new System.Drawing.Size(374, 49);
            this.textBPasswordAgain.TabIndex = 7;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.guna2CheckBox1.Location = new System.Drawing.Point(368, 231);
            this.guna2CheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox1.TabIndex = 6;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(245)))));
            this.label6.Location = new System.Drawing.Point(307, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giris Yap";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label7.Location = new System.Drawing.Point(67, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Zaten Bir Hesabiniz Var Mi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label8.Location = new System.Drawing.Point(16, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kullanıcı Girişi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.label9.Location = new System.Drawing.Point(13, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 35);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kütahya Belediyesi";
            // 
            // textBPassword
            // 
            this.textBPassword.Animated = true;
            this.textBPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBPassword.BorderRadius = 5;
            this.textBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBPassword.DefaultText = "";
            this.textBPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBPassword.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBPassword.Location = new System.Drawing.Point(71, 213);
            this.textBPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBPassword.Name = "textBPassword";
            this.textBPassword.PasswordChar = '\0';
            this.textBPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBPassword.PlaceholderText = "Parolanız";
            this.textBPassword.SelectedText = "";
            this.textBPassword.Size = new System.Drawing.Size(326, 49);
            this.textBPassword.TabIndex = 2;
            // 
            // textBUsername
            // 
            this.textBUsername.Animated = true;
            this.textBUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.textBUsername.BorderRadius = 5;
            this.textBUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBUsername.DefaultText = "";
            this.textBUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.textBUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBUsername.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.textBUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.textBUsername.Location = new System.Drawing.Point(71, 154);
            this.textBUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBUsername.Name = "textBUsername";
            this.textBUsername.PasswordChar = '\0';
            this.textBUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.textBUsername.PlaceholderText = "Kullanıcı Adınız";
            this.textBUsername.SelectedText = "";
            this.textBUsername.Size = new System.Drawing.Size(366, 49);
            this.textBUsername.TabIndex = 1;
            this.textBUsername.TextChanged += new System.EventHandler(this.textBUsername_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(150)))));
            this.guna2Button1.Location = new System.Drawing.Point(71, 358);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(708, 49);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Kaydol";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label10.Location = new System.Drawing.Point(9, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kullanıcı Kayit";
            // 
            // mainDRAG
            // 
            this.mainDRAG.DockIndicatorTransparencyValue = 0.6D;
            this.mainDRAG.UseTransparentDrag = true;
            // 
            // KullaniciRegister
            // 
            this.AcceptButton = this.guna2Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 700);
            this.Controls.Add(this.mainPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciRegister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciRegister_FormClosing);
            this.Load += new System.EventHandler(this.KullaniciRegister_Load);
            this.mainPNL.ResumeLayout(false);
            this.mainPNL.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPNL;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox textBPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBUsername;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2DragControl mainDRAG;
        private Guna.UI2.WinForms.Guna2TextBox textBPasswordAgain;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBCep;
        private Guna.UI2.WinForms.Guna2TextBox TextBTC;
        private Guna.UI2.WinForms.Guna2TextBox textBVergiNo;
        private Guna.UI2.WinForms.Guna2TextBox textBTamAd;
    }
}