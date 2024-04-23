using System;
using LibrarieModele;
using NivelStocareDate;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        GestionarePomiFisiereText adminPomi;
        private Label lblTip;
        private Label lblCantitate;
        private Label lblAn;

        private Label[] lblsTip;
        private Label[] lblsCantitate;
        private Label[] lblsAn;

        GestionareLiveziFisiereText adminLivezi;
        private Label lblSuprafata;
        private Label lblId;

        private Label[] lblsSuprafata;
        private Label[] lblsId;

        private TextBox txtTip;
        private TextBox txtCantitate;
        private TextBox txtAn;

        private TextBox txtSuprafata;
        private TextBox txtId;

        private Button btnAdauga;
        private Button btnRefresh;

        private Label lblErori;


        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        public Form1()
        {
           InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string numeFisierLivezi = ConfigurationManager.AppSettings["NumeFisierC"];

            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            string caleCompletaFisierLivezi = locatieFisierSolutie + "\\" + numeFisierLivezi;

            adminPomi=new GestionarePomiFisiereText(caleCompletaFisier);
            int nrPomi = 0;
            Pom[] pomi = adminPomi.GetPomi(out nrPomi);

            adminLivezi = new GestionareLiveziFisiereText(caleCompletaFisierLivezi);
            int nrlivezi = 0;
            Livada[] livezi = adminLivezi.GetLivada(out nrlivezi);

            //setare proprietati
            this.Size = new Size(900, 300);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Informatii pomi";

            //adaugare control de tip Label pentru 'Tip';
            lblTip = new Label();
            lblTip.Width = LATIME_CONTROL;
            lblTip.Text = "Tip pom";
            lblTip.Left = DIMENSIUNE_PAS_X;
            lblTip.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblTip);

            //adaugare control de tip Label pentru 'Cantitate';
            lblCantitate = new Label();
            lblCantitate.Width = LATIME_CONTROL;
            lblCantitate.Text = "Cantitate";
            lblCantitate.Left = DIMENSIUNE_PAS_X * 2;
            lblCantitate.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblCantitate);


            //adaugare control de tip Label pentru 'An';
            lblAn = new Label();
            lblAn.Width = LATIME_CONTROL;
            lblAn.Text = "Anul plantari";
            lblAn.Left = DIMENSIUNE_PAS_X * 3 ;
            lblAn.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblAn);

            //adaugare control de tip Label pentru 'Suprafata';
            lblSuprafata = new Label();
            lblSuprafata.Width = LATIME_CONTROL;
            lblSuprafata.Text = "Suprafata livezi";
            lblSuprafata.Left = DIMENSIUNE_PAS_X * 4 ;
            lblSuprafata.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblSuprafata);

            //adaugare control de tip Label pentru 'Id';
            lblId= new Label();
            lblId.Width = LATIME_CONTROL;
            lblId.Text = "Id livada";
            lblId.Left = DIMENSIUNE_PAS_X * 5;
            lblId.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblId);

          

            //textbox tip
            txtTip = new TextBox();
            txtTip.Width = LATIME_CONTROL;
            txtTip.Left =  DIMENSIUNE_PAS_X;
            txtTip.Top = DIMENSIUNE_PAS_Y + 80;
            this.Controls.Add(txtTip);

            //textbox cantitate
            txtCantitate = new TextBox();
            txtCantitate.Width = LATIME_CONTROL;
            txtCantitate.Left = 2 * DIMENSIUNE_PAS_X;
            txtCantitate.Top = DIMENSIUNE_PAS_Y + 80; 
            this.Controls.Add(txtCantitate);

            //textbox an
            txtAn = new TextBox();
            txtAn.Width = LATIME_CONTROL;
            txtAn.Left = 3 * DIMENSIUNE_PAS_X;
            txtAn.Top = DIMENSIUNE_PAS_Y + 80; 
            this.Controls.Add(txtAn);

            //textbox suprafata
            txtSuprafata = new TextBox();
            txtSuprafata.Width = LATIME_CONTROL;
            txtSuprafata.Left = 4 * DIMENSIUNE_PAS_X;
            txtSuprafata.Top = DIMENSIUNE_PAS_Y + 80; 
            this.Controls.Add(txtSuprafata);

            //textbox id
            txtId = new TextBox();
            txtId.Width = LATIME_CONTROL;
            txtId.Left = 5 * DIMENSIUNE_PAS_X;
            txtId.Top = DIMENSIUNE_PAS_Y + 80; 
            this.Controls.Add(txtId);

            //Button Adauga
            btnAdauga = new Button();
            btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Location = new System.Drawing.Point(5 * DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y + 120);
            btnAdauga.Text = "Adauga";

            btnAdauga.Click += OnButtonClicked;
            this.Controls.Add(btnAdauga);

            //Button Refresh
            btnRefresh = new Button();
            btnRefresh.Width = LATIME_CONTROL;
            btnRefresh.Location = new System.Drawing.Point(5 * DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y + 150);
            btnRefresh.Text = "Refresh";

            btnRefresh.Click += Form1_Load;
            this.Controls.Add(btnRefresh); 

            //Label erori

            lblErori = new Label();
            lblErori.Location = new System.Drawing.Point( DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y + 160) ;
            this.Controls.Add(lblErori);

        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
           
            string tip = txtTip.Text;

            //validare Mar
            if (tip.Trim() == "")
            {
                lblTip.ForeColor=Color.Red;
                lblErori.Text = "Tip gresit!";
                return;


            }
            // Validate Cantitate_fructe
            if (!int.TryParse(txtCantitate.Text, out int cantitateFructe))
            {
                lblCantitate.ForeColor = Color.Red;
                lblErori.Text= "Cantitate gresita!";
                return; 
            }

            // Validate  Anul_plantarii
            if (!int.TryParse(txtAn.Text, out int anulPlantarii))
            {
                lblErori.Text = "An gresit!";
                lblAn.ForeColor = Color.Red;
                return; 
            }
           

            // Creare un nou obiect de tip pom
            Pom p = new Pom(tip, cantitateFructe, anulPlantarii);

            lblTip.ForeColor = Color.DarkGreen;
            lblCantitate.ForeColor = Color.DarkGreen;
            lblAn.ForeColor = Color.DarkGreen;
           

            lblErori.Text = "";

            adminPomi.AddPomi(p);
            AfiseazaPomi();
 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaPomi();
        }

      
        private void AfiseazaPomi()
        {
            Pom[] pomi = adminPomi.GetPomi(out int nrPomi);

            lblsTip = new Label[nrPomi];
            lblsCantitate = new Label[nrPomi];
            lblsAn= new Label[nrPomi];

            int i = 0;
            foreach (Pom pom in pomi)
            {
                //adaugare control de tip Label pentru tipul pomilor;
                lblsTip[i] = new Label();
                lblsTip[i].Width = LATIME_CONTROL;
                lblsTip[i].Text = pom.tip;
                lblsTip[i].Left = DIMENSIUNE_PAS_X;
                lblsTip[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTip[i]);

                //adaugare control de tip Label pentru cantitatea de pomi
                lblsCantitate[i] = new Label();
                lblsCantitate[i].Width = LATIME_CONTROL;
                lblsCantitate[i].Text = pom.cantitate_fructe.ToString();
                lblsCantitate[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsCantitate[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCantitate[i]);

                //adaugare control de tip Label pentru anul plantarii pomilor
                lblsAn[i] = new Label();
                lblsAn[i].Width = LATIME_CONTROL;
                lblsAn[i].Text = pom.anul_plantarii.ToString();
                lblsAn[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsAn[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsAn[i]);
                i++;
            }
        }
        private void AfiseazaLivezi()
        {
            Livada[] livezi = adminLivezi.GetLivada(out int nrlivezi);

            lblsSuprafata= new Label[nrlivezi];
            lblsId = new Label[nrlivezi];
          

            int i = 0;
            foreach (Livada livada in livezi)
            {

                //adaugare control de tip Label pentru suprafata livezi
                lblsSuprafata[i] = new Label();
                lblsSuprafata[i].Width = LATIME_CONTROL;
                lblsSuprafata[i].Text = livada.suprafata.ToString();
                lblsSuprafata[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsSuprafata[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSuprafata[i]);

                //adaugare control de tip Label pentru id-ul livezi;
                lblsId[i] = new Label();
                lblsId[i].Width = LATIME_CONTROL;
                lblsId[i].Text = livada.id_livada;
                lblsId[i].Left = DIMENSIUNE_PAS_X;
                lblsId[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsId[i]);
                i++;
            }
        
         }


    }
}
