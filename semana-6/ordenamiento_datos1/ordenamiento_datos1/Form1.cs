using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenamiento_datos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // llenar los valores de un textbox a un arreglo
            string textoNumeros = txtNumeros.Text;
            string[] valores = textoNumeros.Split(',');
            int[] m = new int[valores.Length];

            // cargar valores de tipo text a una matriz de tipo integer
            for (int i = 0; i < valores.Length; i++)
            {
                m[i] = int.Parse(valores[i]);
            }

            int auxiliar;
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m.Length -1; j++)
                {
                    if (m[j] > m[j + 1])
                    {
                        auxiliar = m[j];
                        m[j] = m[j + 1];
                        m[j + 1] = auxiliar;    
                    }
                }
            }

            string texto = "";
            for (int i = 0; i < m.Length; i++)
            {
                texto += m[i].ToString() + ", ";
            }

            texto = texto.Substring(0, texto.Length - 2);
            // Reportando el resultado
            txtResultado.Text = texto;
            txtResultado.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnQuicksort_Click(object sender, EventArgs e)
        {
            // llenar los valores de un textbox a un arreglo
            string textoNumeros = txtNumeros.Text;
            string[] valores = textoNumeros.Split(',');
            int[] m = new int[valores.Length];

            // cargar valores de tipo text a una matriz de tipo integer
            for (int i = 0; i < valores.Length; i++)
            {
                m[i] = int.Parse(valores[i]);
            }

            Quicksort(m,0, m.Length - 1); 

        }
        public static void Quicksort(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indicePivote = Particionar(arreglo, izquierda, derecha);

                Quicksort(arreglo, izquierda, indicePivote - 1);
                Quicksort(arreglo, indicePivote + 1, derecha);
            }
        }

        private static int Particionar(int[] arreglo, int izquierda, int derecha)
        {
            int pivote = arreglo[derecha];
            int i = izquierda - 1;
            for (int j = izquierda; j < derecha; j++)
            {
                if (arreglo[j] <= pivote)
                {
                    i++;
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                    int temp2 = arreglo[i + 1];
                    arreglo[i + 1] = arreglo[derecha];
                }
            }
        }
    }
}
