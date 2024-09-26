using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion_Contactos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void abrir_frm(object frmhijo)
        {
            if (this.panelGeneral.Controls.Count > 0)
            {
                this.panelGeneral.Controls.RemoveAt(0);
            }
            Form frm = frmhijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelGeneral.Controls.Add(frm);
            this.panelGeneral.Tag = frm;
            frm.Show();
        }
        public void ColorBtn(Panel panel)
        {
            foreach (Control btn in panel.Controls)
            {
                if (btn is Button)
                {
                    if (btn.BackColor == Color.FromArgb(79, 44, 96))
                    {
                        btn.BackColor = Color.FromArgb(11, 8, 19);
                    }
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            ColorBtn(panelmenu);
            btnContactos.BackColor = Color.FromArgb(79, 44, 96);
            abrir_frm(new frmContactos());
            
        }

        private void btnEli_Modi_Click(object sender, EventArgs e)
        {
            ColorBtn(panelmenu);
            btnEli_Modi.BackColor = Color.FromArgb(79, 44, 96);
            abrir_frm(new frmElim_Modi());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ColorBtn(panelmenu);
            btnBuscar.BackColor = Color.FromArgb(79, 44, 96);
            abrir_frm(new frmBuscar());
        }

     
    }
}
