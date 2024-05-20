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
            listaLivezi = adminLivezi.GetLivada();
            AfisareLiveziInControlDataGridView(listaLivezi);
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
                AfisareLiveziInControlDataGridView(adminLivezi.GetLivada());
                ReseteazaControale();
            }
        }
        private bool ValidateData() 
        {
            bool status;
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
            else { status= true; }
            if(tbId.Text == String.Empty) 
            {
                lblId.Text = "Introduceti Id-ul";
                status = false;
            }
            else { status= true; }
            return status;
        }
        private void ReseteazaControale()
        {
            tbSuprafata.Text = string.Empty;
            tbId.Text = string.Empty;
        }
    }
}
