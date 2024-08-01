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
    public partial class sayiTahminiForm : Form
    {
        public sayiTahminiForm()
        {
            InitializeComponent();
        }
        #region Değişkenler ve Tanımlamalar
        int TutulanSayi = 0;
        int islemSayisi = 0;
        public int SeviyeKontrol = 0;
        public SeviyeForm seviyefrm;
        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void SayisalControl(object sender,KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        }
        private void SayiUretme()
        {
            Random rSayi = new Random();
            TutulanSayi = rSayi.Next(1, 101);
        }
        #endregion

        #region Nesne Tanımlı Olaylar

        #endregion

        private void sayiTahminiForm_Load(object sender, EventArgs e)
        {
            SayiUretme();
            tbSayi.Select();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            tbSayi.Clear();
            lbSayiListe.Items.Clear();
            SayiUretme();
            islemSayisi = 0;
            tbSayi.Enabled = true;
            tbSayi.Select();
        }

        private void tbSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            int TahminiSayi = 0;
            
            SayisalControl(sender, e);
            if (e.KeyChar==13)
            {
                TahminiSayi = Int16.Parse(tbSayi.Text);
                islemSayisi++;
                if (TahminiSayi>TutulanSayi)
                {
                    MessageBox.Show("Tahmin Değeri\n Tutulan Sayıdan Büyük! \nTahmini Düşürünüz", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbSayiListe.Items.Add(islemSayisi.ToString ()+".Tahmin => "+TahminiSayi.ToString());
                    tbSayi.Clear();
                    tbSayi.Select();
                }
                else if (TahminiSayi<TutulanSayi)
                {
                    MessageBox.Show("Tahmin Değeri\n Tutulan Sayıdan Küçük! \nTahmini Yükseltiniz", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbSayiListe.Items.Add(islemSayisi.ToString ()+".Tahmin => "+TahminiSayi.ToString());
                    tbSayi.Clear();
                    tbSayi.Select();
                }
                else
                {
                    MessageBox.Show("Bravo! Buldunuz\n Tutulan Sayı= "+TutulanSayi.ToString (), "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbSayiListe.Items.Add(islemSayisi.ToString ()+".Tahmin => "+TahminiSayi.ToString());
                    if (MessageBox.Show("Yeniden Tahmin Etmek \nister misiniz?", "Onay",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        btnYeni.PerformClick();
                    }
                    else
                        tbSayi.Enabled = false;
                }
                if (islemSayisi>=SeviyeKontrol & TutulanSayi !=TahminiSayi)
                {
                    if (MessageBox.Show("Tahmin Etme Hakkınız Bitti\n Tutulan Sayı= " + TutulanSayi.ToString() +
                        "\nTekrar Denemek istermisiniz", "Onay", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        btnYeni.PerformClick();
                    }
                    else
                        tbSayi.Enabled = false;
                }
            }
        }

        private void btnSeviye_Click(object sender, EventArgs e)
        {
            seviyefrm = new SeviyeForm();
            seviyefrm.afrm = this;
            seviyefrm.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama \n Sonlandırılsın mı?", "Çıkış Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
