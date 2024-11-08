using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editor;
using Paint;
using WindowsFormsApp1;

namespace Tarea1P2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Editor_Click(object sender, EventArgs e)
        {
           
            EditorForm textEditorForm = new EditorForm();

            
            textEditorForm.Show();
        }

        private void Paint_Click(object sender, EventArgs e)
        {
            PaintForm paintForm = new PaintForm();

            paintForm.Show();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();

            calculatorForm.Show();
        }
    }
}
