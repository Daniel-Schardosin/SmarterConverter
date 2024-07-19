using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SmartConverter : Form
    {
        private PrivateFontCollection _fontCollection;

        public SmartConverter()
        {
            InitializeComponent();
            LoadCustomFont();
            ApplyFontToControls(this);
        }

        private void LoadCustomFont()
        {
            _fontCollection = new PrivateFontCollection();
            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "SFPRODISPLAYREGULAR.OTF");
            _fontCollection.AddFontFile(fontPath);

            // Define a fonte padrão para o formulário
            this.Font = new Font(_fontCollection.Families[0], 10);
        }

        private void ApplyFontToControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Font = new Font(_fontCollection.Families[0], 10);
                // Recursivamente aplique a todos os controles filhos
                if (control.Controls.Count > 0)
                {
                    ApplyFontToControls(control);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmartConverter_Click(object sender, EventArgs e)
        {
            // Event handler logic here
        }

        private void SmartConverter_Load(object sender, EventArgs e)
        {
            // Event handler logic here
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
