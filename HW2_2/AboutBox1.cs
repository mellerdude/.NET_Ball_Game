//Omri Meller
using System;
using System.Drawing;
using System.Windows.Forms;
using static HW2_2.GameForm;

namespace HW2_2
{
    public partial class AboutBox : Form
    {

        public AboutBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void MyText(StyleDelegate styleDelegate)
        {
            StyleInfo styleInfo = styleDelegate?.Invoke();
            if (styleInfo != null)
            {
                textBoxDescription.Font = styleInfo.Font;
                textBoxDescription.Text = styleInfo.Text;
                textBoxDescription.ForeColor = styleInfo.Color;
            }
        }





        private void AboutBox_Load_1(object sender, EventArgs e)
        {



        }
    }
}
