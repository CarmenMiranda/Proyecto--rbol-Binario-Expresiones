using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer22._2__Árbol_binario_Ecuaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BTree arbol = new BTree();

        private void btnResolverPre_Click(object sender, EventArgs e)
        {
            string cadena = arbol.preOrder();
            txtRespuesta.Text = "El resultado por PreOrder es: "+arbol.pilaPre(cadena).ToString();
            MessageBox.Show("PreOrder: " + cadena);
        }

        private void btnResolverPost_Click(object sender, EventArgs e)
        {
            string cadena = arbol.postOrder();
            txtRespuesta.Text = "El resultado por PostOrder es: " + arbol.colaPost(cadena).ToString();
            MessageBox.Show("PostOrder: " + cadena);
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text;
            if (cadena != ""){
                if (arbol.revisarCadena(cadena) == false){
                    MessageBox.Show("Sintaxis de cadena errónea");
                    txtCadena.Focus();
                }
                else{
                    arbol.crearArbol(cadena);
                    MessageBox.Show("Árbol creado");
                    btnResolverPost.Enabled = true;
                    btnResolverPre.Enabled = true;
                }
            }
            else {
                MessageBox.Show("Faltan datos para crear el árbol");
                txtCadena.Focus();
            }
        }

        private void txtCadena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 42 && e.KeyChar != 43 && e.KeyChar != 45 && e.KeyChar != 47 && e.KeyChar != 08){
                e.Handled = true;
                if (char.IsNumber(e.KeyChar))
                    e.Handled = false;
            }
        }
    }
}
