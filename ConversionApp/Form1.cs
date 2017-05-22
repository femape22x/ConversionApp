using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            cbxOperador.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabControlCalculator;
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            cbxOperador.SelectedIndex = 0;
            lblResultado.Text = String.Empty;
            txtNumero1.Focus();
        }

        private void rdbConversions_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabControlConversions;
            txtNumero.Text = String.Empty;
            cbxConversion.Text = "Seleccione";
            lblConversion.Text = String.Empty;
            txtNumero.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNumero1.Text.Equals(String.Empty) || txtNumero2.Text.Equals(String.Empty))
            {
                MessageBox.Show("INFORMACIÓN\n\nNo se admiten campos vacios",
                   "",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
                txtNumero1.Text = String.Empty;
                txtNumero2.Text = String.Empty;
                txtNumero1.Focus();
            } else
            {
                String pattern = @"(-)?[0-9]{1,}((.)[0-9]{1,})?";
                Regex exp = new Regex(pattern);
                if (exp.IsMatch(txtNumero1.Text) && exp.IsMatch(txtNumero2.Text))
                {
                    try
                    {
                        decimal num1 = Convert.ToDecimal(txtNumero1.Text);
                        decimal num2 = Convert.ToDecimal(txtNumero2.Text);

                        int operador = cbxOperador.SelectedIndex;
                        TipoOperacionAritmetica tipo = (TipoOperacionAritmetica)operador;
                        switch (tipo)
                        {
                            case TipoOperacionAritmetica.SUMA:
                                lblResultado.Text = Convert.ToString(num1 + num2);
                                break;
                            case TipoOperacionAritmetica.RESTA:
                                lblResultado.Text = Convert.ToString(num1 - num2);
                                break;
                            case TipoOperacionAritmetica.MULTIPLICACION:
                                lblResultado.Text = Convert.ToString(num1 * num2);
                                break;
                            case TipoOperacionAritmetica.DIVISION:
                                lblResultado.Text = Convert.ToString(num1 / num2);
                                break;
                            default:
                                lblResultado.Text = "Operador Descocido.";
                                break;
                        }
                        cbxOperador.Focus();
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("INFORMACIÓN\n\nFormato Númerico Invalido.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                    catch (System.DivideByZeroException)
                    {
                        MessageBox.Show("INFORMACIÓN\n\nNo se permite división por Cero(0).",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                } else
                {
                    MessageBox.Show("INFORMACIÓN\n\nSolo se permite valores Númericos",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    txtNumero1.Text = String.Empty;
                    cbxOperador.SelectedIndex = 0;
                    txtNumero2.Text = String.Empty;
                    txtNumero1.Focus();
                }
            }
        }

        private void rdbAutor_CheckedChanged(object sender, EventArgs e)
        {
            txtNumero.Text = String.Empty;
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            cbxOperador.SelectedIndex = 0;
            cbxConversion.Text = "Seleccione";
            lblResultado.Text = String.Empty;
            lblConversion.Text = String.Empty;
            MessageBox.Show("Desarrollado por:\n\nFelix De Jesus Marrugo Palomino");
            txtNumero.Focus();
            txtNumero1.Focus();
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbxOperador.Focus();
            }
        }

        private void cbxOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumero2.Focus();
            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcular.Focus();
            }
        }

        private void cbxConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String pattern1 = @"^[0-1]+$";
            String pattern2 = @"^[0-9]+$";
            String pattern3 = @"^[0-9A-Fa-f]+$";

            String snum = txtNumero.Text;

            Regex exp = new Regex(pattern3);
            if (exp.IsMatch(snum))
            {
                int conversion = cbxConversion.SelectedIndex;
                TipoConversion tipo = (TipoConversion)conversion;
                switch(tipo)
                {
                    case TipoConversion.BINARIO_DECIMAL:
                        Regex exp1 = new Regex(pattern1);
                        if (exp1.IsMatch(snum))
                        {
                            int num1 = Convert.ToInt32(snum, 2);
                            lblConversion.Text = num1.ToString();
                        }
                        else
                            lblConversion.Text = "El Número ingresado no es Binario";
                        break;
                    case TipoConversion.BINARIO_HEXADECIMAL:
                        Regex exp2 = new Regex(pattern1);
                        if (exp2.IsMatch(snum))
                        {
                            String num2 = Convert.ToString(Convert.ToUInt32(snum, 2), 16).ToUpper();
                            lblConversion.Text = num2;
                        }
                        else
                            lblConversion.Text = "El Número ingresado no es Binario";
                        break;
                    case TipoConversion.DECIMAL_BINARIO:
                        Regex exp3 = new Regex(pattern2);
                        if (exp3.IsMatch(snum))
                        {
                            int num3 = Convert.ToInt16(snum);
                            int res3 = 0;
                            String sal3 = "";
                            while(num3 > 0)
                            {
                                res3 = num3 % 2;
                                num3 = num3 / 2;
                                sal3 = Convert.ToString(res3) + sal3;
                                lblConversion.Text = sal3; 
                            }
                        }
                        else
                            lblConversion.Text = "El Número ingresado no es Decimal";
                        break;
                    case TipoConversion.DECIMAL_HEXADECIMAL:
                        Regex exp4 = new Regex(pattern2);
                        if (exp4.IsMatch(snum))
                        {
                            int num = Convert.ToInt32(snum);
                            String hex = "";
                            while (true)
                            {
                                if ((num % 16) != 0)
                                {
                                    if ((num % 16) > 9)
                                    {
                                        switch (num % 16)
                                        {
                                            case 10:
                                                hex = "A" + hex;
                                                break;
                                            case 11:
                                                hex = "B" + hex;
                                                break;
                                            case 12:
                                                hex = "C" + hex;
                                                break;
                                            case 13:
                                                hex = "D" + hex;
                                                break;
                                            case 14:
                                                hex = "E" + hex;
                                                break;
                                            case 15:
                                                hex = "F" + hex;
                                                break;
                                        }
                                    }
                                    else
                                        hex = (num % 16).ToString() + hex;
                                }
                                else
                                    hex = "0" + hex;

                                num /= 16;
                                if (num <= 0)
                                    break;
                            }
                            lblConversion.Text = hex;
                        } else
                            lblConversion.Text = "El Número ingresado no es Decimal";
                        break;
                    case TipoConversion.HEXADECIMAL_BINARIO:
                        Regex exp5 = new Regex(pattern3);
                        if (exp5.IsMatch(snum))
                        {
                            String num5 = Convert.ToString(Convert.ToInt32(snum, 16), 2);
                            lblConversion.Text = num5;
                        }
                        else
                            lblConversion.Text = "El Número ingresado no es Hexadecimal";
                        break;
                    case TipoConversion.HEXADECIMAL_DECIMAL:
                        Regex exp6 = new Regex(pattern3);
                        if (exp6.IsMatch(snum))
                        {
                            String bin6 = Convert.ToString(Convert.ToInt32(snum, 16), 2);
                            int num6 = Convert.ToInt32(bin6, 2);
                            lblConversion.Text = num6.ToString();
                        }
                        else
                            lblConversion.Text = "El Número ingresado no es Hexadecimal";
                        break;
                }  
            } else
            {
                MessageBox.Show("INFORMACIÓN\n\nSolo se permite ingresar valores"+
                    " númericos y alfanúmericos de la A - F.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtNumero.Text = String.Empty;
                cbxConversion.Text = "Seleccione";
                lblConversion.Text = String.Empty;
                txtNumero.Focus();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbxConversion.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = String.Empty;
            cbxConversion.Text = "Seleccione";
            lblConversion.Text = "";
            txtNumero.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            cbxOperador.SelectedIndex = 0;
            lblResultado.Text = String.Empty;
            txtNumero1.Focus();
        }
    }
}
