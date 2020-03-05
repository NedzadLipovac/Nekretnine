
using Nekretnine.Model.Requests;
using Nekretnine.WinUI.Home;
using Nekretnine.WinUI.Klijenti;
using Nekretnine.WinUI.Korisnici;
using Nekretnine.WinUI.Nekretnine;
using Nekretnine.WinUI.Poruke;
using Nekretnine.WinUI.Sastanci;
using Nekretnine.WinUI.UpitiZaSastanke;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using Tulpep.NotificationWindow;

namespace Nekretnine.WinUI
{
    public partial class DashboardForm : Form
    {
        private readonly APIService _KorisnikService = new APIService("Korisnik");
      

        public string _username=null;
        public int KorisnikId;
      

        public KorisnikSearchRequest _searchRequest = new KorisnikSearchRequest();

        public DashboardForm(string username)
        {
            _username = username;
            _searchRequest.Username = username;
       
            InitializeComponent();
        }

        //Ucitavanje dashboard forme
        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            _searchRequest.Status = true;
            var users = await _KorisnikService.Get<List<Model.Models.Korisnik>>(_searchRequest);

            var user = users.FirstOrDefault();
            SqlTableDependency<Model.Models.Poruka> _dependency;
            var connectionString = Model.ConnectionString.connectionString;


            _dependency = new SqlTableDependency<Model.Models.Poruka>(connectionString, "Poruka");

            _dependency.OnChanged += _dependency_OnChanged;
            _dependency.OnError += _dependency_OnError;
            _dependency.Start();

            if (user != null)
            {

                lblKorisnik.Text = user.Ime + ' ' + user.Prezime;
                KorisnikId = user.KorisnikId;
                lblKorisnikId.Text = KorisnikId.ToString();

                if (user.Slika != null)
                {
                    byte[] slika = user.Slika;

                    MemoryStream memoryStream = new MemoryStream(slika);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
       
                frmHome frm = new frmHome();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;
                pnlMjesto.Controls.Clear();

                pnlMjesto.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();


            }
        }
        private void _dependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            throw e.Error;
        }
        private async void _dependency_OnChanged(object sender, RecordChangedEventArgs<Model.Models.Poruka> e)
        {

            if (e.ChangeType != ChangeType.None && e.Entity.Posiljaoc != "Uposlenik")
            {
                //this.grid.Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                //{
                //    this.grid.ItemsSource = ArticleController.GetAll();
                //}));
                btnPoruke.BackColor = Color.Red;
              
                //NewMethod();

            }
        }

        private static void NewMethod()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.newpost;
            popup.TitleText = "OBAVIJEST";
            popup.ContentText = "Nova poruka primljena";
            popup.Popup();
        }

        //Pregled home tab-a
        private void btnHome_Click(object sender, EventArgs e)
        {
   
            frmHome frm = new frmHome();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.TopLevel = false;
            pnlMjesto.Controls.Clear();

            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        //Pregled  poruka
        private void btnPoruke_Click(object sender, EventArgs e)
        {
      
            btnPoruke.BackColor = Color.FromArgb(11, 40, 42);
            frmPoruke frm = new frmPoruke(KorisnikId);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.TopLevel = false;
            pnlMjesto.Controls.Clear();

            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        //Pregled korisnika
        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.TopLevel = false;
            pnlMjesto.Controls.Clear();

            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        //Pregled klijenata
        private void btnKlijenti_Click(object sender, EventArgs e)
        {
         
            frmKlijenti frm = new frmKlijenti();
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMjesto.Controls.Clear();
            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

   


    
        private void btnRezervacije_Click(object sender, EventArgs e)
        {
           
            frmSastanci frm = new frmSastanci();
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMjesto.Controls.Clear();
            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();


        }

        private void pnlStats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMjesto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpiti_Click(object sender, EventArgs e)
        {

            frmUpiti frm = new frmUpiti();
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMjesto.Controls.Clear();
            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btnNekretnine_Click(object sender, EventArgs e)
        {
            frmNekretnine frm = new frmNekretnine();
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMjesto.Controls.Clear();
            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        //Pregled profila prijavljenog korisnika
        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfil frm = new frmProfil(KorisnikId);
            frm.Height = pnlMjesto.Height;
            frm.Width = pnlMjesto.Width;
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMjesto.Controls.Clear();
            pnlMjesto.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

   
        //Odjava sa aplikacije
        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            frm.Show();
        }

     
    }
}
