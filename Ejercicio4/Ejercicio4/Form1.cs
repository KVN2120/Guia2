using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mayor de pares negativos
            int mayorneg = -1000;
            for (int i = 0; i < listBArreglo.Items.Count; i++)
            {
                string valor = listBArreglo.Items[i].ToString();
                int numero1 = int.Parse(valor);

                if (numero1 < 0 && numero1 % 2 == 0)
                {
                    if (numero1 > mayorneg)
                    {
                        mayorneg = numero1;
                        txbCalc1.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    txbCalc1.Text = "No hay numero negativos pares";
                }
            }

            //Porcentaje de ceros
            double cantidadnumeros = listBArreglo.Items.Count;

            double cantidadceros = 0;
            double porcentaje = 0;

            for (int i = 0; i < listBArreglo.Items.Count; i++)
            {
                string valor = listBArreglo.Items[i].ToString();
                int numero2 = int.Parse(valor);

                if (numero2 == 0)
                {
                    cantidadceros = cantidadceros + 1;

                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txbCalc2.Text = porcentaje.ToString() + "%";

            //Promedio de impares positivos
            double prom;
            double cantidadimpares = 0;
            double suma = 0;

            for (int i = 0; i < listBArreglo.Items.Count; i++)
            {
                string valor = listBArreglo.Items[i].ToString();
                int numero3 = int.Parse(valor);

                if (numero3 > 0 && numero3 % 2 != 0)
                {
                    suma = suma + numero3;
                    cantidadimpares = cantidadimpares + 1;
                }
            }

            prom = suma / cantidadimpares;
            txbCalc3.Text = prom.ToString();

            //Mayor pares positivos
             int mayor = 0;

            for (int i = 0; i < listBArreglo.Items.Count; i++)
            {
                string valor = listBArreglo.Items[i].ToString();
                int numero4 = int.Parse(valor);

                if (numero4 > 0 && numero4 % 2 == 0)
                {
                    if (numero4 > mayor)
                    {
                        mayor = numero4;
                    }
                    txtCalc4.Text = mayor.ToString();
                }
            }
        
        }

        private void txbnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                listBArreglo.Items.Add(txbnumero.Text);
                txbnumero.Clear();
                txbnumero.Focus();
            }
        }

        







    }
}

