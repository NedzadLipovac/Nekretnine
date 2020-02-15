using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using Nekretnine.Model.Requests;
using Nekretnine.WinUI.Helper;
using System.IO;

namespace Nekretnine.WinUI.Klijenti
{
    public partial class frmKlijenti : Form
    {
        private readonly APIService _service = new APIService("Klijent");
        private readonly APIService _gradService = new APIService("Grad");
        KlijentUpsertRequest UrediKlijentRequest = new KlijentUpsertRequest();
        KlijentUpsertRequest DodajKlijentRequest = new KlijentUpsertRequest();

        private int _KlijentId;

        public frmKlijenti()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await PretragaKlijenata();
        }
        private async Task PretragaKlijenata()
        {
            var search = new KlijentSearchRequest();
            //search = null;
            var GradObj = cmbGrad.SelectedValue;
            if (GradObj == null)
                GradObj = 0;
            if (int.TryParse(GradObj.ToString(), out int GradId))
            {
                search.GradId = GradId;
            }
            if (txtIme.Text != "")
            {
                search.Ime = txtIme.Text.ToLower();
            }
            if (txtPrezime.Text != "")
            {
                search.Prezime = txtPrezime.Text.ToLower();
            }
            if (txtEmail.Text != "")
            {
                search.Email = txtEmail.Text.ToLower();
            }
            search.Status = chbAktivan.Checked;
            var result = await _service.Get<List<Model.Models.Klijent>>(search);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }
        private async Task LoadGradovi(ComboBox cmb)
        {
            var result = await _gradService.Get<List<Model.Models.Grad>>(null);
            result.Insert(0, new Model.Models.Grad());

            ComboBoxLoad<Model.Models.Grad> cmbLoad = new ComboBoxLoad<Model.Models.Grad>();
            cmbLoad.Load(cmb, result, "Naziv", "GradId");
        }


        private async void frmKlijenti_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(DetaljiKlijentaa);
            this.dgvKlijenti.SelectionMode =
              DataGridViewSelectionMode.FullRowSelect;
            await LoadGradovi(cmbGrad);
            await LoadGradovi(cmbGradNovi);
        }


        private async void dgvKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tabControl1.TabPages.Remove(DetaljiKlijentaa);
            int Id = 0;
            if (dgvKlijenti.RowCount > 0)
            {
                var val = dgvKlijenti.SelectedRows[0].Cells[0].Value;
                Id = int.Parse(val.ToString());
                _KlijentId = Id;
                await UcitajEditTab();
                tabControl1.TabPages.Add(DetaljiKlijentaa);
                this.tabControl1.SelectTab(DetaljiKlijentaa);
            }
        }

        //Učitavanje  tab page-a za uređivanje podatka o klijentu
        private async Task UcitajEditTab()
        {
            var user = await _service.GetById<Model.Models.Klijent>(_KlijentId);
            var grad = await _gradService.GetById<Model.Models.Grad>(user.GradId);

            await LoadGradovi(cmbGrad);

            UrediKlijentRequest.Ime = user.Ime;
            UrediKlijentRequest.Prezime = user.Prezime;
            UrediKlijentRequest.Adresa = user.Adresa;

            UrediKlijentRequest.Email = user.Email;
            UrediKlijentRequest.Telefon = user.Telefon;
            UrediKlijentRequest.GradId = user.GradId;
            UrediKlijentRequest.Status = user.Status;
            UrediKlijentRequest.DatumRodjenja = user.DatumRodjenja;
            if (user.Slika.Length > 0)
            {
                UrediKlijentRequest.Slika = user.Slika;
                UrediKlijentRequest.SlikaThumb = user.SlikaThumb;
                byte[] slika = user.Slika;
                MemoryStream memoryStream = new MemoryStream(slika);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            txtIme1.Text = UrediKlijentRequest.Ime;
            txtPrezime1.Text = UrediKlijentRequest.Prezime;
            txtAdresa1.Text = UrediKlijentRequest.Adresa;

            txtEmail1.Text = UrediKlijentRequest.Email;
            txtTelefon1.Text = UrediKlijentRequest.Telefon;

            dtpDatumRodjenja.Value = UrediKlijentRequest.DatumRodjenja.Value;
            //txtGrad1.Text = grad.Naziv;

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;

                var file = File.ReadAllBytes(filename);

                UrediKlijentRequest.Slika = file;
                Image image = Image.FromFile(filename);
                Image thumb = image.GetThumbnailImage(75, 75, () => false, IntPtr.Zero);

                ImageConverter _imageConverter = new ImageConverter();
                byte[] imagethumbbyte = (byte[])_imageConverter.ConvertTo(thumb, typeof(byte[]));
                UrediKlijentRequest.SlikaThumb = imagethumbbyte;
                pictureBox1.Image = image;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

                UrediKlijentRequest.Adresa = txtAdresa1.Text;
                UrediKlijentRequest.Ime = txtIme1.Text;
                UrediKlijentRequest.Prezime = txtPrezime1.Text;
                UrediKlijentRequest.Telefon = txtTelefon1.Text;
                UrediKlijentRequest.Email = txtEmail1.Text;
                UrediKlijentRequest.DatumRodjenja = dtpDatumRodjenja.Value;
                UrediKlijentRequest.Password = "test";
                UrediKlijentRequest.PotvrdaPassworda = "test";
                var entity = await _service.Update<Model.Models.Klijent>(_KlijentId, UrediKlijentRequest);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izmjenjeni podaci o klijentu");
                    _KlijentId = 0;
                    this.tabControl1.SelectTab(tabPage1);
                    this.tabControl1.TabPages.Remove(DetaljiKlijentaa);

                }
        }

        private async void btnSpremiNovi_Click(object sender, EventArgs e)
        {
            bool provjera = this.ValidateChildren();
            string error1 = errorProvider1.GetError(txtAdresaNovi);
            string error2 = errorProvider1.GetError(txtEmailNovi);

            //if (!string.IsNullOrEmpty(error1) || string.IsNullOrEmpty(error2)) ;
            //     provjera = false;

            if (provjera)
            {

                var gradIdObj = cmbGradNovi.SelectedValue;

                if (int.TryParse(gradIdObj.ToString(), out int gId))
                {
                    DodajKlijentRequest.GradId = gId;
                }

                if (DodajKlijentRequest.Slika == null)
                {
                    var filename = Properties.Resources.no_Image;

                    MemoryStream ms = new MemoryStream();
                    filename.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                    DodajKlijentRequest.Slika = ms.ToArray();

                    Image image = Image.FromStream(new MemoryStream(DodajKlijentRequest.Slika));
                    Image thumb = image.GetThumbnailImage(75, 75, () => false, IntPtr.Zero);

                    ImageConverter _imageConverter = new ImageConverter();
                    byte[] imagethumbbyte = (byte[])_imageConverter.ConvertTo(thumb, typeof(byte[]));
                    DodajKlijentRequest.SlikaThumb = imagethumbbyte;
                }


                DodajKlijentRequest.Ime = txtImeNovi.Text;
                DodajKlijentRequest.Prezime = txtPrezimeNovi.Text;
                DodajKlijentRequest.Email = txtEmailNovi.Text;
                DodajKlijentRequest.Telefon = txtTelefonNovi.Text;
                DodajKlijentRequest.Adresa = txtAdresaNovi.Text;
                DodajKlijentRequest.Password = txtPassword.Text;
                DodajKlijentRequest.PotvrdaPassworda = txtPotvrdaPaassworda.Text;
                DodajKlijentRequest.Status = chbAktivanNovi.Checked;

                DodajKlijentRequest.DatumRodjenja = dtpDatumRodjenjaNovi.Value;

                var entity = await _service.Insert<Model.Models.Klijent>(DodajKlijentRequest);

                if (entity != null)
                {
                    MessageBox.Show("Korisnik uspješno dodan");

                    cmbGradNovi.SelectedIndex = -1;
                    txtImeNovi.Clear();
                    txtPrezimeNovi.Clear();
                    txtEmailNovi.Clear();
                    txtTelefonNovi.Clear();
                    txtAdresaNovi.Clear();
                    txtPassword.Clear();
                    txtPotvrdaPaassworda.Clear();
                    chbAktivan.Checked = true;
                    dtpDatumRodjenjaNovi.Value = DateTime.Now.Date;

                    //Postavljanje defaultne slike u picturebox
                    var filename = Properties.Resources.no_Image;
                    MemoryStream ms = new MemoryStream();
                    filename.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    Image image = Image.FromStream(ms);
                    pictureBox2.Image = image;

                    this.tabControl1.SelectTab(tabPage1);


                }
            }
        }

        private void btnDodajSlikuNovi_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;

                var file = File.ReadAllBytes(filename);

                Image image = Image.FromFile(filename);
                Image thumb = image.GetThumbnailImage(75, 75, () => false, IntPtr.Zero);

                ImageConverter _imageConverter = new ImageConverter();
                byte[] imagethumbbyte = (byte[])_imageConverter.ConvertTo(thumb, typeof(byte[]));

                DodajKlijentRequest.Slika = file;
                DodajKlijentRequest.SlikaThumb = imagethumbbyte;
                pictureBox2.Image = image;
            }
        }

        private void dgvKlijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region Validation
        private void txtImeNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtImeNovi.Text))
            {
                errorProvider1.SetError(txtImeNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtImeNovi, null);
            }

        }

        private void txtPrezimeNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezimeNovi.Text))
            {
                errorProvider1.SetError(txtPrezimeNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezimeNovi, null);
            }
        }

        private void txtTelefonNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefonNovi.Text))
            {
                errorProvider1.SetError(txtTelefonNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefonNovi, null);
            }
        }

        private void txtAdresaNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresaNovi.Text))
            {
                errorProvider1.SetError(txtAdresaNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresaNovi, null);
            }
        }

        private void txtEmailNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailNovi.Text))
            {
                errorProvider1.SetError(txtEmailNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmailNovi, null);
            }
        }

        private void cmbGradNovi_Validating(object sender, CancelEventArgs e)
        {
            var GradObj = cmbGradNovi.SelectedValue;
            if (GradObj == null || GradObj.ToString() == "0")
            {
                errorProvider1.SetError(cmbGradNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbGradNovi, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtPotvrdaPaassworda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPotvrdaPaassworda.Text))
            {
                errorProvider1.SetError(txtPotvrdaPaassworda, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (string.Compare(txtPassword.Text, txtPotvrdaPaassworda.Text) != 0)
                {
                    errorProvider1.SetError(txtPotvrdaPaassworda, "Passwordi se ne podudaraju");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtPotvrdaPaassworda, null);
                }
            }
            else
            {

                errorProvider1.SetError(txtPotvrdaPaassworda, null);
            }
        }
        //validacija detalja
        private void txtIme1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme1.Text))
            {
                errorProvider1.SetError(txtIme1, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme1, null);
            }

        }

        private void txtPrezime1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime1.Text))
            {
                errorProvider1.SetError(txtPrezime1, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime1, null);
            }
        }

        private void txtAdresa1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresa1.Text))
            {
                errorProvider1.SetError(txtAdresa1, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresa1, null);
            }
        }

        private void txtTelefon1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon1.Text))
            {
                errorProvider1.SetError(txtTelefon1, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon1, null);
            }
        }

        private void txtEmail1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail1.Text))
            {
                errorProvider1.SetError(txtEmail1, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail1, null);
            }
        }

        #endregion


    }
}
