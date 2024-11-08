using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class CalculatorForm : Form
    {
        private string input = string.Empty; 
        private string operador = string.Empty; 
        private double resultado = 0; 
        private bool OperacionP = false; 
        public CalculatorForm()
        {
            InitializeComponent();

        }

        private void Numero_Click(object sender, EventArgs e)
        {
            if (OperacionP)
            {
                input = string.Empty;
                OperacionP = false;
            }

            Button button = (Button)sender;
            input += button.Text; 
            textBox1.Text = input; 
        }

        private void Operacion_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultado != 0 && !OperacionP)
            {
                buttonDiv.PerformClick();
                operador = button.Text; 
                input = resultado.ToString() + operador; 
                textBox1.Text = input;
                OperacionP = true;
            }
            else
            {
                operador = button.Text;
                resultado = Double.Parse(input); 
                input = string.Empty;
                textBox1.Text = resultado + operador; 
            }
        }

        private void Divisiones_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    resultado += Double.Parse(input); 
                    break;
                case "-":
                    resultado -= Double.Parse(input); 
                    break;
                case "*":
                    resultado *= Double.Parse(input); 
                    break;
                case "/":
                    if (Double.Parse(input) != 0)
                    {
                        resultado /= Double.Parse(input); 
                    }
                    else
                    {
                        MessageBox.Show("Error: División por cero.");
                        return;
                    }
                    break;
                default:
                    break;
            }

            textBox1.Text = resultado.ToString(); 
            input = resultado.ToString();
            operador = string.Empty; 
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            resultado = 0; 
            textBox1.Text = "0"; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
