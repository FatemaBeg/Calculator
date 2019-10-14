using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorAppPractice2;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Result _result = new Result();
        
        public CalculatorUi()
        {
            InitializeComponent();
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
           
            _result.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _result.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
           
            resultTextBox.Text = _result.add().ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            _result.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _result.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = _result.Subtract().ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _result.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _result.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = _result.Multiply().ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            _result.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _result.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = _result.Divide().ToString();
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
