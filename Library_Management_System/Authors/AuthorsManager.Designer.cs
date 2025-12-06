namespace Library_Management_System.Authors
{
    partial class AuthorsManager
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGeriYazar = new Library_Management_System.RoundedButtonControl();
            this.btnYazarGoruntule = new Library_Management_System.RoundedButtonControl();
            this.btnYazarSil = new Library_Management_System.RoundedButtonControl();
            this.btnYazarGuncelle = new Library_Management_System.RoundedButtonControl();
            this.btnYazarEkle = new Library_Management_System.RoundedButtonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 50F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Indigo;
            this.gradientPanel1.Controls.Add(this.btnGeriYazar);
            this.gradientPanel1.Controls.Add(this.btnYazarGoruntule);
            this.gradientPanel1.Controls.Add(this.btnYazarSil);
            this.gradientPanel1.Controls.Add(this.btnYazarGuncelle);
            this.gradientPanel1.Controls.Add(this.btnYazarEkle);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Violet;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGeriYazar
            // 
            this.btnGeriYazar.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriYazar.BorderColor = System.Drawing.Color.White;
            this.btnGeriYazar.BorderRadius = 40;
            this.btnGeriYazar.BorderSize = 2;
            this.btnGeriYazar.ButtonText = "";
            this.btnGeriYazar.FlatAppearance.BorderSize = 0;
            this.btnGeriYazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriYazar.ForeColor = System.Drawing.Color.White;
            this.btnGeriYazar.HoverBackColor = System.Drawing.Color.Violet;
            this.btnGeriYazar.Location = new System.Drawing.Point(265, 347);
            this.btnGeriYazar.Name = "btnGeriYazar";
            this.btnGeriYazar.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnGeriYazar.Size = new System.Drawing.Size(249, 90);
            this.btnGeriYazar.TabIndex = 15;
            this.btnGeriYazar.Text = "Geri";
            this.btnGeriYazar.UseVisualStyleBackColor = false;
            this.btnGeriYazar.Click += new System.EventHandler(this.btnGeriYazar_Click);
            // 
            // btnYazarGoruntule
            // 
            this.btnYazarGoruntule.BackColor = System.Drawing.Color.Transparent;
            this.btnYazarGoruntule.BorderColor = System.Drawing.Color.White;
            this.btnYazarGoruntule.BorderRadius = 40;
            this.btnYazarGoruntule.BorderSize = 2;
            this.btnYazarGoruntule.ButtonText = "";
            this.btnYazarGoruntule.FlatAppearance.BorderSize = 0;
            this.btnYazarGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnYazarGoruntule.HoverBackColor = System.Drawing.Color.Violet;
            this.btnYazarGoruntule.Location = new System.Drawing.Point(432, 227);
            this.btnYazarGoruntule.Name = "btnYazarGoruntule";
            this.btnYazarGoruntule.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnYazarGoruntule.Size = new System.Drawing.Size(249, 90);
            this.btnYazarGoruntule.TabIndex = 14;
            this.btnYazarGoruntule.Text = "Yazar Görüntüle";
            this.btnYazarGoruntule.UseVisualStyleBackColor = false;
            this.btnYazarGoruntule.Click += new System.EventHandler(this.btnYazarGoruntule_Click);
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.BackColor = System.Drawing.Color.Transparent;
            this.btnYazarSil.BorderColor = System.Drawing.Color.White;
            this.btnYazarSil.BorderRadius = 40;
            this.btnYazarSil.BorderSize = 2;
            this.btnYazarSil.ButtonText = "";
            this.btnYazarSil.FlatAppearance.BorderSize = 0;
            this.btnYazarSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarSil.ForeColor = System.Drawing.Color.White;
            this.btnYazarSil.HoverBackColor = System.Drawing.Color.Violet;
            this.btnYazarSil.Location = new System.Drawing.Point(120, 227);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnYazarSil.Size = new System.Drawing.Size(249, 90);
            this.btnYazarSil.TabIndex = 13;
            this.btnYazarSil.Text = "Yazar Sil";
            this.btnYazarSil.UseVisualStyleBackColor = false;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnYazarGuncelle.BorderColor = System.Drawing.Color.White;
            this.btnYazarGuncelle.BorderRadius = 40;
            this.btnYazarGuncelle.BorderSize = 2;
            this.btnYazarGuncelle.ButtonText = "";
            this.btnYazarGuncelle.FlatAppearance.BorderSize = 0;
            this.btnYazarGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnYazarGuncelle.HoverBackColor = System.Drawing.Color.Violet;
            this.btnYazarGuncelle.Location = new System.Drawing.Point(432, 93);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnYazarGuncelle.Size = new System.Drawing.Size(249, 90);
            this.btnYazarGuncelle.TabIndex = 12;
            this.btnYazarGuncelle.Text = "Yazar Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = false;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnYazarEkle.BorderColor = System.Drawing.Color.White;
            this.btnYazarEkle.BorderRadius = 40;
            this.btnYazarEkle.BorderSize = 2;
            this.btnYazarEkle.ButtonText = "";
            this.btnYazarEkle.FlatAppearance.BorderSize = 0;
            this.btnYazarEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarEkle.ForeColor = System.Drawing.Color.White;
            this.btnYazarEkle.HoverBackColor = System.Drawing.Color.Violet;
            this.btnYazarEkle.Location = new System.Drawing.Point(120, 93);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnYazarEkle.Size = new System.Drawing.Size(249, 90);
            this.btnYazarEkle.TabIndex = 11;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = false;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yazar Yönetimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AuthorsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "AuthorsManager";
            this.Text = "AuthorsManager";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Timer timer1;
        private RoundedButtonControl btnGeriYazar;
        private RoundedButtonControl btnYazarGoruntule;
        private RoundedButtonControl btnYazarSil;
        private RoundedButtonControl btnYazarGuncelle;
        private RoundedButtonControl btnYazarEkle;
        private System.Windows.Forms.Label label1;
    }
}