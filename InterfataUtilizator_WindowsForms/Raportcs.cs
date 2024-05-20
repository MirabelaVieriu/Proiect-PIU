using NivelStocareDate;
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

namespace InterfataUtilizator_WindowsForms
{
    
    public partial class Raportcs : Form
    {
        GestionarePomiFisiereText adminPomi = null;
        public Raportcs()
        {

            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminPomi = new GestionarePomiFisiereText(caleCompletaFisier);


        }

        private void Raportcs_Load(object sender, EventArgs e)
        {
            this.chart1.Series["2024"].Points.AddXY("2024", adminPomi.NumarPomiCuAnul(2024));
            this.chart1.Series["2023"].Points.AddXY("2023", adminPomi.NumarPomiCuAnul(2023));
            this.chart1.Series["2022"].Points.AddXY("2022", adminPomi.NumarPomiCuAnul(2022));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }
    }
}
