using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QFacture
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
            int tip = Login.idtipo;

            if (tip != 1)
            {
                btnInfoUser.Visible = false;
                btnInfoAdmin.Visible = false;
                btnConsultaFactura.Visible = false;
                btnLogOut.Location = new Point(0, 278);
                btnCuenta.Visible = true;
                btnConsultaU.Visible = true;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 250)
            {
                panelMenu.Width = 65;
            }
            else
            {
                panelMenu.Width = 250;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar La Aplicación?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
            int lx, ly;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300, 650);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CapturarF());
        }

        private void btnConsultaFactura_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConsultaF());
        }

        private void btnInfoUser_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InfoUser());
        }

        private void btnInfoAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InfoAdmin());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cuenta());
        }

        private void btnConsultaU_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConsultaU());
        }

        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new Inicio());
        }
    }
}
