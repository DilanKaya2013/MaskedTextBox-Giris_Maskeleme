namespace MaskedTextBox_Giris_maskeleme
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
            this.lblTc = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblDgTarihi = new System.Windows.Forms.Label();
            this.lblKartN = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.mtxTC = new System.Windows.Forms.MaskedTextBox();
            this.mtxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtxDgTarih = new System.Windows.Forms.MaskedTextBox();
            this.mtxIp = new System.Windows.Forms.MaskedTextBox();
            this.mtxKart = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(35, 24);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(41, 13);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "T.C.No";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(33, 64);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblDgTarihi
            // 
            this.lblDgTarihi.AutoSize = true;
            this.lblDgTarihi.Location = new System.Drawing.Point(6, 104);
            this.lblDgTarihi.Name = "lblDgTarihi";
            this.lblDgTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblDgTarihi.TabIndex = 2;
            this.lblDgTarihi.Text = "Doğum Tarihi";
            // 
            // lblKartN
            // 
            this.lblKartN.AutoSize = true;
            this.lblKartN.Location = new System.Drawing.Point(3, 144);
            this.lblKartN.Name = "lblKartN";
            this.lblKartN.Size = new System.Drawing.Size(73, 13);
            this.lblKartN.TabIndex = 3;
            this.lblKartN.Text = "Kart Numarası";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(29, 184);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(47, 13);
            this.lblIp.TabIndex = 4;
            this.lblIp.Text = "IP Adres";
            // 
            // mtxTC
            // 
            this.mtxTC.Location = new System.Drawing.Point(82, 17);
            this.mtxTC.Name = "mtxTC";
            this.mtxTC.Size = new System.Drawing.Size(100, 20);
            this.mtxTC.TabIndex = 5;
            // 
            // mtxTelefon
            // 
            this.mtxTelefon.Location = new System.Drawing.Point(82, 57);
            this.mtxTelefon.Name = "mtxTelefon";
            this.mtxTelefon.Size = new System.Drawing.Size(100, 20);
            this.mtxTelefon.TabIndex = 6;
            // 
            // mtxDgTarih
            // 
            this.mtxDgTarih.Location = new System.Drawing.Point(82, 97);
            this.mtxDgTarih.Name = "mtxDgTarih";
            this.mtxDgTarih.Size = new System.Drawing.Size(100, 20);
            this.mtxDgTarih.TabIndex = 7;
            // 
            // mtxIp
            // 
            this.mtxIp.Location = new System.Drawing.Point(82, 177);
            this.mtxIp.Name = "mtxIp";
            this.mtxIp.Size = new System.Drawing.Size(100, 20);
            this.mtxIp.TabIndex = 8;
            // 
            // mtxKart
            // 
            this.mtxKart.Location = new System.Drawing.Point(82, 137);
            this.mtxKart.Name = "mtxKart";
            this.mtxKart.Size = new System.Drawing.Size(100, 20);
            this.mtxKart.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(213, 233);
            this.Controls.Add(this.mtxKart);
            this.Controls.Add(this.mtxIp);
            this.Controls.Add(this.mtxDgTarih);
            this.Controls.Add(this.mtxTelefon);
            this.Controls.Add(this.mtxTC);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lblKartN);
            this.Controls.Add(this.lblDgTarihi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblDgTarihi;
        private System.Windows.Forms.Label lblKartN;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.MaskedTextBox mtxTC;
        private System.Windows.Forms.MaskedTextBox mtxTelefon;
        private System.Windows.Forms.MaskedTextBox mtxDgTarih;
        private System.Windows.Forms.MaskedTextBox mtxIp;
        private System.Windows.Forms.MaskedTextBox mtxKart;
    }
}

