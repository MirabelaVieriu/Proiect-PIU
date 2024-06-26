﻿using LibrarieModele;
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
    public partial class FormaPomi : Form
    {
        GestionarePomiFisiereText adminPomi;
        List<Pom> listaPomi = null;


        public FormaPomi()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminPomi = new GestionarePomiFisiereText(caleCompletaFisier);
            listaPomi = adminPomi.GetPomi();
            AfisarePomiInControlDataGridView(listaPomi);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.MaxDate = DateTime.Now;
            lblErori.ForeColor = Color.Red;
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (ValideazaDate())
            {
                string tip = GetTip().ToString();

                int cantitate = Convert.ToInt32( tbCantitate.Text);

                int an = dateTimePicker1.Value.Year;

                Pom pom = new Pom(tip, cantitate, an);

                adminPomi.AddPomi(pom);

                AfisarePomiInControlDataGridView(adminPomi.GetPomi());
                ReseteazaControale();

            }
        }

        private void AfisarePomiInControlDataGridView(List<Pom> pomi)
        {
            dgvPomi.DataSource = null;
            dgvPomi.DataSource = pomi;

        }


        private bool ValideazaDate()
        {
            RadioButton rb = null;
            if (rbMar.Checked)
            {
                rb = rbMar;
            }
            if (rbPar.Checked)
            {
                rb = rbPar;
            }
            if (rbPrun.Checked)
            {
                rb = rbPrun;
            }
            if(rbCires.Checked )
            {
                rb = rbCires;
            }
            if(rbcais.Checked )
            {
                rb=rbcais;
            }
            if(rbpiersic.Checked)
            {
                rb = rbpiersic;
            }
            if(rbgutui.Checked)
            {
                rb= rbgutui;
            }
            if(rbnuc.Checked)
            {
                rb = rbnuc;
            }
             if(rbvisin.Checked)
            {
                rb = rbvisin;
            }
           
            bool status;
            if (rb == null)
            {
                lblErori.Text = "Alege un tip";
                status = false;
            }
            else
            {
                
                status = true;

            }
            if (tbCantitate.Text == String.Empty)
            {
                lblErori.Text = "Introduceti Cantitatea";
                status= false;
            }
            else if(!int.TryParse(tbCantitate.Text, out _))
            {
                lblErori.Text = "Introduceti un numar la cantitate";
                status = false;
            }
            else
            {
                status = true;
            }

            return status;
        }
        private Tip GetTip()
        {
            if (rbMar.Checked)
            {
                return Tip.Mar;
            }
            if (rbPar.Checked)
            {
                return Tip.Par;
            }
            if (rbPrun.Checked)
            {
                return Tip.Prun;
            }
            if (rbCires.Checked)
            {
                return Tip.Cires;
            }
            if(rbcais.Checked)
            {
                return Tip.Cais;
            }
            if(rbpiersic.Checked)
            {
                return Tip.Piersic;
            }
            if(rbgutui.Checked)
            {
                return Tip.Gutui;
            }
            if(rbnuc.Checked)
            {
                return Tip.Nuc;
            }
            if(rbvisin.Checked)
            { 
                return Tip.Visin; 
            }
            return Tip.Necunoscut;
           
        }

        private void ReseteazaControale()
        {
            tbCantitate.Text = string.Empty;
            rbCires.Checked = false;
            rbMar.Checked = false;
            rbPar.Checked = false;
            rbPrun.Checked = false;
            rbcais.Checked = false;
            rbpiersic.Checked = false;
            rbgutui.Checked = false;
            rbnuc.Checked = false;
            rbvisin.Checked = false;
   
        }


        private void btnCauta_Click(object sender, EventArgs e)
        {
            dgvPomi.DataSource = null;
            dgvPomi.Refresh();

            List<string> filtre = new List<string>();
            if(ckbMar.Checked)
            {
                filtre.Add(Tip.Mar.ToString());
            }
            if (ckbPar.Checked)
            {
                filtre.Add(Tip.Par.ToString());
            }
            if(ckbPrun.Checked)
            {
                filtre.Add(Tip.Prun.ToString());
            }
            if(ckbCires.Checked) {
                filtre.Add(Tip.Prun.ToString());
            }
            if (ckbCais.Checked)
            {
                filtre.Add(Tip.Cais.ToString());
            }
            if (ckbPiersic.Checked)
            {
                filtre.Add (Tip.Piersic.ToString());
            }
            if(ckbGutui.Checked)
            {
                filtre.Add(Tip.Gutui.ToString());
            }
            if(ckbNuc.Checked)
            {
                filtre.Add(Tip.Nuc.ToString());
            }
            if(ckbVisin.Checked)
            {
                filtre.Add(Tip.Visin.ToString());
            }

            List<Pom> pomi = adminPomi.GetPomi();
            List<Pom> pomiFilrati = new List<Pom>();

            foreach (Pom pom in pomi)
            {
                foreach(string s in filtre)
                {
                    if(pom.tip == s)
                    {
                        pomiFilrati.Add(pom);
                    }
                }
                
            }
            dgvPomi.DataSource = pomiFilrati;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            AfisarePomiInControlDataGridView(adminPomi.GetPomi());

            ckbMar.Checked = false;
            ckbPar.Checked = false;
            ckbPrun.Checked = false;
            ckbCires.Checked = false;
            ckbCais.Checked = false;
            ckbPiersic.Checked = false;
            ckbGutui.Checked = false;
            ckbNuc.Checked = false;
            ckbVisin.Checked = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            Raportcs form = new Raportcs();


            form.ShowDialog();
        }
    }
}
