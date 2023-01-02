using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using WindowsFormsApp1.Arc;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArcDTO _dto;
        public Form1(ArcDTO dto)
        {
            InitializeComponent();
            _dto = dto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new Model object that represents the Tekla Structures Model you have opened in Tekla Structures.
            Model myModel = new Model();
            if (myModel.GetConnectionStatus())
            {
               TArc arc = new TArc();
                try
                {
                    _dto.span = double.Parse(Span.Text);
                    _dto.numPanels = int.Parse(N_Panels.Text)*2;
                    _dto.innerRadiusOffset = double.Parse(offset.Text);
                    _dto.height = double.Parse(Height.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error! Please check the input format.", "Oops!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Span_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
