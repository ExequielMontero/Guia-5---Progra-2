using Ejercicio_1.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Presupuesto pedido;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDir.Text;
            pedido = new Presupuesto(nombre, direccion);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmBorrar != null)
            {
                int idx = Convert.ToInt32(cmBorrar.SelectedItem);
                
                pedido.QuitarProducto(idx);
                cmBorrar.Items.Remove(idx);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double Preciob = Convert.ToDouble(tbPrecio.Text);
            double Largo = Convert.ToDouble(tbLargo.Text);
            double Ancho = Convert.ToDouble(tbAncho.Text);
            double Grosor = Convert.ToDouble(tbGrosor.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);
            Producto b;
            if (rbMesa.Checked)
            {
                b = new Mesa(Preciob, Largo, Ancho, Grosor);
                b.Codigo = codigo;
                pedido.AgregarProducto(b);
                cmBorrar.Items.Add(codigo);
            }
            else if (rbBanco.Checked)
            {
                b = new Banco(Preciob, Largo);
                b.Codigo = codigo;
                pedido.AgregarProducto(b);
                cmBorrar.Items.Add(codigo);
            }
        }

        private void btnCerrarPre_Click(object sender, EventArgs e)
        {
            string[] b = pedido.Resumen();
            FormVer p = new FormVer();
            foreach(string h in b)
            {
                p.tbVer.Text += $"{h}\r\n"; 
            }
            p.ShowDialog();
            pedido = null;
            tbNombre.Clear();
            tbDir.Clear();
        }
    }
}
