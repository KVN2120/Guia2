using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ValidarText(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        public void ValidarApellido(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        public void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarText(sender, e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarApellido(sender, e);
        }

        private void txtsalariobruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salarioneto, salariobase, impuesto1, impuesto2, impuesto3, descuento;


            try
            {

                salariobase = Convert.ToDouble(txtsalariobruto.Text);


                impuesto1 = 20 % -salariobase;
                impuesto2 = 15 % -salariobase;
                impuesto3 = 5 % -salariobase;
                salarioneto = 0;
                descuento = 0;

                if (rdb1.Checked == true)
                {
                    impuesto1 = salariobase * 0.20;
                    salarioneto = salariobase - impuesto1;
                    descuento = impuesto1;
                }
                if (rdb2.Checked == true)
                {
                    impuesto2 = salariobase * 0.15;
                    salarioneto = salariobase - impuesto2;
                    descuento = impuesto2;
                }
                if (rdb3.Checked == true)
                {
                    impuesto3 = salariobase * 0.05;
                    salarioneto = salariobase - impuesto3;
                    descuento = impuesto3;
                }

                txtdescuento.Text = descuento.ToString();
                txtsalarioneto.Text = salarioneto.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            if (MessageBox.Show("Desea salir?", "Confirmar salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        





        }
    }
 


