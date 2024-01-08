namespace WindowsFormsApp1
{
    partial class ogretmenkayit
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
            this.grbogrtkayıt = new System.Windows.Forms.GroupBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.grbogrtkayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbogrtkayıt
            // 
            this.grbogrtkayıt.Controls.Add(this.btnbul);
            this.grbogrtkayıt.Controls.Add(this.btnkaydet);
            this.grbogrtkayıt.Controls.Add(this.lbltc);
            this.grbogrtkayıt.Controls.Add(this.lblsoyad);
            this.grbogrtkayıt.Controls.Add(this.lblAd);
            this.grbogrtkayıt.Controls.Add(this.txttc);
            this.grbogrtkayıt.Controls.Add(this.txtsoyad);
            this.grbogrtkayıt.Controls.Add(this.txtad);
            this.grbogrtkayıt.Location = new System.Drawing.Point(9, 10);
            this.grbogrtkayıt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbogrtkayıt.Name = "grbogrtkayıt";
            this.grbogrtkayıt.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbogrtkayıt.Size = new System.Drawing.Size(290, 188);
            this.grbogrtkayıt.TabIndex = 0;
            this.grbogrtkayıt.TabStop = false;
            this.grbogrtkayıt.Text = "Öğretmen Kayıt";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(68, 158);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(62, 19);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(12, 109);
            this.lbltc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(34, 13);
            this.lbltc.TabIndex = 5;
            this.lbltc.Text = "TcNo";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(5, 72);
            this.lblsoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(37, 13);
            this.lblsoyad.TabIndex = 4;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 32);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(80, 109);
            this.txttc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(90, 20);
            this.txttc.TabIndex = 2;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(80, 70);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(90, 20);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(80, 32);
            this.txtad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(90, 20);
            this.txtad.TabIndex = 0;
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(195, 30);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(90, 23);
            this.btnbul.TabIndex = 7;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            // 
            // ogretmenkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 251);
            this.Controls.Add(this.grbogrtkayıt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ogretmenkayit";
            this.Text = "Form1";
            this.grbogrtkayıt.ResumeLayout(false);
            this.grbogrtkayıt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbogrtkayıt;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnbul;
    }
}

