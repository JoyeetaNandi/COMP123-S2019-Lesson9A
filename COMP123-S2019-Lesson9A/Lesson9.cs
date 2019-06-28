using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson9A
{
    public partial class Lesson9 : Form
    {
        public Lesson9()
        {
            InitializeComponent();
        }

        private void CalculatorNumbersClick(object sender, EventArgs e)
        {
            Button seletedButton = sender as Button;
            try
            {
                int.Parse(seletedButton.Text);
                ResultLabel.Text = seletedButton.Text;
            }
            catch 
            {
                ResultLabel.Text = "Not a Number";
                
            }
            //Button seletedButton = (Button)sender;
            //ResultLabel.Text = seletedButton.Text;
            //ResultLabel.Text = sender.ToString();
            //switch (seletedButton.Text)
            //{
            //    case "1":
            //        ResultLabel.Text = "1";
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
