using Nekretnine.Model.Requests;
using Nekretnine.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _service = new APIService("Korisnik");
        private readonly APIService _gradService = new APIService("Grad");
        private KorisnikUpsertRequest dodajKorisnik = new KorisnikUpsertRequest();
        private KorisnikUpsertRequest urediKorisnik = new KorisnikUpsertRequest();
        private int _KorisnikId { get; set; }
        public frmKorisnici()
        {
            InitializeComponent();
        }
        private async Task LoadGradovi(ComboBox cmb)
        {
            var result = await _gradService.Get<List<Model.Models.Grad>>(null);
            result.Insert(0, new Model.Models.Grad());

            ComboBoxLoad<Model.Models.Grad> cmbLoad = new ComboBoxLoad<Model.Models.Grad>();
            cmbLoad.Load(cmb, result, "Naziv", "GradId");
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSnimiNovi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var gradID = cmbGradNovi.SelectedValue;
                if (int.TryParse(gradID.ToString(), out int _gradId))
                {
                    dodajKorisnik.GradId = _gradId;
                }

                if (dodajKorisnik.Slika == null)
                {
                    var filename = Properties.Resources.no_Image;

                    MemoryStream ms = new MemoryStream();
                    filename.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                    dodajKorisnik.Slika = ms.ToArray();

                    Image image = Image.FromStream(new MemoryStream(dodajKorisnik.Slika));
                    Image thumb = image.GetThumbnailImage(75, 75, () => false, IntPtr.Zero);

                    ImageConverter _imageConverter = new ImageConverter();
                    byte[] imagethumbbyte = (byte[])_imageConverter.ConvertTo(thumb, typeof(byte[]));
                    dodajKorisnik.SlikaThumb = imagethumbbyte;
                }

                dodajKorisnik.Adresa = txtAdresaNovi.Text;
                dodajKorisnik.DatumRodjenja = dtpDatumRodjenjaNovi.Value;
                dodajKorisnik.Email = txtEmailNovi.Text;
                dodajKorisnik.Ime = txtImeNovi.Text;
                dodajKorisnik.Password = txtPasswordNovi.Text;
                dodajKorisnik.PasswordPotvrda = txtPasswordPotvrdaNovi.Text;
                dodajKorisnik.Prezime = txtPrezimeNovi.Text;
                dodajKorisnik.Telefon = txtTelefonNovi.Text;
                dodajKorisnik.Username = txtUsernameNovi.Text;
                dodajKorisnik.Status = chbStatusNovi.Checked;

                var entity = _service.Insert<Model.Models.Korisnik>(dodajKorisnik);

                if (entity != null)
                {
                    MessageBox.Show("Korisnik uspjesno dodan");
                    cmbGradNovi.SelectedIndex = -1;
                    txtImeNovi.Clear();
                    txtPrezimeNovi.Clear();
                    txtEmailNovi.Clear();
                    txtTelefonNovi.Clear();
                    txtAdresaNovi.Clear();
                    txtPasswordNovi.Clear();
                    txtPasswordPotvrdaNovi.Clear();
                    chbStatusNovi.Checked = true;
                    dtpDatumRodjenjaNovi.Value = DateTime.Now.Date;
                }

            }
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
           await LoadGradovi(cmbGradNovi);
            await LoadGradovi(cmbGradLista);
            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;

                var file = File.ReadAllBytes(filename);

                dodajKorisnik.Slika = file;
                Image image = Image.FromFile(filename);
                Image thumb = image.GetThumbnailImage(75, 75, () => false, IntPtr.Zero);

                ImageConverter _imageConverter = new ImageConverter();
                byte[] imagethumbbyte = (byte[])_imageConverter.ConvertTo(thumb, typeof(byte[]));
                dodajKorisnik.SlikaThumb = imagethumbbyte;
                pictureBox3.Image = image;
            }

        }
        private async Task PretragaKorisnika()
        {
            
            var search = new KorisnikSearchRequest();
            //search = null;
            var GradObj = cmbGradLista.SelectedValue;
            if (GradObj == null)
                GradObj = 0;
            if (int.TryParse(GradObj.ToString(), out int GradId))
            {
                if (GradId != 0) 
                search.GradId = GradId;
            }
            if (txtImeLista.Text != "")
            {
                search.Ime = txtImeLista.Text.ToLower();
            }
            if (txtPrezimelista.Text != "")
            {
                search.Prezime = txtPrezimelista.Text.ToLower();
            }
            if (txtEmailLista.Text != "")
            {
                search.Email = txtEmailLista.Text.ToLower();
            }
            search.Status = chbAktivanLista.Checked;
            var result = await _service.Get<List<Model.Models.Korisnik>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await PretragaKorisnika();
        }

        private async void btnSpremiDetalji_Click(object sender, EventArgs e)
        {
            urediKorisnik.Ime = txtImeDetalji.Text;
            urediKorisnik.Prezime = txtPrezimeDetalji.Text;
            urediKorisnik.Adresa = txtAdresaDetalji.Text;
            urediKorisnik.Telefon = txtTelefonDetalji.Text;
            urediKorisnik.Email = txtEmailDetalji.Text;
            urediKorisnik.DatumRodjenja = dtpDatumRodjenjaDetalji.Value;
            urediKorisnik.Status = chbStatusDetalji.Checked;

            var entity = await _service.Update<Model.Models.Korisnik>(_KorisnikId, urediKorisnik);

            if (entity != null)
            {
                MessageBox.Show("Uspješno izmjenjeni podaci o klijentu");
                _KorisnikId = 0;
                this.tabControl1.SelectTab(listaKorisnika);
                this.tabControl1.TabPages.Remove(DetaljiKorisnika);

            }

        }

        private void DetaljiKorisnika_Click(object sender, EventArgs e)
        {
         

        }

        private async void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tabControl1.TabPages.Remove(DetaljiKorisnika);
            int Id = 0;
            if (dgvKorisnici.RowCount>0)
            {
                var val = dgvKorisnici.SelectedRows[0].Cells[0].Value;
                Id = int.Parse(val.ToString());
                _KorisnikId = Id;
                await UcitajEditTab();
                this.tabControl1.TabPages.Add(DetaljiKorisnika);
                this.tabControl1.SelectTab(DetaljiKorisnika);
            }

        }

        private async Task UcitajEditTab()
        {
            var user = await _service.GetById<Model.Models.Klijent>(_KorisnikId);
            var grad = await _gradService.GetById<Model.Models.Grad>(user.GradId);

           // await LoadGradovi(cmbGrad);

            urediKorisnik.Ime = user.Ime;
            urediKorisnik.Prezime = user.Prezime;
            urediKorisnik.Adresa = user.Adresa;

            urediKorisnik.Email  = user.Email;
            urediKorisnik.Telefon = user.Telefon;
            urediKorisnik.GradId = user.GradId;
            urediKorisnik.Status = user.Status;
            urediKorisnik.DatumRodjenja = user.DatumRodjenja;
            if (user.Slika.Length > 0)
            {
                urediKorisnik.Slika = user.Slika;
                urediKorisnik.SlikaThumb = user.SlikaThumb;
                byte[] slika = user.Slika;
                MemoryStream memoryStream = new MemoryStream(slika);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            txtImeDetalji.Text = urediKorisnik.Ime;
            txtPrezimeDetalji.Text = urediKorisnik.Prezime;
            txtAdresaDetalji.Text = urediKorisnik.Adresa;

            txtEmailDetalji.Text = urediKorisnik.Email;
            txtTelefonDetalji.Text = urediKorisnik.Telefon;

            dtpDatumRodjenjaDetalji.Value = urediKorisnik.DatumRodjenja.Date;
            //txtGrad1.Text = grad.Naziv;

        }

        private void btnDodajSlikuDetalji_Click(object sender, EventArgs e)
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

                urediKorisnik.Slika = file;
                urediKorisnik.SlikaThumb = imagethumbbyte;
                pictureBox1.Image = image;
            }
        }
        #region Validation
        private void txtImeNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeNovi.Text))
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
            if (string.IsNullOrWhiteSpace(txtPrezimeNovi.Text))
            {
                errorProvider1.SetError(txtPrezimeNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezimeNovi, null);
            }
        }

        private void txtEmailNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailNovi.Text))
            {
                errorProvider1.SetError(txtEmailNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmailNovi, null);
            }
        }

        private void txtTelefonNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefonNovi.Text))
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
            if (string.IsNullOrWhiteSpace(txtAdresaNovi.Text))
            {
                errorProvider1.SetError(txtAdresaNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresaNovi, null);
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

        private async void txtUsernameNovi_Validating(object sender, CancelEventArgs e)
        {
            bool postoji = false;

            if (string.IsNullOrWhiteSpace(txtUsernameNovi.Text))
            {
                errorProvider1.SetError(txtUsernameNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                KorisnikSearchRequest korisniciSearch = new KorisnikSearchRequest()
                {
                    Status = true,
                    Username = txtUsernameNovi.Text
                };


                var user = await _service.Get<List<Model.Models.Korisnik>>(korisniciSearch);
                if (user.Count > 0)
                {

                    postoji = true;
                }

                korisniciSearch.Status = false;
                user = await _service.Get<List<Model.Models.Korisnik>>(korisniciSearch);
                if (user.Count > 0)
                {

                    postoji = true;
                }

                if (postoji)
                {
                    errorProvider1.SetError(txtUsernameNovi, Properties.Resources.UsernameExists);
                    e.Cancel = true;
                }
                else
                    errorProvider1.SetError(txtUsernameNovi, null);
            }
        }

        private void txtPasswordNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordNovi.Text))
            {
                errorProvider1.SetError(txtPasswordNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPasswordNovi, null);
            }
        }

        private void txtPasswordPotvrdaNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordPotvrdaNovi.Text))
            {
                errorProvider1.SetError(txtPasswordPotvrdaNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else if (!string.IsNullOrWhiteSpace(txtPasswordPotvrdaNovi.Text))
            {
                if (string.Compare(txtPasswordNovi.Text, txtPasswordPotvrdaNovi.Text) != 0)
                {
                    errorProvider1.SetError(txtPasswordPotvrdaNovi, Properties.Resources.PasswordNotEqual);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtPasswordPotvrdaNovi, null);
                }
            }
            else
            {
                errorProvider1.SetError(txtPasswordPotvrdaNovi, null);
            }
        }
        //validate detalje korisnika 

        private void txtImeDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeDetalji.Text))
            {
                errorProvider1.SetError(txtImeDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtImeDetalji, null);
            }
        }
        private void txtPrezimeDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezimeDetalji.Text))
            {
                errorProvider1.SetError(txtPrezimeDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezimeDetalji, null);
            }
        }

        private void txtAdresaDetalji_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAdresaDetalji.Text))
            {
                errorProvider1.SetError(txtAdresaDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresaDetalji, null);
            }
        }

        private void txtTelefonDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefonDetalji.Text))
            {
                errorProvider1.SetError(txtTelefonDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefonDetalji, null);
            }
        }

        private void txtEmailDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailDetalji.Text))
            {
                errorProvider1.SetError(txtEmailDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmailDetalji, null);
            }
        }


        #endregion


    }
}
