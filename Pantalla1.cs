using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TELEPRO
{
    public partial class Pantalla1 : Form
    {
        /*-------------------- DECLARACIÓN DE FUNCIONES --------------------*/
        // fUNCIÓN PARA ABRIR PANELES SECUNDARIOS EN PANEL  CENTRAL
        private void showChildrenPanel(object childPanel)
        {
            if (containerPanel.Controls.Count > 0)
                this.containerPanel.Controls.RemoveAt(0);
            Form panel = childPanel as Form;
            panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            this.containerPanel.Controls.Add(panel);
            this.containerPanel.Tag = panel;
            panel.Show();
        }

        public Pantalla1()
        {
            InitializeComponent();
            
        }

   

        private void Pantalla1_Load(object sender, EventArgs e)
        {
            showChildrenPanel(new firstPanel());

        }

        private void BTEST_Click(object sender, EventArgs e)
        {
        }

        private void BRR_Click(object sender, EventArgs e)
        {
            showChildrenPanel(new firstPanel());
        }

        private void BCP_Click(object sender, EventArgs e)
        {
            showChildrenPanel(new secondPanel());
        }

        private void GB1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void BRR_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void BRR_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void BRR_MouseHover(object sender, EventArgs e)
        {
            ltl.Visible = true;
        }

        private void BRR_MouseLeave(object sender, EventArgs e)
        {
            ltl.Visible = false;
        }

        private void BCP_MouseHover(object sender, EventArgs e)
        {
            L1R.Visible = true;
        }

        private void BCP_MouseLeave(object sender, EventArgs e)
        {
            L1R.Visible = false;
        }
        private void T1_Click(object sender, EventArgs e)
        {

        }
        private void textBox10_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
