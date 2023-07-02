using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora();
            frmBitacora.Show();

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();
        }
    }
}
