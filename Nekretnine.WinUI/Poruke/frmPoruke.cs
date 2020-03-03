using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using TableDependency.SqlClient;
using System.IO;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;
using Tulpep.NotificationWindow;

namespace Nekretnine.WinUI.Poruke
{
    public partial class frmPoruke : Form
    {
        private readonly APIService _PorukaService = new APIService("Poruka");
        private int _UserID = 0, _PorukaID = 0;
        private HubConnection connection;

        public frmPoruke(int uid)
        {
            _UserID = uid;
            InitializeComponent();

            connection = new HubConnectionBuilder()
              .WithUrl("http://localhost:64804/api")
              .Build();


        }

        private async void frmPoruke_Load(object sender, EventArgs e)
        {
            dgvPrimljenePoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoslanePoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            await PretragaPrimljenihPoruka();
            await PretragaPoslanihPoruka();
            SqlTableDependency<Model.Models.Poruka> _dependency;
            var connectionString = @"Server=.;initial catalog=Nekretnine;User Id=Nedzad123;Password=test;";


            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.newpost;
            popup.TitleText = "OBAVIJEST";
            popup.ContentText = "Nova poruka primljena";
            popup.Popup();
            //var connectionString =@"Server=.;Database=Nekretnine;Trusted_Connection=True;ConnectRetryCount=0";

            //var connectionString = @"Server =.;Database=CarHireRC;Trusted_Connection=true;ConnectRetryCount=0";

            //_dependency = new SqlTableDependency<Model.Models.Poruka>(connectionString,"Poruka");

            //_dependency.OnChanged += _dependency_OnChanged;
            //_dependency.OnError += _dependency_OnError;
            //_dependency.Start();
            //try
            //{
            //    await connection.StartAsync();
            //    //messagesList.Items.Add("Connection started");
            //    //connectButton.IsEnabled = false;
            //    //sendButton.IsEnabled = true;
            //    connection.On("refreshEmployees", () =>
            //    {
            //        MessageBox.Show("evo me ");
            //    });
            //}
            //catch (Exception ex)
            //{
            //    //messagesList.Items.Add(ex.Message);
            //    throw;
            //}
        }
        private void _dependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            throw e.Error;
        }
        private  void _dependency_OnChanged(object sender, RecordChangedEventArgs<Model.Models.Poruka> e)
        {

            if (e.ChangeType != ChangeType.None)
            {
                //this.grid.Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                //{
                //    this.grid.ItemsSource = ArticleController.GetAll();
                //}));
                MessageBox.Show("Novi zapis u bazi ");
                 PretragaPrimljenihPoruka();


            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void dgvPrimljenePoruke_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (dgvPrimljenePoruke.RowCount > 0)
            {
                var val = dgvPrimljenePoruke.SelectedRows[0].Cells[0].Value;
                _PorukaID = int.Parse(val.ToString());
            }
            if (_PorukaID > 0)
            {
                btnOdgovori.Visible = true;
                await UcitajPrimljenuPoruku(_PorukaID);
            }
        }
        //Ucitavanje odabrane primljene poruke
        private async Task UcitajPrimljenuPoruku(int pid)
        {
            var poruka = await _PorukaService.GetById<Model.Models.Poruka>(pid);

            lblDatumIVrijemePrimljene.Text = poruka.DatumVrijeme.ToString();
            lblNaslovPrimljene.Text = poruka.Naslov;
            lblPosiljaoc.Text = poruka.PosiljaocInfo;
            txtSadrzajPrimljene.Text = poruka.Sadrzaj;
        }

        private async void btnOdgovori_Click(object sender, EventArgs e)
        {
            Model.Models.Poruka p = await _PorukaService.GetById<Model.Models.Poruka>(_PorukaID);
            frmNovaPoruka frm = new frmNovaPoruka(p.KlijentId, _UserID);
            _PorukaID = 0;
            btnOdgovori.Visible = false;
            frm.Show();
        }

        private async void dgvPoslanePoruke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Id = 0;
            if (dgvPoslanePoruke.RowCount > 0)
            {
                var val = dgvPoslanePoruke.SelectedRows[0].Cells[0].Value;
                Id = int.Parse(val.ToString());
            }
            if (Id > 0)
            {
                await UcitajPoslanuPoruku(Id);
            }
        }
        //Ucitavanje odabrane poslane poruke
        private async Task UcitajPoslanuPoruku(int id)
        {
            var poruka = await _PorukaService.GetById<Model.Models.Poruka>(id);

       
            lblDatumVrijemePoslane.Text = poruka.DatumVrijeme.ToString();
            lblNaslovPoslane.Text = poruka.Naslov;
            lblKlijentPoslane.Text = poruka.PrimaocInfo;
            txtSadrzajPoslane.Text = poruka.Sadrzaj;
        }
        private async Task PretragaPoslanihPoruka()
        {
            var search = new PorukaSearchRequest();


            search.UposlenikId = _UserID;
            search.Posiljaoc = "Uposlenik";

            if (txtImePoslan.Text != "")
            {
                search.PrimaocIme = txtImePoslan.Text.ToLower();
            }
            if (txtPrezimePoslan.Text != "")
            {
                search.PrimaocPrezime = txtPrezimePoslan.Text.ToLower();
            }
            if (txtUserNamePoslan.Text != "")
            {
                search.PrimaocUsername = txtUserNamePoslan.Text.ToLower();
            }



            var result = await _PorukaService.Get<List<Model.Models.Poruka>>(search);
            dgvPoslanePoruke.AutoGenerateColumns = false;
            dgvPoslanePoruke.DataSource = result;
        }

        private async void btnFiltriraj_Click(object sender, EventArgs e)
        {
            await PretragaPrimljenihPoruka();
        }

        private async void btnFiltrirajPrimaoce_Click(object sender, EventArgs e)
        {
            await PretragaPoslanihPoruka();
        }

        private void dgvPrimljenePoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnNovaPorukaNoviKlijent_Click(object sender, EventArgs e)
        {
            //Model.Models.Poruka p = await _PorukaService.GetById<Model.Models.Poruka>(_PorukaID);

            frmNovaPorukaNoviKlijent frm = new frmNovaPorukaNoviKlijent(_UserID);
            btnOdgovori.Visible = false;
            frm.Show();
        }

        private async Task PretragaPrimljenihPoruka()
        {
            var search = new PorukaSearchRequest();


            search.UposlenikId = _UserID;
            search.Posiljaoc = "Klijent";

            if (txtImePosiljaoca.Text != "")
            {
                search.PosiljaocIme = txtImePosiljaoca.Text.ToLower();
            }
            if (txtPrezimePosiljaoca.Text != "")
            {
                search.PosiljaocPrezime = txtPrezimePosiljaoca.Text.ToLower();
            }
            if (txtUserNamePosiljaoca.Text != "")
            {
                search.PosiljaocUsername = txtUserNamePosiljaoca.Text.ToLower();
            }
         


            var result = await _PorukaService.Get<List<Model.Models.Poruka>>(search);
            dgvPrimljenePoruke.AutoGenerateColumns = false;
            dgvPrimljenePoruke.DataSource = result;
        }
    }
}
