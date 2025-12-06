namespace Library_Management_System.Books
{
    partial class BooksManager
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
            this.gradientPanel1 = new Library_Management_System.GradientPanel();
            this.btnGeri = new Library_Management_System.RoundedButtonControl();
            this.btnKitapGoruntule = new Library_Management_System.RoundedButtonControl();
            this.btnKitapSil = new Library_Management_System.RoundedButtonControl();
            this.btnKitapGuncelle = new Library_Management_System.RoundedButtonControl();
            this.btnKitapEkle = new Library_Management_System.RoundedButtonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 50F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Indigo;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Indigo;
            this.gradientPanel1.Controls.Add(this.btnGeri);
            this.gradientPanel1.Controls.Add(this.btnKitapGoruntule);
            this.gradientPanel1.Controls.Add(this.btnKitapSil);
            this.gradientPanel1.Controls.Add(this.btnKitapGuncelle);
            this.gradientPanel1.Controls.Add(this.btnKitapEkle);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(799, 502);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Violet;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BorderColor = System.Drawing.Color.White;
            this.btnGeri.BorderRadius = 40;
            this.btnGeri.BorderSize = 2;
            this.btnGeri.ButtonText = "";
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.HoverBackColor = System.Drawing.Color.Violet;
            this.btnGeri.Location = new System.Drawing.Point(254, 363);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.Size = new System.Drawing.Size(249, 90);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKitapGoruntule
            // 
            this.btnKitapGoruntule.BackColor = System.Drawing.Color.Transparent;
            this.btnKitapGoruntule.BorderColor = System.Drawing.Color.White;
            this.btnKitapGoruntule.BorderRadius = 40;
            this.btnKitapGoruntule.BorderSize = 2;
            this.btnKitapGoruntule.ButtonText = "";
            this.btnKitapGoruntule.FlatAppearance.BorderSize = 0;
            this.btnKitapGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnKitapGoruntule.HoverBackColor = System.Drawing.Color.Violet;
            this.btnKitapGoruntule.Location = new System.Drawing.Point(421, 243);
            this.btnKitapGoruntule.Name = "btnKitapGoruntule";
            this.btnKitapGoruntule.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnKitapGoruntule.Size = new System.Drawing.Size(249, 90);
            this.btnKitapGoruntule.TabIndex = 8;
            this.btnKitapGoruntule.Text = "Kitap Görüntüle";
            this.btnKitapGoruntule.UseVisualStyleBackColor = false;
            this.btnKitapGoruntule.Click += new System.EventHandler(this.btnKitapGoruntule_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.BackColor = System.Drawing.Color.Transparent;
            this.btnKitapSil.BorderColor = System.Drawing.Color.White;
            this.btnKitapSil.BorderRadius = 40;
            this.btnKitapSil.BorderSize = 2;
            this.btnKitapSil.ButtonText = "";
            this.btnKitapSil.FlatAppearance.BorderSize = 0;
            this.btnKitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapSil.ForeColor = System.Drawing.Color.White;
            this.btnKitapSil.HoverBackColor = System.Drawing.Color.Violet;
            this.btnKitapSil.Location = new System.Drawing.Point(109, 243);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnKitapSil.Size = new System.Drawing.Size(249, 90);
            this.btnKitapSil.TabIndex = 7;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = false;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnKitapGuncelle.BorderColor = System.Drawing.Color.White;
            this.btnKitapGuncelle.BorderRadius = 40;
            this.btnKitapGuncelle.BorderSize = 2;
            this.btnKitapGuncelle.ButtonText = "";
            this.btnKitapGuncelle.FlatAppearance.BorderSize = 0;
            this.btnKitapGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnKitapGuncelle.HoverBackColor = System.Drawing.Color.Violet;
            this.btnKitapGuncelle.Location = new System.Drawing.Point(421, 109);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnKitapGuncelle.Size = new System.Drawing.Size(249, 90);
            this.btnKitapGuncelle.TabIndex = 6;
            this.btnKitapGuncelle.Text = "Kitap Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = false;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnKitapEkle.BorderColor = System.Drawing.Color.White;
            this.btnKitapEkle.BorderRadius = 40;
            this.btnKitapEkle.BorderSize = 2;
            this.btnKitapEkle.ButtonText = "";
            this.btnKitapEkle.FlatAppearance.BorderSize = 0;
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ForeColor = System.Drawing.Color.White;
            this.btnKitapEkle.HoverBackColor = System.Drawing.Color.Violet;
            this.btnKitapEkle.Location = new System.Drawing.Point(109, 109);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnKitapEkle.Size = new System.Drawing.Size(249, 90);
            this.btnKitapEkle.TabIndex = 5;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Yönetimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BooksManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 502);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "BooksManager";
            this.Text = "BooksManager";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private RoundedButtonControl btnGeri;
        private RoundedButtonControl btnKitapGoruntule;
        private RoundedButtonControl btnKitapSil;
        private RoundedButtonControl btnKitapGuncelle;
        private RoundedButtonControl btnKitapEkle;
        private System.Windows.Forms.Timer timer1;
    }
}