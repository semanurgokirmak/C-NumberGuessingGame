namespace ryTutulanSayiyiBulma
{
    partial class sayiTahminiForm
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSayiListe = new System.Windows.Forms.ListBox();
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsSayiTahmini = new System.Windows.Forms.ToolStrip();
            this.lblTutSayi = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnKapat = new System.Windows.Forms.ToolStripButton();
            this.btnSeviye = new System.Windows.Forms.ToolStripButton();
            this.tsSayiTahmini.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(134, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tahminler :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSayiListe
            // 
            this.lbSayiListe.FormattingEnabled = true;
            this.lbSayiListe.ItemHeight = 16;
            this.lbSayiListe.Location = new System.Drawing.Point(134, 73);
            this.lbSayiListe.Name = "lbSayiListe";
            this.lbSayiListe.Size = new System.Drawing.Size(125, 180);
            this.lbSayiListe.TabIndex = 10;
            // 
            // tbSayi
            // 
            this.tbSayi.Location = new System.Drawing.Point(12, 73);
            this.tbSayi.MaxLength = 2;
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(98, 24);
            this.tbSayi.TabIndex = 9;
            this.tbSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSayi_KeyPress);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sayı Giriniz :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsSayiTahmini
            // 
            this.tsSayiTahmini.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsSayiTahmini.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.toolStripSeparator1,
            this.btnKapat,
            this.btnSeviye});
            this.tsSayiTahmini.Location = new System.Drawing.Point(0, 0);
            this.tsSayiTahmini.Name = "tsSayiTahmini";
            this.tsSayiTahmini.Size = new System.Drawing.Size(278, 39);
            this.tsSayiTahmini.TabIndex = 7;
            this.tsSayiTahmini.Text = "toolStrip1";
            // 
            // lblTutSayi
            // 
            this.lblTutSayi.AutoSize = true;
            this.lblTutSayi.Location = new System.Drawing.Point(13, 239);
            this.lblTutSayi.Name = "lblTutSayi";
            this.lblTutSayi.Size = new System.Drawing.Size(0, 17);
            this.lblTutSayi.TabIndex = 12;
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = global::ryTutulanSayiyiBulma.Properties.Resources.yeni;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(36, 36);
            this.btnYeni.Text = "Yeni Oyun";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKapat.Image = global::ryTutulanSayiyiBulma.Properties.Resources.kapat;
            this.btnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(36, 36);
            this.btnKapat.Text = "Çıkış";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSeviye
            // 
            this.btnSeviye.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSeviye.Image = global::ryTutulanSayiyiBulma.Properties.Resources.ayarlar;
            this.btnSeviye.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeviye.Name = "btnSeviye";
            this.btnSeviye.Size = new System.Drawing.Size(36, 36);
            this.btnSeviye.Text = "toolStripButton1";
            this.btnSeviye.Click += new System.EventHandler(this.btnSeviye_Click);
            // 
            // sayiTahminiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 273);
            this.ControlBox = false;
            this.Controls.Add(this.lblTutSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSayiListe);
            this.Controls.Add(this.tbSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsSayiTahmini);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sayiTahminiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTULAN SAYIYI  BUL!";
            this.Load += new System.EventHandler(this.sayiTahminiForm_Load);
            this.tsSayiTahmini.ResumeLayout(false);
            this.tsSayiTahmini.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnKapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSayiListe;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsSayiTahmini;
        private System.Windows.Forms.Label lblTutSayi;
        private System.Windows.Forms.ToolStripButton btnSeviye;
    }
}

