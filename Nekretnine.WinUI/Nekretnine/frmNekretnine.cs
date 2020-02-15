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

namespace Nekretnine.WinUI.Nekretnine
{
    public partial class frmNekretnine : Form
    {
        private readonly APIService _service = new APIService("Nekretnina");
        private readonly APIService _gradService = new APIService("Grad");
        private readonly APIService _slikaService = new APIService("Slika");


        private NekretninaUpsertRequest nekretninaDodaj = new NekretninaUpsertRequest();
        private NekretninaUpsertRequest nekretninaUredi = new NekretninaUpsertRequest();
        private SlikaUpsertRequest slikadodaj = new SlikaUpsertRequest();

        private List<Image> LoadedImages { get; set; }

        public int _NekretninaId { get; set; }

        public frmNekretnine()
        {
            InitializeComponent();
        }

        private async void frmNekretnine_Load(object sender, EventArgs e)
        {
            dgvNekretnine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.tabControl1.TabPages.Remove(DetaljiNekretnine);
            this.tabControl1.TabPages.Remove(SlikeNekretnine);
            await LoadGradovi(cmbGrad);
            await LoadGradovi(cmbGradNovi);
        }

        private async Task LoadGradovi(ComboBox cmb)
        {
            var result = await _gradService.Get<List<Model.Models.Grad>>(null);
            result.Insert(0, new Model.Models.Grad());

            ComboBoxLoad<Model.Models.Grad> cmbLoad = new ComboBoxLoad<Model.Models.Grad>();
            cmbLoad.Load(cmb, result, "Naziv", "GradId");
        }
        private async void btnPrikaziNekretnine_Click(object sender, EventArgs e)
        {
            var search = new NekretninaSearchRequest();
            //search = null;
            var GradObj = cmbGrad.SelectedValue;
            if (GradObj == null)
                GradObj = 0;
            if (int.TryParse(GradObj.ToString(), out int GradId))
            {
                search.GradId = GradId;
            }
            if (txtKvadrataOd.Text != "")
            {
                search.Kvadratura = int.Parse(txtKvadrataOd.Text);
            }


            var result = await _service.Get<List<Model.Models.Nekretnina>>(search);
            dgvNekretnine.AutoGenerateColumns = false;
            dgvNekretnine.DataSource = result;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void btnSpasiNovi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var GradIdObj = cmbGradNovi.SelectedValue;

                if (int.TryParse(GradIdObj.ToString(), out int gid))
                {
                    nekretninaDodaj.GradId = gid;
                }
                nekretninaDodaj.Adresa = txtAdresaNovi.Text;
                nekretninaDodaj.GodinaIzgradnje = txtGodinaIzgradnjeNovi.Text;
                nekretninaDodaj.Kvadratura = int.Parse(txtKvadraturaNovi.Text.ToString());
                nekretninaDodaj.Vlasnik = txtVlasnikNovi.Text;
                nekretninaDodaj.Prodaja = chbProdajaNovi.Checked;
                nekretninaDodaj.Naziv = txtNazivNovi.Text;

                var entity = await _service.Insert<Model.Models.Nekretnina>(nekretninaDodaj);

                if (entity != null)
                {
                    MessageBox.Show("Nekretnina uspjesno spasena");
                    txtAdresaNovi.Clear();
                    txtGodinaIzgradnjeNovi.Clear();
                    txtKvadraturaNovi.Clear();
                    txtNazivNovi.Clear();
                    txtVlasnikNovi.Clear();
                    cmbGrad.SelectedIndex = -1;

                    this.tabControl1.SelectTab(listaNekretnina);

                } 
            }
        }

        private async void dgvNekretnine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tabControl1.TabPages.Remove(DetaljiNekretnine);
            this.tabControl1.TabPages.Remove(SlikeNekretnine);

            var id = 0;
            if (dgvNekretnine.RowCount > 0)
            {
                var val = dgvNekretnine.SelectedRows[0].Cells[0].Value;
                id = int.Parse(val.ToString());
                _NekretninaId = id;

                await LoadGradovi(cmbGradDetalji);
                await UcitajDetaljeNekretnina();

                this.tabControl1.TabPages.Add(DetaljiNekretnine);
                this.tabControl1.TabPages.Add(SlikeNekretnine);
                this.tabControl1.SelectTab(SlikeNekretnine);

            }
        }

        private async Task UcitajDetaljeNekretnina()
        {
            var nekretnina = await _service.GetById<Model.Models.Nekretnina>(_NekretninaId);
            var grad=await _gradService.GetById<Model.Models.Grad>(nekretnina.GradId);

            txtAdresaDetalji.Text = nekretnina.Adresa;
            txtGodinaIzgradnjeDetalji.Text = nekretnina.GodinaIzgradnje;
            txtKvadraturaDetalji.Text = nekretnina.Kvadratura.ToString();
            txtNazivDetalji.Text = nekretnina.Naziv;
            txtVlasnikDetalji.Text = nekretnina.Vlasnik;
            chbProdajaDetalji.Checked = nekretnina.Prodaja.Value;
            cmbGradDetalji.SelectedIndex = cmbGradDetalji.FindString(grad.Naziv);
            nekretninaUredi.GradId = nekretnina.GradId;
            nekretninaUredi.NekretninaId = nekretnina.NekretninaId;

          await SetImageList();

        }

        private async  Task SetImageList()
        {
            imageList.Clear();
            await LoadImages();
            ImageList images = new ImageList();
            images.ImageSize = new Size(140, 45);
            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }
            imageList.LargeImageList = images;
            for (int i = 0; i < LoadedImages.Count; i++)
            {
                imageList.Items.Add(new ListViewItem($"Slika broj: {i}", i));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                slikadodaj.NazivSlike = file;
                txtSlikaInput.Text = fileName;
                Image image = Image.FromFile(fileName);
                selectedImage.Image = image;
            }
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnSpremiSliku_Click(object sender, EventArgs e)
        {
            slikadodaj.NekretninaId = _NekretninaId;
            if(_NekretninaId==0 || slikadodaj.NazivSlike==null)
            {
                MessageBox.Show("Greska prilikom ucitavanja ");
                return;
            }

            var element = await _slikaService.Insert<Model.Models.Slika>(slikadodaj);
            if(element!=null)
            {
                MessageBox.Show("Slika uspjesno spasena");
               await SetImageList();

            }

            else
            {
                MessageBox.Show("Greska prilikom spasavanja slike");
            }

        }
        private async Task LoadImages()
        {
            LoadedImages = new List<Image>();
            var searchSlika = new SlikaSearchRequest();
            searchSlika.NekretninaId = _NekretninaId;
            var slike = await _slikaService.Get<List<Model.Models.Slika>>(searchSlika);

            for (int i = 0; i < slike.Count(); i++)
            {
                MemoryStream memoryStream = new MemoryStream(slike[i].NazivSlike);
                LoadedImages.Add(Image.FromStream(memoryStream));
            }
        }

        private void imageList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(imageList.SelectedIndices.Count>0)
            {
                var selectedIndex = imageList.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                selectedImage.Image = selectedImg;
            }
        }

        private void btnSpremiDetalji_Click(object sender, EventArgs e)
        {
            nekretninaUredi.GodinaIzgradnje = txtGodinaIzgradnjeDetalji.Text;
            nekretninaUredi.Kvadratura = int.Parse(txtKvadraturaDetalji.Text.ToString());
            nekretninaUredi.Adresa = txtAdresaDetalji.Text;
            nekretninaUredi.Vlasnik = txtVlasnikDetalji.Text;
            nekretninaUredi.Prodaja = chbProdajaDetalji.Checked;
            nekretninaUredi.Naziv = txtNazivDetalji.Text;
            nekretninaUredi.GradId = cmbGradDetalji.SelectedIndex;
            var element = _service.Update<Model.Models.Nekretnina>(_NekretninaId,nekretninaUredi);

            if(element!=null)
            {
                MessageBox.Show("Podaci uspjesno izmjenjeni");
                this.tabControl1.TabPages.Remove(DetaljiNekretnine);
                this.tabControl1.TabPages.Remove(SlikeNekretnine);
                
                this.tabControl1.SelectTab(listaNekretnina);
            }
        }

        #region Validation
        private void tabControl1_Validating(object sender, CancelEventArgs e)
        {

        }
        private void txtNazivNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivNovi.Text))
            {
                errorProvider1.SetError(txtNazivNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNazivNovi, null);
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

        private void txtVlasnikNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVlasnikNovi.Text))
            {
                errorProvider1.SetError(txtVlasnikNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtVlasnikNovi, null);
            }
        }

        private void txtKvadraturaNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKvadraturaNovi.Text))
            {
                errorProvider1.SetError(txtKvadraturaNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKvadraturaNovi, null);
            }
        }

        private void txtGodinaIzgradnjeNovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGodinaIzgradnjeNovi.Text))
            {
                errorProvider1.SetError(txtGodinaIzgradnjeNovi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGodinaIzgradnjeNovi, null);
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
        //Validacija detalja
        private void txtNazivDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivDetalji.Text))
            {
                errorProvider1.SetError(txtNazivDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNazivDetalji, null);
            }
        }

        private void txtAdresaDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresaDetalji.Text))
            {
                errorProvider1.SetError(txtAdresaDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresaDetalji, null);
            }
        }

        private void txtKvadraturaDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKvadraturaDetalji.Text))
            {
                errorProvider1.SetError(txtKvadraturaDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKvadraturaDetalji, null);
            }
        }

        private void txtVlasnikDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVlasnikDetalji.Text))
            {
                errorProvider1.SetError(txtVlasnikDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtVlasnikDetalji, null);
            }
        }

        private void txtGodinaIzgradnjeDetalji_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGodinaIzgradnjeDetalji.Text))
            {
                errorProvider1.SetError(txtGodinaIzgradnjeDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGodinaIzgradnjeDetalji, null);
            }
        }

        private void cmbGradDetalji_Validating(object sender, CancelEventArgs e)
        {
            var GradObj = cmbGradDetalji.SelectedValue;
            if (GradObj == null || GradObj.ToString() == "0")
            {
                errorProvider1.SetError(cmbGradDetalji, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbGradDetalji, null);
            }
        }

        #endregion


    }
}
