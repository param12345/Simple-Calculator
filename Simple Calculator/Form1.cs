using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Simple_Form : Form
    {
        public Simple_Form()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(FirstNum_Text.Text);
            int second_Number = int.Parse(SecondNum_Text.Text);
            int result = first_Number + second_Number;
            Result_Text.Text = result.ToString();

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
