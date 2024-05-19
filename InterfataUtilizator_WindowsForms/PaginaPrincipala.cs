using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class PaginaPrincipala : Form
    {
        public PaginaPrincipala()
        {
            InitializeComponent();
        }

        private void PaginaPrincipala_Load(object sender, EventArgs e)
        {

        }


        private void Livezi_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            forma.ShowDialog();
        }

        private void Pomi_Click(object sender, EventArgs e)
        {
            Form1 form=new Form1();
            form.ShowDialog();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
