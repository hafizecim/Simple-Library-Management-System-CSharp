namespace Library_Management_System
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new Library_Management_System.GradientPanel();
            this.btnKitapYonetimi = new Library_Management_System.RoundedButtonControl();
            this.btnYayineviYonetimi = new Library_Management_System.RoundedButtonControl();
            this.btnYazarYonetimi = new Library_Management_System.RoundedButtonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 50F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Indigo;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btnYazarYonetimi);
            this.gradientPanel1.Controls.Add(this.btnYayineviYonetimi);
            this.gradientPanel1.Controls.Add(this.btnKitapYonetimi);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(556, 405);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Violet;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // btnKitapYonetimi
            // 
            this.btnKitapYonetimi.BackColor = System.Drawing.Color.Transparent;
            this.btnKitapYonetimi.BorderColor = System.Drawing.Color.White;
            this.btnKitapYonetimi.BorderRadius = 40;
            this.btnKitapYonetimi.BorderSize = 2;
            this.btnKitapYonetimi.ButtonText = "Kitap Yönetimi";
            this.btnKitapYonetimi.FlatAppearance.BorderSize = 0;
            this.btnKitapYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnKitapYonetimi.HoverBackColor = System.Drawing.Color.Violet;
            this.btnKitapYonetimi.Location = new System.Drawing.Point(160, 74);
            this.btnKitapYonetimi.Name = "btnKitapYonetimi";
            this.btnKitapYonetimi.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnKitapYonetimi.Size = new System.Drawing.Size(215, 83);
            this.btnKitapYonetimi.TabIndex = 1;
            this.btnKitapYonetimi.UseVisualStyleBackColor = false;
            // 
            // btnYayineviYonetimi
            // 
            this.btnYayineviYonetimi.BackColor = System.Drawing.Color.Transparent;
            this.btnYayineviYonetimi.BorderColor = System.Drawing.Color.White;
            this.btnYayineviYonetimi.BorderRadius = 40;
            this.btnYayineviYonetimi.BorderSize = 2;
            this.btnYayineviYonetimi.ButtonText = "Yayınevi Yönetimi";
            this.btnYayineviYonetimi.FlatAppearance.BorderSize = 0;
            this.btnYayineviYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYayineviYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayineviYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnYayineviYonetimi.HoverBackColor = System.Drawing.Color.Violet;
            this.btnYayineviYonetimi.Location = new System.Drawing.Point(160, 178);
            this.btnYayineviYonetimi.Name = "btnYayineviYonetimi";
            this.btnYayineviYonetimi.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnYayineviYonetimi.Size = new System.Drawing.Size(215, 83);
            this.btnYayineviYonetimi.TabIndex = 2;
            this.btnYayineviYonetimi.UseVisualStyleBackColor = false;
            // 
            // btnYazarYonetimi
            // 
            this.btnYazarYonetimi.BackColor = System.Drawing.Color.Transparent;
            this.btnYazarYonetimi.BorderColor = System.Drawing.Color.White;
            this.btnYazarYonetimi.BorderRadius = 40;
            this.btnYazarYonetimi.BorderSize = 2;
            this.btnYazarYonetimi.ButtonText = "";
            this.btnYazarYonetimi.FlatAppearance.BorderSize = 0;
            this.btnYazarYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnYazarYonetimi.HoverBackColor = System.Drawing.Color.Violet;
            this.btnYazarYonetimi.Location = new System.Drawing.Point(160, 282);
            this.btnYazarYonetimi.Name = "btnYazarYonetimi";
            this.btnYazarYonetimi.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnYazarYonetimi.Size = new System.Drawing.Size(215, 83);
            this.btnYazarYonetimi.TabIndex = 3;
            this.btnYazarYonetimi.Text = "Yazar Yönetimi";
            this.btnYazarYonetimi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kütüphane Yönetimene Hoş Geldiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 405);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonuna Hoş Geldiniz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Timer timer1;
        private RoundedButtonControl btnKitapYonetimi;
        private System.Windows.Forms.Label label1;
        private RoundedButtonControl btnYazarYonetimi;
        private RoundedButtonControl btnYayineviYonetimi;
    }
}

