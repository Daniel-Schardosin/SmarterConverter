using SmartConvert.UserC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.UserC
{
    public partial class Conversor : UserControl
    {
        public Conversor()
        {
            InitializeComponent();


        }
        private void usercontrol2(UserControl userControl)
        {
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Conversorpdf uc = new Conversorpdf();
            usercontrol2(uc);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
