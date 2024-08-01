using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryTutulanSayiyiBulma
{
    public partial class SeviyeForm : Form
    {
        public SeviyeForm()
        {
            InitializeComponent();
            rbGiris.Checked = false;
            rbOrta.Checked = false;
            rbPro.Checked = false;
        }

        public sayiTahminiForm afrm;

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (rbGiris.Checked)
                afrm.SeviyeKontrol = 10;
            else if (rbOrta.Checked)
                afrm.SeviyeKontrol = 7;
            else if (rbPro.Checked)
                afrm.SeviyeKontrol = 5;
            else
                MessageBox.Show("Seçim Yap", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (afrm.SeviyeKontrol > 0)
                this.Close();
        }
    }
}
