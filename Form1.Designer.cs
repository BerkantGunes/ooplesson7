namespace Ornek3
{
    partial class Form1
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKarekok = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnUs = new System.Windows.Forms.Button();
            this.btnMutlak = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnYukarı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(80, 13);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(148, 23);
            this.txtSayi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(80, 44);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(148, 23);
            this.txtSonuc.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sonuç";
            // 
            // btnKarekok
            // 
            this.btnKarekok.Location = new System.Drawing.Point(309, 16);
            this.btnKarekok.Name = "btnKarekok";
            this.btnKarekok.Size = new System.Drawing.Size(75, 23);
            this.btnKarekok.TabIndex = 2;
            this.btnKarekok.Text = "Karekök";
            this.btnKarekok.UseVisualStyleBackColor = true;
            this.btnKarekok.Click += new System.EventHandler(this.btnKarekok_Click);
            // 
            // btnPI
            // 
            this.btnPI.Location = new System.Drawing.Point(309, 47);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(75, 23);
            this.btnPI.TabIndex = 2;
            this.btnPI.Text = "PI";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(309, 76);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 23);
            this.btnE.TabIndex = 2;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnUs
            // 
            this.btnUs.Location = new System.Drawing.Point(309, 105);
            this.btnUs.Name = "btnUs";
            this.btnUs.Size = new System.Drawing.Size(75, 23);
            this.btnUs.TabIndex = 3;
            this.btnUs.Text = "Üs";
            this.btnUs.UseVisualStyleBackColor = true;
            this.btnUs.Click += new System.EventHandler(this.btnUs_Click);
            // 
            // btnMutlak
            // 
            this.btnMutlak.Location = new System.Drawing.Point(309, 135);
            this.btnMutlak.Name = "btnMutlak";
            this.btnMutlak.Size = new System.Drawing.Size(75, 23);
            this.btnMutlak.TabIndex = 4;
            this.btnMutlak.Text = "Mutlak";
            this.btnMutlak.UseVisualStyleBackColor = true;
            this.btnMutlak.Click += new System.EventHandler(this.btnMutlak_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(309, 164);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(141, 23);
            this.btnAsagi.TabIndex = 5;
            this.btnAsagi.Text = "Aşağı Yuvarla";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnYukarı
            // 
            this.btnYukarı.Location = new System.Drawing.Point(309, 193);
            this.btnYukarı.Name = "btnYukarı";
            this.btnYukarı.Size = new System.Drawing.Size(141, 23);
            this.btnYukarı.TabIndex = 5;
            this.btnYukarı.Text = "Yukarı Yuvarla";
            this.btnYukarı.UseVisualStyleBackColor = true;
            this.btnYukarı.Click += new System.EventHandler(this.btnYukarı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 425);
            this.Controls.Add(this.btnYukarı);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnMutlak);
            this.Controls.Add(this.btnUs);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.btnKarekok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSayi);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKarekok;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnUs;
        private System.Windows.Forms.Button btnMutlak;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnYukarı;
    }
}

