
namespace ryTutulanSayiyiBulma
{
    partial class SeviyeForm
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
            this.gbSecim = new System.Windows.Forms.GroupBox();
            this.rbGiris = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbPro = new System.Windows.Forms.RadioButton();
            this.btnOnay = new System.Windows.Forms.Button();
            this.gbSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSecim
            // 
            this.gbSecim.Controls.Add(this.rbPro);
            this.gbSecim.Controls.Add(this.rbOrta);
            this.gbSecim.Controls.Add(this.rbGiris);
            this.gbSecim.Location = new System.Drawing.Point(12, 12);
            this.gbSecim.Name = "gbSecim";
            this.gbSecim.Size = new System.Drawing.Size(201, 151);
            this.gbSecim.TabIndex = 0;
            this.gbSecim.TabStop = false;
            this.gbSecim.Text = "Oyun Seviyesini Seçiniz";
            // 
            // rbGiris
            // 
            this.rbGiris.AutoSize = true;
            this.rbGiris.Location = new System.Drawing.Point(21, 32);
            this.rbGiris.Name = "rbGiris";
            this.rbGiris.Size = new System.Drawing.Size(57, 21);
            this.rbGiris.TabIndex = 0;
            this.rbGiris.TabStop = true;
            this.rbGiris.Text = "Giriş";
            this.rbGiris.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(21, 68);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(57, 21);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbPro
            // 
            this.rbPro.AutoSize = true;
            this.rbPro.Location = new System.Drawing.Point(21, 107);
            this.rbPro.Name = "rbPro";
            this.rbPro.Size = new System.Drawing.Size(49, 21);
            this.rbPro.TabIndex = 2;
            this.rbPro.TabStop = true;
            this.rbPro.Text = "Pro";
            this.rbPro.UseVisualStyleBackColor = true;
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(135, 169);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 33);
            this.btnOnay.TabIndex = 3;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // SeviyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 232);
            this.ControlBox = false;
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.gbSecim);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeviyeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SeviyeForm";
            this.gbSecim.ResumeLayout(false);
            this.gbSecim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSecim;
        private System.Windows.Forms.RadioButton rbPro;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbGiris;
        private System.Windows.Forms.Button btnOnay;
    }
}