using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelStocareDate;
using static System.Net.WebRequestMethods;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form2 : Form
    {
        GestionareLiveziFisiereText adminLivezi;
        List<Livada> listaLivezi = null;

        public Form2()
        {
            InitializeComponent();
            string numeFisierLivezi = ConfigurationManager.AppSettings["NumeFisierC"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierLivezi = locatieFisierSolutie + "\\" + numeFisierLivezi;
            adminLivezi = new GestionareLiveziFisiereText(caleCompletaFisierLivezi);
            listaLivezi = adminLivezi.GetLivezi();
            AfisareLiveziInControlDataGridView(listaLivezi);
            lblErori.ForeColor = Color.Red;
        }
        private void AfisareLiveziInControlDataGridView(List<Livada> livezi)
        {
            dgvLivezi.DataSource = null;
            dgvLivezi.DataSource = livezi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Suprafata_Click(object sender, EventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                double suprafata = Convert.ToDouble(tbSuprafata.Text);  
                string id = (tbId.Text);

                Livada livada = new Livada(suprafata, id);
                adminLivezi.AddLivezi(livada);
                AfisareLiveziInControlDataGridView(adminLivezi.GetLivezi());
                ReseteazaControale();
            }
        }
        private bool ValidateData() 
        {
            bool status = true;
            if(tbSuprafata.Text == String.Empty)
            {
                lblSuprafata.Text = "Introduceti Suprafata";
                status = false;
            }
            else if(!double.TryParse(tbSuprafata.Text,out _))
            {
                lblErori.Text = "Introduceti un numar la suprafata";
                status = false;
            }
            if(tbId.Text == String.Empty) 
            {
                lblErori.Text = "Introduceti Id-ul";
                status = false;
            }
            List<Livada> livezi = adminLivezi.GetLivezi();
            foreach(Livada liv in livezi)
            {
                if(liv.id_livada == tbId.Text)
                {
                    status = false;
                    lblErori.Text = "Id deja existent ";
                }
            }
            
            return status;
        }
        private void ReseteazaControale()
        {
            tbSuprafata.Text = string.Empty;
            tbId.Text = string.Empty;
        }

        private void btCauta_Click(object sender, EventArgs e)
        {
            dgvLivezi.DataSource = null;
            dgvLivezi.Refresh();
            List<Livada> livezi = adminLivezi.GetLivezi();
            List<Livada> liveziAlese = new List<Livada>();
            string id= tbCauta.Text;
            foreach (Livada livada in livezi )
            {
                if(livada.id_livada == id)
                    liveziAlese.Add(livada);
               

            }
            dgvLivezi.DataSource = liveziAlese;

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                double suprafata = Convert.ToDouble(tbSuprafata.Text);
                string id = (tbId.Text);
                Livada livadaActualizata = new Livada(suprafata, id);

                if (adminLivezi.UpdateSuprafata(livadaActualizata)){
                    lblErori.Text = "Livada actualizata";
                    ReseteazaControale();
                    AfisareLiveziInControlDataGridView(adminLivezi.GetLivezi());
                }

            }

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            AfisareLiveziInControlDataGridView(adminLivezi.GetLivezi());
            tbCauta.Text= String.Empty;
        }

        private void btStergere_Click(object sender, EventArgs e)
        {


            string id = tbId.Text;
            bool succes = adminLivezi.StergeLivada(id);
            if (succes)
            {
                lblErori.Text = "Livada a fost stearsa";
                AfisareLiveziInControlDataGridView(adminLivezi.GetLivezi());
            }
            else
            {
                lblErori.Text = "Livada nu a fost stearsa";


            }


        }
    }
}
